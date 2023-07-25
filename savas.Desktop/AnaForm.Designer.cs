
namespace savas.Desktop
{
    public partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ucakPanel = new System.Windows.Forms.Panel();
            this.savasPanel = new System.Windows.Forms.Panel();
            this.lev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bitmeklabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.savasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucakPanel
            // 
            this.ucakPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ucakPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucakPanel.Location = new System.Drawing.Point(0, 322);
            this.ucakPanel.Name = "ucakPanel";
            this.ucakPanel.Size = new System.Drawing.Size(686, 49);
            this.ucakPanel.TabIndex = 1;
            // 
            // savasPanel
            // 
            this.savasPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.savasPanel.Controls.Add(this.lev);
            this.savasPanel.Controls.Add(this.label2);
            this.savasPanel.Controls.Add(this.Scorelabel);
            this.savasPanel.Controls.Add(this.button2);
            this.savasPanel.Controls.Add(this.button1);
            this.savasPanel.Controls.Add(this.bitmeklabel);
            this.savasPanel.Controls.Add(this.bilgiLabel);
            this.savasPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.savasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasPanel.Location = new System.Drawing.Point(0, 0);
            this.savasPanel.Name = "savasPanel";
            this.savasPanel.Size = new System.Drawing.Size(686, 322);
            this.savasPanel.TabIndex = 2;
            // 
            // lev
            // 
            this.lev.AutoSize = true;
            this.lev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lev.Location = new System.Drawing.Point(68, 24);
            this.lev.Name = "lev";
            this.lev.Size = new System.Drawing.Size(18, 20);
            this.lev.TabIndex = 6;
            this.lev.Text = "1";
            this.lev.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Level";
            this.label2.Visible = false;
            // 
            // Scorelabel
            // 
            this.Scorelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Scorelabel.BackColor = System.Drawing.Color.DarkGray;
            this.Scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.Location = new System.Drawing.Point(624, 19);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(31, 23);
            this.Scorelabel.TabIndex = 4;
            this.Scorelabel.Text = "0";
            this.Scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Scorelabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(333, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(177, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "RESTART";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitmeklabel
            // 
            this.bitmeklabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bitmeklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitmeklabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.bitmeklabel.Location = new System.Drawing.Point(61, 31);
            this.bitmeklabel.Name = "bitmeklabel";
            this.bitmeklabel.Size = new System.Drawing.Size(534, 240);
            this.bitmeklabel.TabIndex = 1;
            this.bitmeklabel.Text = "Oyunu bittti yeniden oynamak için RESTART tuşuna basın.\r\nOyundan çıkmak için ÇIKI" +
    "Ş tuşuna basın.\r\n\r\n";
            this.bitmeklabel.Visible = false;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bilgiLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.bilgiLabel.Location = new System.Drawing.Point(63, 61);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(596, 251);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın..\r\nUçaksavarı hareket ettirmek için SAĞ/S" +
    "OL yön tuşlarına basın..\r\nAteş etmek için BOŞLUK tuşuna basın..\r\nOyunu Durdurmak" +
    " için ESC tuşuna basın..";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 371);
            this.Controls.Add(this.savasPanel);
            this.Controls.Add(this.ucakPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Uçak oyunu ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.savasPanel.ResumeLayout(false);
            this.savasPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ucakPanel;
        private System.Windows.Forms.Panel savasPanel;
        public System.Windows.Forms.Label bilgiLabel;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label bitmeklabel;
        public System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lev;
    }
}

