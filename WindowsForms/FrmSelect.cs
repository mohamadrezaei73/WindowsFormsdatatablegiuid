using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        private void BtnSabt_Click(object sender, EventArgs e)
        {

        }

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            ComboboxObjects cbo = new ComboboxObjects();
            cbo.Text = "جایگاه های خالی ";
            cbo.Value = "TbljobPosition";
            ComboboxObjects cbo2 = new ComboboxObjects();
            cbo.Text = " کاربرها  ";
            cbo.Value = "TblFirstLoad";
            comboBox1.Items.Add(cbo);
            comboBox1.Items.Add(cbo);
            comboBox1.SelectedIndex = 0; 
        }
    }
}
