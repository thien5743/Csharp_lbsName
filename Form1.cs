using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_lbsName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Add(txtten.Text);
        }

        private void lbsketqua_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbsketqua.Items.Add("tran to minh \tthien");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Remove(txtten.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbsketqua.SelectedIndex < 0) return;
            lbsketqua.Items[lbsketqua.SelectedIndex] = txtten.Text;
        }
    }
}
