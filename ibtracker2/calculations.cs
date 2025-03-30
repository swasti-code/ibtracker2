using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibtracker2
{
    public partial class calculations : Form
    {
        public calculations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Group1, Group2, Group3, Group4, Group5, Group6, Total, Core;
            string EE, TOK, Dipolma;

            Group1 = int.Parse(txtGroup1.Text);
            Group2 = int.Parse(txtGroup2.Text);
            Group3 = int.Parse(txtGroup3.Text);
            Group4 = int.Parse(txtGroup4.Text);
            Group5 = txtGroup5.Text;
            Group6 = txtGroup6.Text;
            Core = txtCore.Text;
            EE = txtEE.Text;
            TOK = txtTOK.Text;
        }
    }
}
