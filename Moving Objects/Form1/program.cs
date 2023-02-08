using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Moving_Objects.helperClassforControlMover.Init(this.button1);
            Moving_Objects.helperClassforControlMover.Init(this.groupBox1);
            Moving_Objects.helperClassforControlMover.Init(this.label1);



        }
}
}
