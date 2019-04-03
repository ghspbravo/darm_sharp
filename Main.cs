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

namespace DARM_sharp
{
    public partial class Main : Form
    {
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
            var queryIsString = 0;
            int.TryParse(query, out queryIsString);

            var oneOfWordsSearchInName =
                "SELECT * FROM movies WHERE name ILIKE '% ' || @string || ' %' LIMIT 10";
            var partSearchInName = "SELECT * FROM movies WHERE name ILIKE '%' || @string || '%' LIMIT 10";
            var allWordsSearchInName = "SELECT * FROM movies WHERE name = @string LIMIT 10";
            var partSearchOrYearInName = queryIsString == 0
                ? "SELECT * FROM movies WHERE name ILIKE '%' || @string || '%' LIMIT 10"
                : "SELECT * FROM movies WHERE year = " + query + " LIMIT 10";

            switch(getFilterValue())
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadDbResultsToView("SELECT * FROM movies LIMIT 100");
            searchInput.Text = "";
        }
    }
}
