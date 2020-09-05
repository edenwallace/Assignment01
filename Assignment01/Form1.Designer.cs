namespace Assignment01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnormalText = new System.Windows.Forms.Label();
            this.lblcypherText = new System.Windows.Forms.Label();
            this.lblshift = new System.Windows.Forms.Label();
            this.normalText = new System.Windows.Forms.TextBox();
            this.cypherText = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblnormalText
            // 
            this.lblnormalText.AutoSize = true;
            this.lblnormalText.Location = new System.Drawing.Point(9, 35);
            this.lblnormalText.Name = "lblnormalText";
            this.lblnormalText.Size = new System.Drawing.Size(60, 13);
            this.lblnormalText.TabIndex = 1;
            this.lblnormalText.Text = "Normal text";
            this.lblnormalText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcypherText
            // 
            this.lblcypherText.AutoSize = true;
            this.lblcypherText.Location = new System.Drawing.Point(442, 35);
            this.lblcypherText.Name = "lblcypherText";
            this.lblcypherText.Size = new System.Drawing.Size(60, 13);
            this.lblcypherText.TabIndex = 2;
            this.lblcypherText.Text = "Cypher text";
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Location = new System.Drawing.Point(368, 118);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(28, 13);
            this.lblshift.TabIndex = 3;
            this.lblshift.Text = "Shift";
            this.lblshift.Click += new System.EventHandler(this.lblshift_Click);
            // 
            // normalText
            // 
            this.normalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalText.Location = new System.Drawing.Point(12, 51);
            this.normalText.Multiline = true;
            this.normalText.Name = "normalText";
            this.normalText.Size = new System.Drawing.Size(307, 251);
            this.normalText.TabIndex = 4;
            this.normalText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cypherText
            // 
            this.cypherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cypherText.Location = new System.Drawing.Point(445, 51);
            this.cypherText.Multiline = true;
            this.cypherText.Name = "cypherText";
            this.cypherText.Size = new System.Drawing.Size(307, 251);
            this.cypherText.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(355, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(345, 176);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(345, 220);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cypherText);
            this.Controls.Add(this.normalText);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.lblcypherText);
            this.Controls.Add(this.lblnormalText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblnormalText;
        private System.Windows.Forms.Label lblcypherText;
        private System.Windows.Forms.Label lblshift;
        private System.Windows.Forms.TextBox normalText;
        private System.Windows.Forms.TextBox cypherText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

