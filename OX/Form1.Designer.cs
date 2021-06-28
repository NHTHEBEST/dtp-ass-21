
namespace OX
{
    partial class Form1
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
            this.oxgame1 = new OX.OXGAME();
            this.SuspendLayout();
            // 
            // oxgame1
            // 
            this.oxgame1.BackColor = System.Drawing.Color.Black;
            this.oxgame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oxgame1.Location = new System.Drawing.Point(0, 0);
            this.oxgame1.Name = "oxgame1";
            this.oxgame1.Size = new System.Drawing.Size(479, 470);
            this.oxgame1.TabIndex = 0;
            this.oxgame1.Turn = OX.Players.Player1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 470);
            this.Controls.Add(this.oxgame1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OXGAME oxgame1;
    }
}

