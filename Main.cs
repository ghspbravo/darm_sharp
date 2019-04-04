using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene.Net.Util;

namespace DARM_sharp
{
    public partial class Main : Form
    {
        // Ensures index backwards compatibility
        public static string indexLocation = System.IO.Directory.GetCurrentDirectory();
        public static FSDirectory dir = FSDirectory.Open(indexLocation);

        public static LuceneVersion AppLuceneVersion = LuceneVersion.LUCENE_48;

        //create an analyzer to process the text
        public static StandardAnalyzer analyzer = new StandardAnalyzer(AppLuceneVersion);

        //create an index writer
        public static IndexWriterConfig indexConfig = new IndexWriterConfig(AppLuceneVersion, analyzer);
        public static IndexWriter writer = new IndexWriter(dir, indexConfig);

        public void loadLuceneResultsToView(string query, string type)
        {
            searchResults.Rows.Clear();
            var searcher = new IndexSearcher(writer.GetReader(applyAllDeletes: true));
            var res = new ScoreDoc[10];

            switch (type)
            {
                case "partTitleAndYear":
                    var queryIsString = 0;
                    int.TryParse(query, out queryIsString);

                    if (queryIsString == 0)
                    {
                        var stringPartTitleAndYear = new WildcardQuery(new Term("title", "*" + query.ToLower() + "*"));
                        res = searcher.Search(stringPartTitleAndYear, 10).ScoreDocs;
                    }
                    else
                    {
                        var numPartTitleAndYear = new PhraseQuery();
                        numPartTitleAndYear.Add(new Term("year", query.ToLower()));
                        res = searcher.Search(numPartTitleAndYear, 10).ScoreDocs;
                    }
                    break;
                case "partTitle":
                    var partTitle = new WildcardQuery(new Term("title", "*" + query.ToLower() + "*"));
                    res = searcher.Search(partTitle, 10).ScoreDocs;
                    break;
                case "allWords":
                    var allWords = new MultiPhraseQuery();
                    allWords.Add(new Term("full_title", query));
                    res = searcher.Search(allWords, 10).ScoreDocs;
                    break;
                case "oneWord":
                    var oneWord = new PhraseQuery();
                    oneWord.Add(new Term("title", query.ToLower()));
                    res = searcher.Search(oneWord, 10).ScoreDocs;
                    break;

                default:
                    break;
            }
            if (res.Length != 0)
            {
                foreach (var hit in res)
                {
                    var doc = searcher.Doc(hit.Doc);
                    searchResults.Rows.Add(doc.GetField("id").GetInt32Value().ToString(),
                        doc.GetField("title").GetStringValue(),
                        doc.GetField("year").GetStringValue());
                }
            }

        }

        [Obsolete]
        public void fillWriterWithDataFromDb()
        {
            searchButton.Enabled = false;
            var conn = new NpgsqlConnection("Server=db.mirvoda.com; Port=5454; User Id=developer; Password=rtfP@ssw0rd; Database=darm");
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT * FROM movies", conn);

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    Console.WriteLine(writer);
                    var source_id = reader.GetInt32(0);
                    var source_name = reader.GetString(1);
                    var yearInt = 0;
                    int.TryParse(reader.GetInt16(2).ToString(), out yearInt);

                    var doc = new Document();

                    doc.Add(new StoredField("id", source_id));
                    doc.Add(new Field("title", source_name, Field.Store.YES, Field.Index.ANALYZED));
                    doc.Add(new Field("full_title", source_name, Field.Store.YES, Field.Index.NOT_ANALYZED));
                    doc.Add(new Field("year", yearInt.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                    writer.AddDocument(doc);
                }
                catch
                {
                    // Error handler
                }
            }
            reader.Close();
            searchButton.Enabled = true;
        }

        public string getFilterValue()
        {
            if (partTitleAndYearFilter.Checked) return "partTitleAndYear";
            if (partTitleFilter.Checked) return "partTitle";
            if (allWordsInTitleFilter.Checked) return "allWords";
            if (OneWordInTitleFilter.Checked) return "oneWord";

            return "";
        }

        public void LoadDbResultsToView(string query, string searchParam = "")
        {
            searchResults.Rows.Clear();
            var conn = new NpgsqlConnection("Server=db.mirvoda.com; Port=5454; User Id=developer; Password=rtfP@ssw0rd; Database=darm");
            conn.Open();
            var cmd = new NpgsqlCommand(query, conn);

            if (searchParam != "")
            {
                cmd.Parameters.Add("@string", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Parameters["@string"].Value = searchParam;
                cmd.Parameters.AddWithValue(searchParam);
            }
                 
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    var source_id = reader.GetInt32(0);
                    var source_name = reader.GetString(1);
                    var yearInt = 0;
                    int.TryParse(reader.GetInt16(2).ToString(), out yearInt);

                    searchResults.Rows.Add(reader.GetInt32(0), reader.GetString(1), yearInt.ToString());
                }
                catch
                {
                    // Error handler
                }
            }
            reader.Close();

        }

        public Main()
        {
            InitializeComponent();

            LoadDbResultsToView("SELECT * FROM movies LIMIT 100");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var query = searchInput.Text;
            if (query == "") return;

            if (useLuceneCheckBox.Checked)
            {
                loadLuceneResultsToView(query, getFilterValue());
            }
            else
            {
                var queryIsString = 0;
                int.TryParse(query, out queryIsString);

                var oneOfWordsSearchInName =
                    "SELECT * FROM movies WHERE name ILIKE '% ' || @string || ' %' LIMIT 10";
                var partSearchInName = "SELECT * FROM movies WHERE name ILIKE '%' || @string || '%' LIMIT 10";
                var allWordsSearchInName = "SELECT * FROM movies WHERE name = @string LIMIT 10";
                var partSearchOrYearInName = queryIsString == 0
                    ? "SELECT * FROM movies WHERE name ILIKE '%' || @string || '%' LIMIT 10"
                    : "SELECT * FROM movies WHERE year = " + query + " LIMIT 10";

                switch (getFilterValue())
                {
                    case "partTitleAndYear":
                        LoadDbResultsToView(partSearchOrYearInName, query);
                        break;
                    case "partTitle":
                        LoadDbResultsToView(partSearchInName, query);
                        break;
                    case "allWords":
                        LoadDbResultsToView(allWordsSearchInName, query);
                        break;
                    case "oneWord":
                        LoadDbResultsToView(oneOfWordsSearchInName, query);
                        break;

                    default:
                        break;
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadDbResultsToView("SELECT * FROM movies LIMIT 100");
            searchInput.Text = "";
        }

        [Obsolete]
        private void UseLuceneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (writer.NumDocs == 0) fillWriterWithDataFromDb();
        }
    }
}
