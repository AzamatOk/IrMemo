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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Image.FromFile("фон.jpg");
            this.bOptions.BackColor = System.Drawing.Color.Transparent;
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStartGame.BackColor = System.Drawing.Color.Transparent;
            this.bStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bOptions_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void bStartGame_Click(object sender, EventArgs e)
        {
            Form3_StartGame form = new Form3_StartGame();
            form.ShowDialog();
        }
    }
}
