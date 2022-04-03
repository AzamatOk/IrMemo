
namespace IrMemo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAcceptOp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAcceptOp
            // 
            this.bAcceptOp.Location = new System.Drawing.Point(174, 353);
            this.bAcceptOp.Name = "bAcceptOp";
            this.bAcceptOp.Size = new System.Drawing.Size(75, 23);
            this.bAcceptOp.TabIndex = 0;
            this.bAcceptOp.Text = "Принять";
            this.bAcceptOp.UseVisualStyleBackColor = true;
            this.bAcceptOp.Click += new System.EventHandler(this.bAcceptOp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.bAcceptOp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAcceptOp;
    }
}