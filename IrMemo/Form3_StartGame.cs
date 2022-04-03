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
    public partial class Form3_StartGame : Form
    {
        public Form3_StartGame()
        {
            InitializeComponent();
        }

        private void Form3_StartGame_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(4);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bCloseGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
