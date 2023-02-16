using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Test
{
    public partial class FormINFO : Form
    {
        FRM_GRIDVIEW fgrid;
        public FormINFO(FRM_GRIDVIEW fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }
        private void button_ADD_Click_1(object sender, EventArgs e)
        {
            fgrid.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }

    
    }
}
