
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
            this.tile1 = new OX.Tile();
            this.SuspendLayout();
            // 
            // tile1
            // 
            this.tile1.Location = new System.Drawing.Point(123, 77);
            this.tile1.Name = "tile1";
            this.tile1.NextSet = OX.Players.Player1;
            this.tile1.NobodyDisabled = System.Drawing.Color.Gray;
            this.tile1.NobodyEnabled = System.Drawing.Color.White;
            this.tile1.Player1Disabled = System.Drawing.Color.DarkRed;
            this.tile1.Player1Enabled = System.Drawing.Color.Red;
            this.tile1.Player2Disabled = System.Drawing.Color.DarkBlue;
            this.tile1.Player2Enabled = System.Drawing.Color.Blue;
            this.tile1.Size = new System.Drawing.Size(150, 150);
            this.tile1.State = OX.Players.Nobody;
            this.tile1.TabIndex = 0;
            this.tile1.Click += new System.EventHandler(this.tile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 470);
            this.Controls.Add(this.tile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tile tile1;
    }
}

