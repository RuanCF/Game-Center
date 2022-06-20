using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Center.Home
{
    public partial class ScoreScreen : Form
    {
        public ScoreScreen()
        {
            InitializeComponent();
        }
        private DataSet _DataSet;
        private void inicializaListView()
        {
          
            listView1.View = View.Details;
     
            listView1.LabelEdit = true;
         
            listView1.AllowColumnReorder = true;
            
            listView1.FullRowSelect = true;
      
            listView1.GridLines = true;

        
            listView1.Columns.Add("NickName", 234, HorizontalAlignment.Left);
            listView1.Columns.Add("Score", 234, HorizontalAlignment.Center);
           
        }
        private void carregaLista()
        {
            
            DataTable dtable = _DataSet.Tables["UserData"];

 
            listView1.Items.Clear();

           
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

              
                if (drow.RowState != DataRowState.Deleted)
                {
                    
                    ListViewItem lvi = new ListViewItem(drow["NickName"].ToString());
                    lvi.SubItems.Add(drow["Score"].ToString());
                   

                    listView1.Items.Add(lvi);
                }
            }
        }
        public void getdados()
        {
            ConnectDB connectDB = new();
            connectDB.conn.Open();
            string Sqlite = "SELECT NickName,Score FROM UserData ORDER BY Score DESC";
            SQLiteDataAdapter adapter = new(Sqlite, connectDB.conn);
            _DataSet = new DataSet();
            adapter.Fill(_DataSet, "UserData");
        }

        private void ScoreScreen_Load(object sender, EventArgs e)
        {
            inicializaListView();
            getdados();
            carregaLista();
        }

        private void ScoreScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeScreen homeScreen = new();
            homeScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new();
            this.Hide();
            homeScreen.Closed += (s, args) => this.Close();
            homeScreen.Show();
        }
    }
}
