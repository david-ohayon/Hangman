namespace HangMan_s_Game
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
            this.groupBoxKeyBoard = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxWordToGuess = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.letter5 = new System.Windows.Forms.Label();
            this.letter4 = new System.Windows.Forms.Label();
            this.letter3 = new System.Windows.Forms.Label();
            this.letter2 = new System.Windows.Forms.Label();
            this.letter1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxKeyBoard.SuspendLayout();
            this.groupBoxWordToGuess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKeyBoard
            // 
            this.groupBoxKeyBoard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBoxKeyBoard.Controls.Add(this.button12);
            this.groupBoxKeyBoard.Controls.Add(this.BackSpace);
            this.groupBoxKeyBoard.Controls.Add(this.button25);
            this.groupBoxKeyBoard.Controls.Add(this.Enter);
            this.groupBoxKeyBoard.Controls.Add(this.button26);
            this.groupBoxKeyBoard.Controls.Add(this.button24);
            this.groupBoxKeyBoard.Controls.Add(this.button23);
            this.groupBoxKeyBoard.Controls.Add(this.button22);
            this.groupBoxKeyBoard.Controls.Add(this.button21);
            this.groupBoxKeyBoard.Controls.Add(this.button20);
            this.groupBoxKeyBoard.Controls.Add(this.button19);
            this.groupBoxKeyBoard.Controls.Add(this.button18);
            this.groupBoxKeyBoard.Controls.Add(this.button17);
            this.groupBoxKeyBoard.Controls.Add(this.button2);
            this.groupBoxKeyBoard.Controls.Add(this.button15);
            this.groupBoxKeyBoard.Controls.Add(this.button14);
            this.groupBoxKeyBoard.Controls.Add(this.button13);
            this.groupBoxKeyBoard.Controls.Add(this.button11);
            this.groupBoxKeyBoard.Controls.Add(this.button10);
            this.groupBoxKeyBoard.Controls.Add(this.button9);
            this.groupBoxKeyBoard.Controls.Add(this.button8);
            this.groupBoxKeyBoard.Controls.Add(this.button7);
            this.groupBoxKeyBoard.Controls.Add(this.button6);
            this.groupBoxKeyBoard.Controls.Add(this.button5);
            this.groupBoxKeyBoard.Controls.Add(this.button4);
            this.groupBoxKeyBoard.Controls.Add(this.button3);
            this.groupBoxKeyBoard.Controls.Add(this.button16);
            this.groupBoxKeyBoard.Controls.Add(this.button1);
            this.groupBoxKeyBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxKeyBoard.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxKeyBoard.Location = new System.Drawing.Point(0, 360);
            this.groupBoxKeyBoard.Name = "groupBoxKeyBoard";
            this.groupBoxKeyBoard.Size = new System.Drawing.Size(833, 100);
            this.groupBoxKeyBoard.TabIndex = 0;
            this.groupBoxKeyBoard.TabStop = false;
            this.groupBoxKeyBoard.Text = "KeyBoard";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(255, 42);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 24);
            this.button12.TabIndex = 11;
            this.button12.Text = "L";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.InsertLetter);
            // 
            // BackSpace
            // 
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackSpace.Location = new System.Drawing.Point(660, 14);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(75, 24);
            this.BackSpace.TabIndex = 27;
            this.BackSpace.Text = "Delete";
            this.BackSpace.UseVisualStyleBackColor = true;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Location = new System.Drawing.Point(579, 69);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 24);
            this.button25.TabIndex = 24;
            this.button25.Text = "Y";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.InsertLetter);
            // 
            // Enter
            // 
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter.Location = new System.Drawing.Point(741, 13);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(86, 81);
            this.Enter.TabIndex = 26;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Location = new System.Drawing.Point(660, 69);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 24);
            this.button26.TabIndex = 25;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Location = new System.Drawing.Point(498, 70);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 23;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Location = new System.Drawing.Point(417, 70);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 22;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Location = new System.Drawing.Point(336, 70);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 21;
            this.button22.Text = "V";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Location = new System.Drawing.Point(255, 69);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 24);
            this.button21.TabIndex = 20;
            this.button21.Text = "U";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Location = new System.Drawing.Point(174, 70);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 19;
            this.button20.Text = "T";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Location = new System.Drawing.Point(93, 70);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 18;
            this.button19.Text = "S";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Location = new System.Drawing.Point(12, 70);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = "R";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(660, 41);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "Q";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(93, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(498, 42);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = "O";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(417, 42);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "N";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Location = new System.Drawing.Point(336, 42);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 24);
            this.button13.TabIndex = 12;
            this.button13.Text = "M";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(174, 42);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(93, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "J";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(12, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(579, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "H";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(498, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "G";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(417, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 24);
            this.button6.TabIndex = 5;
            this.button6.Text = "F";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(336, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(255, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(174, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(579, 41);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "P";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.InsertLetter);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InsertLetter);
            // 
            // groupBoxWordToGuess
            // 
            this.groupBoxWordToGuess.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxWordToGuess.Controls.Add(this.pictureBox);
            this.groupBoxWordToGuess.Controls.Add(this.label10);
            this.groupBoxWordToGuess.Controls.Add(this.label9);
            this.groupBoxWordToGuess.Controls.Add(this.label8);
            this.groupBoxWordToGuess.Controls.Add(this.label7);
            this.groupBoxWordToGuess.Controls.Add(this.label6);
            this.groupBoxWordToGuess.Controls.Add(this.letter5);
            this.groupBoxWordToGuess.Controls.Add(this.letter4);
            this.groupBoxWordToGuess.Controls.Add(this.letter3);
            this.groupBoxWordToGuess.Controls.Add(this.letter2);
            this.groupBoxWordToGuess.Controls.Add(this.letter1);
            this.groupBoxWordToGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWordToGuess.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWordToGuess.Name = "groupBoxWordToGuess";
            this.groupBoxWordToGuess.Size = new System.Drawing.Size(833, 360);
            this.groupBoxWordToGuess.TabIndex = 28;
            this.groupBoxWordToGuess.TabStop = false;
            this.groupBoxWordToGuess.Text = "groupBox2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(399, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "______";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(218, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "______";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(309, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "______";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(126, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "______";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(36, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "______";
            // 
            // letter5
            // 
            this.letter5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letter5.Location = new System.Drawing.Point(390, 127);
            this.letter5.Name = "letter5";
            this.letter5.Size = new System.Drawing.Size(60, 55);
            this.letter5.TabIndex = 4;
            this.letter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter4
            // 
            this.letter4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letter4.Location = new System.Drawing.Point(300, 127);
            this.letter4.Name = "letter4";
            this.letter4.Size = new System.Drawing.Size(60, 55);
            this.letter4.TabIndex = 3;
            this.letter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter3
            // 
            this.letter3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letter3.Location = new System.Drawing.Point(208, 127);
            this.letter3.Name = "letter3";
            this.letter3.Size = new System.Drawing.Size(60, 55);
            this.letter3.TabIndex = 2;
            this.letter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter2
            // 
            this.letter2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letter2.Location = new System.Drawing.Point(117, 127);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(60, 55);
            this.letter2.TabIndex = 1;
            this.letter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter1
            // 
            this.letter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letter1.Location = new System.Drawing.Point(27, 127);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(60, 55);
            this.letter1.TabIndex = 0;
            this.letter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(491, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(330, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(833, 460);
            this.Controls.Add(this.groupBoxWordToGuess);
            this.Controls.Add(this.groupBoxKeyBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKeyBoard.ResumeLayout(false);
            this.groupBoxWordToGuess.ResumeLayout(false);
            this.groupBoxWordToGuess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKeyBoard;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.GroupBox groupBoxWordToGuess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label letter5;
        private System.Windows.Forms.Label letter4;
        private System.Windows.Forms.Label letter3;
        private System.Windows.Forms.Label letter2;
        private System.Windows.Forms.Label letter1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

