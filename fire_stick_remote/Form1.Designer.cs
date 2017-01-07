namespace fire_stick_remote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.log_text = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 326);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remote";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.log_text);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 70);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 41);
            this.button11.TabIndex = 21;
            this.button11.TabStop = false;
            this.button11.Text = "Prev";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.previous_event);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(276, 70);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(85, 41);
            this.button10.TabIndex = 20;
            this.button10.TabStop = false;
            this.button10.Text = "Next";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.next_event);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 132);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 19;
            this.button9.TabStop = false;
            this.button9.Text = "Play";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.play_pause_event);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 227);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 41);
            this.button8.TabIndex = 18;
            this.button8.TabStop = false;
            this.button8.Text = "Menu";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.menu_event);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(227, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 39);
            this.button7.TabIndex = 17;
            this.button7.TabStop = false;
            this.button7.Text = "Home";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.home_event);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 39);
            this.button6.TabIndex = 16;
            this.button6.TabStop = false;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.back_event);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 39);
            this.button5.TabIndex = 15;
            this.button5.TabStop = false;
            this.button5.Text = "Enter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.enter_event);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(146, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 14;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.down_button_event);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(227, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 75);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.right_button_event);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(146, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 12;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.up_button_event);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(85, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 75);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.left_button_event);
            // 
            // log_text
            // 
            this.log_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_text.Location = new System.Drawing.Point(0, 3);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(373, 287);
            this.log_text.TabIndex = 1;
            this.log_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Firestick Remote";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboard_input_event);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox log_text;
    }
}

