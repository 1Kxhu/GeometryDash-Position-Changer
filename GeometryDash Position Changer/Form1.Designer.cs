using CuoreUI.Controls;

namespace GeometryDash_Position_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.listBox1 = new CuoreUI.Controls.cuiListbox();
            this.cuiLabel2 = new wfcl1.cuiLabel();
            this.cuiLabel1 = new wfcl1.cuiLabel();
            this.button2 = new CuoreUI.Controls.cuiButton();
            this.button1 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel3 = new wfcl1.cuiLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 519);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 519);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(15, 545);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "↗";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(270, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "↗";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Youtube";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel2.Location = new System.Drawing.Point(12, 27);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github Repo";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cuiButton4
            // 
            this.cuiButton4.Content = "Load Selected Position";
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton4.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton4.Location = new System.Drawing.Point(15, 413);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.Rounding = 6;
            this.cuiButton4.Size = new System.Drawing.Size(492, 42);
            this.cuiButton4.TabIndex = 21;
            this.cuiButton4.Click += new System.EventHandler(this.button6_Click);
            // 
            // cuiButton3
            // 
            this.cuiButton3.Content = "Remove Selected";
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton3.Location = new System.Drawing.Point(15, 306);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.Rounding = 6;
            this.cuiButton3.Size = new System.Drawing.Size(492, 42);
            this.cuiButton3.TabIndex = 20;
            this.cuiButton3.Click += new System.EventHandler(this.button7_Click);
            // 
            // cuiButton2
            // 
            this.cuiButton2.Content = "Clear List";
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton2.Location = new System.Drawing.Point(15, 258);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.Rounding = 6;
            this.cuiButton2.Size = new System.Drawing.Size(492, 42);
            this.cuiButton2.TabIndex = 19;
            this.cuiButton2.Click += new System.EventHandler(this.button8_Click);
            // 
            // cuiButton1
            // 
            this.cuiButton1.Content = "Save Current Position";
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton1.Location = new System.Drawing.Point(15, 365);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.Rounding = 6;
            this.cuiButton1.Size = new System.Drawing.Size(492, 42);
            this.cuiButton1.TabIndex = 18;
            this.cuiButton1.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.listBox1.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 34;
            this.listBox1.ItemRounding = 8;
            this.listBox1.Items.AddRange(new object[] {
            "34"});
            this.listBox1.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.listBox1.Location = new System.Drawing.Point(15, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Rounding = 8;
            this.listBox1.SelectedForegroundColor = System.Drawing.Color.LightGray;
            this.listBox1.Size = new System.Drawing.Size(492, 204);
            this.listBox1.TabIndex = 17;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Your\\ text\\ here!";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel2.HorizontalAlignment = wfcl1.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel2.Location = new System.Drawing.Point(305, 545);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(202, 27);
            this.cuiLabel2.TabIndex = 8;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Your\\ text\\ here!";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel1.HorizontalAlignment = wfcl1.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel1.Location = new System.Drawing.Point(50, 545);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(202, 27);
            this.cuiLabel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Content = "Set Y Position";
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button2.Location = new System.Drawing.Point(270, 471);
            this.button2.Name = "button2";
            this.button2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.Rounding = 6;
            this.button2.Size = new System.Drawing.Size(237, 42);
            this.button2.TabIndex = 1;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Content = "Set X Position";
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button1.Location = new System.Drawing.Point(15, 471);
            this.button1.Name = "button1";
            this.button1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.Rounding = 6;
            this.button1.Size = new System.Drawing.Size(237, 42);
            this.button1.TabIndex = 0;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Loading";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel3.HorizontalAlignment = wfcl1.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel3.Location = new System.Drawing.Point(82, 7);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(422, 35);
            this.cuiLabel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 588);
            this.Controls.Add(this.cuiButton4);
            this.Controls.Add(this.cuiButton3);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuiLabel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Geometry Dash Position Changer | itzkxhu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cuiButton button1;
        private cuiButton button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private wfcl1.cuiLabel cuiLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private wfcl1.cuiLabel cuiLabel2;
        private wfcl1.cuiLabel cuiLabel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private cuiListbox listBox1;
        private cuiButton cuiButton1;
        private cuiButton cuiButton2;
        private cuiButton cuiButton3;
        private cuiButton cuiButton4;
    }
}

