
namespace IrMemo
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bExit = new System.Windows.Forms.Button();
            this.bStartGame = new System.Windows.Forms.Button();
            this.tcMenuAndOptions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bOptions = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbСardsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bOptionsAccept = new System.Windows.Forms.Button();
            this.cbСards = new System.Windows.Forms.ComboBox();
            this.cbComplexity = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVWords = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bEndGame = new System.Windows.Forms.Button();
            this.dGVPlayingField = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tcMenuAndOptions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayingField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.SystemColors.Control;
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bExit.Location = new System.Drawing.Point(70, 273);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(192, 104);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "Выйти из игры";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bStartGame
            // 
            this.bStartGame.BackColor = System.Drawing.SystemColors.Control;
            this.bStartGame.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStartGame.Location = new System.Drawing.Point(70, 53);
            this.bStartGame.Name = "bStartGame";
            this.bStartGame.Size = new System.Drawing.Size(192, 104);
            this.bStartGame.TabIndex = 2;
            this.bStartGame.Text = "Играть";
            this.bStartGame.UseVisualStyleBackColor = false;
            this.bStartGame.Click += new System.EventHandler(this.bStartGame_Click);
            // 
            // tcMenuAndOptions
            // 
            this.tcMenuAndOptions.Controls.Add(this.tabPage1);
            this.tcMenuAndOptions.Controls.Add(this.tabPage2);
            this.tcMenuAndOptions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcMenuAndOptions.ItemSize = new System.Drawing.Size(42, 18);
            this.tcMenuAndOptions.Location = new System.Drawing.Point(12, 621);
            this.tcMenuAndOptions.Name = "tcMenuAndOptions";
            this.tcMenuAndOptions.SelectedIndex = 0;
            this.tcMenuAndOptions.Size = new System.Drawing.Size(347, 451);
            this.tcMenuAndOptions.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bOptions);
            this.tabPage1.Controls.Add(this.bExit);
            this.tabPage1.Controls.Add(this.bStartGame);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главное меню";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bOptions
            // 
            this.bOptions.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOptions.Location = new System.Drawing.Point(70, 163);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(192, 104);
            this.bOptions.TabIndex = 3;
            this.bOptions.Text = "Настройки";
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbСardsType);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bOptionsAccept);
            this.tabPage2.Controls.Add(this.cbСards);
            this.tabPage2.Controls.Add(this.cbComplexity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Отключено",
            "Секундомер",
            "40 ",
            "50 ",
            "60",
            "70",
            "80",
            "90"});
            this.comboBox1.Location = new System.Drawing.Point(225, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 27);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ограничение по времени (сек)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тематика слов";
            // 
            // cbСardsType
            // 
            this.cbСardsType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbСardsType.FormattingEnabled = true;
            this.cbСardsType.Items.AddRange(new object[] {
            "Дикие животные",
            "Природа",
            "Домашние животные"});
            this.cbСardsType.Location = new System.Drawing.Point(139, 233);
            this.cbСardsType.Name = "cbСardsType";
            this.cbСardsType.Size = new System.Drawing.Size(197, 27);
            this.cbСardsType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отображать картинки к словам?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер поля";
            // 
            // bOptionsAccept
            // 
            this.bOptionsAccept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOptionsAccept.Location = new System.Drawing.Point(202, 374);
            this.bOptionsAccept.Name = "bOptionsAccept";
            this.bOptionsAccept.Size = new System.Drawing.Size(84, 28);
            this.bOptionsAccept.TabIndex = 2;
            this.bOptionsAccept.Text = "Принять";
            this.bOptionsAccept.UseVisualStyleBackColor = true;
            this.bOptionsAccept.Click += new System.EventHandler(this.bOptionsAccept_Click);
            // 
            // cbСards
            // 
            this.cbСards.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbСards.FormattingEnabled = true;
            this.cbСards.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.cbСards.Location = new System.Drawing.Point(276, 120);
            this.cbСards.Name = "cbСards";
            this.cbСards.Size = new System.Drawing.Size(57, 27);
            this.cbСards.TabIndex = 1;
            // 
            // cbComplexity
            // 
            this.cbComplexity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbComplexity.FormattingEnabled = true;
            this.cbComplexity.Items.AddRange(new object[] {
            "4 на 4",
            "5 на 4"});
            this.cbComplexity.Location = new System.Drawing.Point(151, 57);
            this.cbComplexity.Name = "cbComplexity";
            this.cbComplexity.Size = new System.Drawing.Size(182, 27);
            this.cbComplexity.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dGVWords);
            this.panel1.Controls.Add(this.bEndGame);
            this.panel1.Controls.Add(this.dGVPlayingField);
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 1048);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(814, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Найденные слова";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(211, 643);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 3;
            // 
            // dGVWords
            // 
            this.dGVWords.AllowUserToAddRows = false;
            this.dGVWords.AllowUserToDeleteRows = false;
            this.dGVWords.AllowUserToResizeColumns = false;
            this.dGVWords.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dGVWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWords.ColumnHeadersVisible = false;
            this.dGVWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVWords.DefaultCellStyle = dataGridViewCellStyle14;
            this.dGVWords.Location = new System.Drawing.Point(760, 47);
            this.dGVWords.Name = "dGVWords";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVWords.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dGVWords.RowHeadersVisible = false;
            this.dGVWords.Size = new System.Drawing.Size(206, 150);
            this.dGVWords.TabIndex = 2;
            this.dGVWords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVWords_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // bEndGame
            // 
            this.bEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEndGame.Location = new System.Drawing.Point(217, 540);
            this.bEndGame.Name = "bEndGame";
            this.bEndGame.Size = new System.Drawing.Size(155, 44);
            this.bEndGame.TabIndex = 1;
            this.bEndGame.Text = "Завершить игру";
            this.bEndGame.UseVisualStyleBackColor = true;
            this.bEndGame.Click += new System.EventHandler(this.bEndGame_Click);
            // 
            // dGVPlayingField
            // 
            this.dGVPlayingField.AllowUserToAddRows = false;
            this.dGVPlayingField.AllowUserToDeleteRows = false;
            this.dGVPlayingField.AllowUserToResizeColumns = false;
            this.dGVPlayingField.AllowUserToResizeRows = false;
            this.dGVPlayingField.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayingField.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dGVPlayingField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlayingField.ColumnHeadersVisible = false;
            this.dGVPlayingField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPlayingField.DefaultCellStyle = dataGridViewCellStyle17;
            this.dGVPlayingField.Location = new System.Drawing.Point(0, 1);
            this.dGVPlayingField.Name = "dGVPlayingField";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlayingField.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dGVPlayingField.RowHeadersVisible = false;
            this.dGVPlayingField.Size = new System.Drawing.Size(234, 150);
            this.dGVPlayingField.TabIndex = 0;
            this.dGVPlayingField.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(358, 281);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 33);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcMenuAndOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "IrMemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMenuAndOptions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlayingField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bStartGame;
        private System.Windows.Forms.TabControl tcMenuAndOptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbСards;
        private System.Windows.Forms.ComboBox cbComplexity;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Button bOptionsAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVPlayingField;
        private System.Windows.Forms.Button bEndGame;
        private System.Windows.Forms.ComboBox cbСardsType;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dGVWords;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
    }
}

