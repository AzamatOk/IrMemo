using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrMemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("i.jpg");

        }

        private void bAcceptOp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
