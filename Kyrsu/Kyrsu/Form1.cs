using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;  

namespace Kyrsu
{
    public partial class Form1 : Form
    {
        string conectionString;
        public Form1()
        {
            InitializeComponent();
            conectionString = @" Data Source = C:\ProjectGit\Kyrsu\BDKyrsu.db; Version = 3 "; 
        }
        SQLiteDataAdapter mda;
        SQLiteConnection mcon;
        DataTable dt = new DataTable();
        int ii = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            mcon = new SQLiteConnection(conectionString);
            mda = new SQLiteDataAdapter(" select * from Test1", mcon);
            mda.Fill(dt);
        }
}
