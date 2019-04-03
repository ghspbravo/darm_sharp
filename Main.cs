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

            using (var conn =
                new NpgsqlConnection(
                    "Server=db.mirvoda.com; Port=5454; User Id=developer; Password=rtfP@ssw0rd; Database=darm"))
            {
                conn.Open();
            }

        }
    }
}
