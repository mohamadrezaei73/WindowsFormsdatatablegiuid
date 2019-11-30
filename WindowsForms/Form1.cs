using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseConnector;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private object dgv1_MainDataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_insert_MouseEnter(object sender, EventArgs e)
        {
               ((Button)sender).BackColor = Color.Gray;
               ((Button)sender).ForeColor = Color.White;
        }

        private void Btn_Select_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender , EventArgs e )
        {
         
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            PDBC dbObj = new PDBC();
            dbObj.Connect();
            DataTable dt = dbObj.Select("SELECT  [id],[Name],[LastName] FROM [TblFirstLoad]");
            dbObj.DC();
            lblTblName.Text = "On table :\ntblFirstLoad"; 

            dataGridView1.DataSource = dt;
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {

        }

        private void Btn_change_Click(object sender, EventArgs e)
        {

        }
    }
}
