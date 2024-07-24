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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cuiButton6 = new CuoreUI.Controls.cuiButton();
            this.cuiButton5 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiSwitch1 = new CuoreUI.Controls.cuiSwitch();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.listBox1 = new CuoreUI.Controls.cuiListbox();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.button2 = new CuoreUI.Controls.cuiButton();
            this.button1 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiFormDrag1 = new CuoreUI.cuiFormDrag(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 524);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 524);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel1.Location = new System.Drawing.Point(11, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Youtube";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel2.Location = new System.Drawing.Point(89, 11);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(73, 16);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github Repo";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cuiButton6
            // 
            this.cuiButton6.CheckButton = false;
            this.cuiButton6.Checked = false;
            this.cuiButton6.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton6.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton6.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton6.Content = "↗";
            this.cuiButton6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton6.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton6.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton6.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton6.Image = null;
            this.cuiButton6.ImageAutoCenter = true;
            this.cuiButton6.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton6.ImageTint = System.Drawing.Color.White;
            this.cuiButton6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton6.Location = new System.Drawing.Point(267, 550);
            this.cuiButton6.Name = "cuiButton6";
            this.cuiButton6.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton6.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton6.OutlineThickness = 1.6F;
            this.cuiButton6.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton6.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton6.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton6.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton6.Size = new System.Drawing.Size(29, 28);
            this.cuiButton6.TabIndex = 25;
            this.cuiButton6.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton6.Click += new System.EventHandler(this.button4_Click);
            // 
            // cuiButton5
            // 
            this.cuiButton5.CheckButton = false;
            this.cuiButton5.Checked = false;
            this.cuiButton5.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton5.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton5.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton5.Content = "↗";
            this.cuiButton5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton5.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton5.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton5.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton5.Image = null;
            this.cuiButton5.ImageAutoCenter = true;
            this.cuiButton5.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.ImageTint = System.Drawing.Color.White;
            this.cuiButton5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton5.Location = new System.Drawing.Point(12, 550);
            this.cuiButton5.Name = "cuiButton5";
            this.cuiButton5.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton5.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton5.OutlineThickness = 1.6F;
            this.cuiButton5.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton5.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton5.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton5.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton5.Size = new System.Drawing.Size(29, 28);
            this.cuiButton5.TabIndex = 24;
            this.cuiButton5.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton5.Click += new System.EventHandler(this.button3_Click);
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Always\\ On-Top";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel4.Location = new System.Drawing.Point(68, 33);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(111, 18);
            this.cuiLabel4.TabIndex = 23;
            // 
            // cuiSwitch1
            // 
            this.cuiSwitch1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiSwitch1.Checked = false;
            this.cuiSwitch1.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cuiSwitch1.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.cuiSwitch1.Location = new System.Drawing.Point(10, 30);
            this.cuiSwitch1.Name = "cuiSwitch1";
            this.cuiSwitch1.OutlineColor = System.Drawing.Color.Empty;
            this.cuiSwitch1.OutlineStyle = true;
            this.cuiSwitch1.OutlineThickness = 1.6F;
            this.cuiSwitch1.ShowSymbols = true;
            this.cuiSwitch1.Size = new System.Drawing.Size(55, 24);
            this.cuiSwitch1.TabIndex = 22;
            this.cuiSwitch1.UncheckedForeground = System.Drawing.Color.DarkGray;
            this.cuiSwitch1.Click += new System.EventHandler(this.cuiSwitch1_Click);
            // 
            // cuiButton4
            // 
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton4.Content = "Load Selected Position";
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton4.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageTint = System.Drawing.Color.White;
            this.cuiButton4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton4.Location = new System.Drawing.Point(12, 418);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton4.OutlineThickness = 1.6F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton4.Size = new System.Drawing.Size(492, 42);
            this.cuiButton4.TabIndex = 21;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Click += new System.EventHandler(this.button6_Click);
            // 
            // cuiButton3
            // 
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton3.Content = "Remove Selected";
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageTint = System.Drawing.Color.White;
            this.cuiButton3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton3.Location = new System.Drawing.Point(12, 312);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton3.OutlineThickness = 1.6F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton3.Size = new System.Drawing.Size(492, 42);
            this.cuiButton3.TabIndex = 20;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Click += new System.EventHandler(this.button7_Click);
            // 
            // cuiButton2
            // 
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton2.Content = "Clear List";
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton2.Location = new System.Drawing.Point(12, 264);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton2.OutlineThickness = 1.6F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton2.Size = new System.Drawing.Size(492, 42);
            this.cuiButton2.TabIndex = 19;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.button8_Click);
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton1.Content = "Save Current Position";
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cuiButton1.Location = new System.Drawing.Point(12, 370);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton1.OutlineThickness = 1.6F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(6);
            this.cuiButton1.Size = new System.Drawing.Size(492, 42);
            this.cuiButton1.TabIndex = 18;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
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
            this.listBox1.ItemHoveredBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.listBox1.ItemHoveredForegroundColor = System.Drawing.Color.Gray;
            this.listBox1.ItemRounding = 8;
            this.listBox1.Items.AddRange(new object[] {
            "34"});
            this.listBox1.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.listBox1.Location = new System.Drawing.Point(12, 54);
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
            this.cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel2.Location = new System.Drawing.Point(300, 556);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(202, 21);
            this.cuiLabel2.TabIndex = 8;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Your\\ text\\ here!";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            this.cuiLabel1.Location = new System.Drawing.Point(45, 556);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(202, 21);
            this.cuiLabel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.CheckButton = false;
            this.button2.Checked = false;
            this.button2.CheckedBackground = System.Drawing.Color.Coral;
            this.button2.CheckedImageTint = System.Drawing.Color.White;
            this.button2.CheckedOutline = System.Drawing.Color.Coral;
            this.button2.Content = "Set Y Position";
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.HoveredImageTint = System.Drawing.Color.White;
            this.button2.HoverOutline = System.Drawing.Color.Empty;
            this.button2.Image = null;
            this.button2.ImageAutoCenter = true;
            this.button2.ImageExpand = new System.Drawing.Point(0, 0);
            this.button2.ImageOffset = new System.Drawing.Point(0, 0);
            this.button2.ImageTint = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button2.Location = new System.Drawing.Point(267, 476);
            this.button2.Name = "button2";
            this.button2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.NormalOutline = System.Drawing.Color.Empty;
            this.button2.OutlineThickness = 1.6F;
            this.button2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button2.PressedImageTint = System.Drawing.Color.White;
            this.button2.PressedOutline = System.Drawing.Color.Empty;
            this.button2.Rounding = new System.Windows.Forms.Padding(6);
            this.button2.Size = new System.Drawing.Size(237, 42);
            this.button2.TabIndex = 1;
            this.button2.TextOffset = new System.Drawing.Point(0, 0);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.CheckButton = false;
            this.button1.Checked = false;
            this.button1.CheckedBackground = System.Drawing.Color.Coral;
            this.button1.CheckedImageTint = System.Drawing.Color.White;
            this.button1.CheckedOutline = System.Drawing.Color.Coral;
            this.button1.Content = "Set X Position";
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.HoveredImageTint = System.Drawing.Color.White;
            this.button1.HoverOutline = System.Drawing.Color.Empty;
            this.button1.Image = null;
            this.button1.ImageAutoCenter = true;
            this.button1.ImageExpand = new System.Drawing.Point(0, 0);
            this.button1.ImageOffset = new System.Drawing.Point(0, 0);
            this.button1.ImageTint = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button1.Location = new System.Drawing.Point(12, 476);
            this.button1.Name = "button1";
            this.button1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.NormalOutline = System.Drawing.Color.Empty;
            this.button1.OutlineThickness = 1.6F;
            this.button1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button1.PressedImageTint = System.Drawing.Color.White;
            this.button1.PressedOutline = System.Drawing.Color.Empty;
            this.button1.Rounding = new System.Windows.Forms.Padding(6);
            this.button1.Size = new System.Drawing.Size(237, 42);
            this.button1.TabIndex = 0;
            this.button1.TextOffset = new System.Drawing.Point(0, 0);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Loading";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
            this.cuiLabel3.Location = new System.Drawing.Point(168, 12);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(336, 35);
            this.cuiLabel3.TabIndex = 9;
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 591);
            this.Controls.Add(this.cuiButton6);
            this.Controls.Add(this.cuiButton5);
            this.Controls.Add(this.cuiLabel4);
            this.Controls.Add(this.cuiSwitch1);
            this.Controls.Add(this.cuiButton4);
            this.Controls.Add(this.cuiButton3);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuiLabel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cuiButton button1;
        private cuiButton button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private cuiListbox listBox1;
        private cuiButton cuiButton1;
        private cuiButton cuiButton2;
        private cuiButton cuiButton3;
        private cuiButton cuiButton4;
        private cuiSwitch cuiSwitch1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private cuiButton cuiButton5;
        private cuiButton cuiButton6;
        private CuoreUI.cuiFormDrag cuiFormDrag1;
    }
}

