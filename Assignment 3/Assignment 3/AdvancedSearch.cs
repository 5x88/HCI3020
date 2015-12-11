using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class AdvancedSearch : Form
    {
        MainScreen parent;
        public AdvancedSearch(MainScreen sender)
        {
            parent = sender;
            sender.Hide();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {



            parent.Visible = true;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
