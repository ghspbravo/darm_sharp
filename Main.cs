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
        public Main()
        {
            InitializeComponent();

            var conn = new NpgsqlConnection("Server=db.mirvoda.com; Port=5454; User Id=developer; Password=rtfP@ssw0rd; Database=darm");

            LoadResultsToView("SELECT * FROM movies LIMIT 100", conn);
        }

        public void LoadResultsToView(string query, NpgsqlConnection conn)
        {
            conn.Open();
            var cmd = new NpgsqlCommand(query, conn);

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
    }
}
