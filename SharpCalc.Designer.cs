namespace SharpCalculating
{
    partial class SharpCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpCalc));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_solve = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu_hamburger = new System.Windows.Forms.ToolStripMenuItem();
            this.Hamburger_About = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_root = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_hamburger,
            this.menu_view});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(393, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "test";
            // 
            // menu_view
            // 
            this.menu_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(55, 24);
            this.menu_view.Text = "View";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.basicToolStripMenuItem.Text = "Standard";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.view_standard_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.view_scientific_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 465);
            this.panel1.TabIndex = 2;
            // 
            // button_seven
            // 
            this.button_seven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_seven.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_seven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_seven.Location = new System.Drawing.Point(17, 149);
            this.button_seven.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(85, 80);
            this.button_seven.TabIndex = 3;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = true;
            this.button_seven.Click += new System.EventHandler(this.number_Click);
            // 
            // button_nine
            // 
            this.button_nine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_nine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_nine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_nine.Location = new System.Drawing.Point(189, 149);
            this.button_nine.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(85, 80);
            this.button_nine.TabIndex = 4;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = true;
            this.button_nine.Click += new System.EventHandler(this.number_Click);
            // 
            // button_eight
            // 
            this.button_eight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_eight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_eight.Location = new System.Drawing.Point(103, 149);
            this.button_eight.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(85, 80);
            this.button_eight.TabIndex = 5;
            this.button_eight.Text = "8";
            this.button_eight.UseVisualStyleBackColor = true;
            this.button_eight.Click += new System.EventHandler(this.number_Click);
            // 
            // button_five
            // 
            this.button_five.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_five.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_five.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_five.Location = new System.Drawing.Point(103, 235);
            this.button_five.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(85, 80);
            this.button_five.TabIndex = 6;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = true;
            this.button_five.Click += new System.EventHandler(this.number_Click);
            // 
            // button_four
            // 
            this.button_four.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_four.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_four.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_four.Location = new System.Drawing.Point(17, 235);
            this.button_four.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(85, 80);
            this.button_four.TabIndex = 7;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = true;
            this.button_four.Click += new System.EventHandler(this.number_Click);
            // 
            // button_six
            // 
            this.button_six.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_six.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_six.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_six.Location = new System.Drawing.Point(189, 235);
            this.button_six.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(85, 80);
            this.button_six.TabIndex = 8;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = true;
            this.button_six.Click += new System.EventHandler(this.number_Click);
            // 
            // button_one
            // 
            this.button_one.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_one.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_one.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_one.Location = new System.Drawing.Point(17, 321);
            this.button_one.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(85, 80);
            this.button_one.TabIndex = 9;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = true;
            this.button_one.Click += new System.EventHandler(this.number_Click);
            // 
            // button_two
            // 
            this.button_two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_two.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_two.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_two.Location = new System.Drawing.Point(103, 321);
            this.button_two.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(85, 80);
            this.button_two.TabIndex = 10;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Click += new System.EventHandler(this.number_Click);
            // 
            // button_three
            // 
            this.button_three.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_three.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_three.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_three.Location = new System.Drawing.Point(189, 321);
            this.button_three.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(85, 80);
            this.button_three.TabIndex = 11;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = true;
            this.button_three.Click += new System.EventHandler(this.number_Click);
            // 
            // button_zero
            // 
            this.button_zero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_zero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_zero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_zero.Location = new System.Drawing.Point(17, 407);
            this.button_zero.MinimumSize = new System.Drawing.Size(166, 80);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(171, 80);
            this.button_zero.TabIndex = 12;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = true;
            this.button_zero.Click += new System.EventHandler(this.number_Click);
            // 
            // button_solve
            // 
            this.button_solve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_solve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_solve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_solve.Location = new System.Drawing.Point(189, 407);
            this.button_solve.MinimumSize = new System.Drawing.Size(80, 80);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(85, 80);
            this.button_solve.TabIndex = 13;
            this.button_solve.Text = "=";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // button_plus
            // 
            this.button_plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_plus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_plus.Location = new System.Drawing.Point(285, 149);
            this.button_plus.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(85, 80);
            this.button_plus.TabIndex = 14;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_basic_arithmetic_Click);
            // 
            // button_minus
            // 
            this.button_minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_minus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_minus.Location = new System.Drawing.Point(285, 235);
            this.button_minus.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(85, 80);
            this.button_minus.TabIndex = 15;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_basic_arithmetic_Click);
            // 
            // button_division
            // 
            this.button_division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_division.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_division.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_division.Location = new System.Drawing.Point(285, 321);
            this.button_division.MinimumSize = new System.Drawing.Size(85, 80);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(85, 80);
            this.button_division.TabIndex = 16;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_basic_arithmetic_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_multiplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_multiplication.Location = new System.Drawing.Point(285, 407);
            this.button_multiplication.MinimumSize = new System.Drawing.Size(80, 80);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(85, 80);
            this.button_multiplication.TabIndex = 18;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_basic_arithmetic_Click);
            // 
            // textBox_display
            // 
            this.textBox_display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_display.Location = new System.Drawing.Point(17, 41);
            this.textBox_display.MaxLength = 20;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.ReadOnly = true;
            this.textBox_display.Size = new System.Drawing.Size(364, 38);
            this.textBox_display.TabIndex = 19;
            this.textBox_display.Text = "0";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_clear.Location = new System.Drawing.Point(17, 100);
            this.button_clear.MinimumSize = new System.Drawing.Size(85, 43);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 43);
            this.button_clear.TabIndex = 20;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_remove
            // 
            this.button_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_remove.Location = new System.Drawing.Point(103, 100);
            this.button_remove.MinimumSize = new System.Drawing.Size(85, 43);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(85, 43);
            this.button_remove.TabIndex = 21;
            this.button_remove.Text = "remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // menu_hamburger
            // 
            this.menu_hamburger.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_hamburger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hamburger_About,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menu_hamburger.Image = global::SharpCalculating.Properties.Resources.icons8_hamburger_menu_96;
            this.menu_hamburger.Name = "menu_hamburger";
            this.menu_hamburger.Size = new System.Drawing.Size(34, 24);
            this.menu_hamburger.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_hamburger.ToolTipText = "Usefull tools";
            this.menu_hamburger.Click += new System.EventHandler(this.MenuItem_view_Click);
            // 
            // Hamburger_About
            // 
            this.Hamburger_About.Name = "Hamburger_About";
            this.Hamburger_About.Size = new System.Drawing.Size(133, 26);
            this.Hamburger_About.Text = "About";
            this.Hamburger_About.Click += new System.EventHandler(this.Hamburger_About_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.Hamburger_Help_Clicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Hambuger_exit_Click);
            // 
            // button_root
            // 
            this.button_root.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_root.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_root.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_root.Location = new System.Drawing.Point(189, 100);
            this.button_root.MinimumSize = new System.Drawing.Size(85, 43);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(85, 43);
            this.button_root.TabIndex = 71;
            this.button_root.Text = "√";
            this.button_root.UseVisualStyleBackColor = true;
            // 
            // SharpCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 493);
            this.Controls.Add(this.button_root);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.button_eight);
            this.Controls.Add(this.button_nine);
            this.Controls.Add(this.button_seven);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(411, 540);
            this.Name = "SharpCalc";
            this.Text = "SharpCalculation";
            this.Load += new System.EventHandler(this.SharpCalc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_hamburger;
        private System.Windows.Forms.ToolStripMenuItem Hamburger_About;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_seven;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.ToolStripMenuItem menu_view;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_root;
    }
}

