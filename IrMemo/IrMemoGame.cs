using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace IrMemo
{
    public partial class Menu : Form
    {
        public Menu()
        {         
            InitializeComponent();
            panel1.Height = 870;
            cbComplexity.SelectedIndex = 0;
            cbСards.SelectedIndex = 1;
            cbСardsType.SelectedIndex = 1;
            cBTimer.SelectedIndex = 0;
            tcMenuAndOptions.TabPages.Remove(tabPage2);
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Image.FromFile("fon.jpg");
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStartGame.BackColor = System.Drawing.Color.Transparent;
            this.bStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcMenuAndOptions.BackColor = System.Drawing.Color.Transparent;
            this.bOptions.BackColor = System.Drawing.Color.Transparent;
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTime.BackColor = System.Drawing.Color.Transparent;
            this.lTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEndGame.BackColor = System.Drawing.Color.Transparent;
            this.bEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOptionsAccept.BackColor = System.Drawing.Color.Transparent;
            this.bOptionsAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            panel1.Visible = false;
            dGVPlayingField.Visible = false;
            dGVPlayingField.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGVWords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Controls.Remove(panel1);
            cbComplexity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbСards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbСardsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }
        int dGVWordsHeight = 0;
        int DataGridWidth = 0;
        int DataGridHeight = 0;
        int FirstClickRow;
        int FirstClickColum;
        int SecondClickRow = 0;
        int SecondClickColum = 0;
        int CellClickCounter = 0;
        int LeftWord = 0;
        int Timer = 0;
        int GameGo = 0;



        Image Deleted = Image.FromFile("Deleted.bmp");

        Image Word = Image.FromFile("Word.bmp");
        Image Back = Image.FromFile("Back.bmp");

        Fill CardsFill;
        Clock Time;

        public void Form1_Load(object sender, EventArgs e)
        {
            dGVPlayingField.RowCount = 4;
            dGVWords.RowCount = 8;
            dGVWords.Width = 304;

            CardsFill = new Fill(dGVPlayingField.RowCount, dGVPlayingField.ColumnCount, cbСardsType.SelectedIndex);           
        }



        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
         
        private void bStartGame_Click(object sender, EventArgs e)
        {
            Timer = 0;
            GameGo = 0;
            dGVPlayingField.Enabled = true;
            bOptions.Enabled = false;
            bStartGame.Enabled = false;
            bExit.Enabled = false;
            timer1.Enabled = true;
            if (cBTimer.SelectedIndex > 1)
            {
                Timer = Convert.ToInt32( this.cBTimer.GetItemText(this.cBTimer.SelectedItem));               
            }


            this.Controls.Add(panel1);
            panel1.Refresh();

            DataGridWidth = dGVPlayingField.ColumnCount * 150 + 2;
            DataGridHeight = dGVPlayingField.RowCount * 100 + 2;
            dGVWordsHeight = dGVWords.RowCount * 100 + 13;
            
            
            for (int i = 0; i < dGVPlayingField.RowCount; i++)
                for (int j = 0; j < dGVPlayingField.ColumnCount; j++)
                {
                    dGVPlayingField.Rows[i].Cells[j].Value = Back;
                }
            for (int i = 0; i < dGVWords.RowCount; i++)
                for (int j = 0; j < dGVWords.ColumnCount; j++)
                {
                    dGVWords.Rows[i].Cells[j].Value = Word;
                }
            panel1.Visible = true;
            dGVPlayingField.Visible = true;
            dGVPlayingField.Width = DataGridWidth;
            dGVPlayingField.Height = DataGridHeight;
            dGVWords.Height = dGVWordsHeight;
            
        }

        private void bOptions_Click(object sender, EventArgs e)
        {
            tcMenuAndOptions.TabPages.Remove(tabPage1);
            tcMenuAndOptions.TabPages.Add(tabPage2);
        }

        private void bOptionsAccept_Click(object sender, EventArgs e)
        {
            lTime.Visible = false;
            tcMenuAndOptions.TabPages.Add(tabPage1);
            tcMenuAndOptions.TabPages.Remove(tabPage2);
            if (cbComplexity.SelectedIndex == 1)
            {
                panel1.Height = 1070;
                dGVPlayingField.RowCount = 5;
                dGVWords.RowCount = 10;

            }
            else
            {
                panel1.Height = 870;
                dGVPlayingField.RowCount = 4;
                dGVWords.RowCount = 8;

            }
            if (cBTimer.SelectedIndex > 1)
            {
                string selectedText = this.cBTimer.GetItemText(this.cBTimer.SelectedItem);
            }
            CardsFill = new Fill(dGVPlayingField.RowCount, dGVPlayingField.ColumnCount, cbСardsType.SelectedIndex);
        }


        private void dGVPlayingField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CardsFill.GetnIdices(e.RowIndex, e.ColumnIndex) != "Deleted.bmp")
            {

                CellClickCounter++;

                if (cbСards.SelectedIndex == 1)
                {
                    dGVPlayingField.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (Image)Properties.Resources.ResourceManager.GetObject(CardsFill.GetnIdices(e.RowIndex, e.ColumnIndex));
                }
                if(cbСards.SelectedIndex == 0)
                {
                    dGVPlayingField.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Image.FromFile("WordsWithImage/" + CardsFill.GetnIdices(e.RowIndex, e.ColumnIndex) + ".bmp");
                }
              

                if (CellClickCounter == 1)
                {

                    var wmp = new WMPLib.WindowsMediaPlayer();
                    wmp.URL = "Audio/" + CardsFill.GetnIdices(e.RowIndex, e.ColumnIndex) + ".mp3";
                    wmp.controls.play();

                    FirstClickRow = e.RowIndex;
                    FirstClickColum = e.ColumnIndex;

                }
                
                if (CellClickCounter == 2)
                {
                    var wmp = new WMPLib.WindowsMediaPlayer();
                    wmp.URL = "Audio/" + CardsFill.GetnIdices(e.RowIndex, e.ColumnIndex) + ".mp3";
                    wmp.controls.play();

                    dGVPlayingField.Refresh();
                 
                    SecondClickRow = e.RowIndex;
                    SecondClickColum = e.ColumnIndex;
                    CellClickCounter = 0;

                    string str1 = CardsFill.GetnIdices(FirstClickRow, FirstClickColum);
                    str1 = str1.Remove(str1.Length - 1);
                    string str2 = CardsFill.GetnIdices(SecondClickRow, SecondClickColum);
                    str2 = str2.Remove(str2.Length - 1);
                    if (str1 == str2 && CardsFill.GetnIdices(FirstClickRow, FirstClickColum) != CardsFill.GetnIdices(SecondClickRow, SecondClickColum))
                    {
                        GameGo++;
                        dGVWords.Rows[LeftWord].Cells[0].Value = (Image)Properties.Resources.ResourceManager.GetObject(CardsFill.GetnIdices(FirstClickRow, FirstClickColum));
                        dGVWords.Rows[LeftWord].Cells[1].Value = (Image)Properties.Resources.ResourceManager.GetObject(CardsFill.GetnIdices(SecondClickRow, SecondClickColum));
                        LeftWord++;
                        CardsFill.SetDeleted(FirstClickRow, FirstClickColum, "Deleted.bmp");
                        CardsFill.SetDeleted(SecondClickRow, SecondClickColum, "Deleted.bmp");
                        dGVPlayingField.Rows[FirstClickRow].Cells[FirstClickColum].Value = Deleted;
                        dGVPlayingField.Rows[SecondClickRow].Cells[SecondClickColum].Value = Deleted;
                    }
                    else
                    {
                        dGVPlayingField.Rows[FirstClickRow].Cells[FirstClickColum].Value = Back;
                        dGVPlayingField.Rows[SecondClickRow].Cells[SecondClickColum].Value = Back;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
            

        }

        private void bEndGame_Click(object sender, EventArgs e)
        {
            LeftWord = 0;
            bOptions.Enabled = true;
            bStartGame.Enabled = true;
            bExit.Enabled = true;
            CardsFill = new Fill(dGVPlayingField.RowCount, dGVPlayingField.ColumnCount, cbСardsType.SelectedIndex);
            LeftWord = 0;
            lTime.Text = "";

            this.Controls.Remove(panel1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time = new Clock();
            if (cBTimer.SelectedIndex > 1)
            {
                lTime.Visible = true;
                Timer--;
                lTime.Text = Time.StopatchTimer(Timer);
                if (Timer-1 == -1)
                {
                    dGVPlayingField.Enabled = false;
                    timer1.Enabled = false;
                    lTime.Text = "Время истекло";
                }
                if (GameGo == dGVPlayingField.RowCount * dGVPlayingField.ColumnCount / 2)
                {
                    timer1.Enabled = false;
                }

            }
            if (cBTimer.SelectedIndex ==  1)
            {
                lTime.Visible = true;
                Timer++;
                lTime.Text = Time.StopatchTimer(Timer);
                if (GameGo == dGVPlayingField.RowCount * dGVPlayingField.ColumnCount / 2)
                {
                    timer1.Enabled = false;
                }
            }

        }
    }
}
