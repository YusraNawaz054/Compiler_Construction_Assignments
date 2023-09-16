namespace calc__special
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
            this.result = new System.Windows.Forms.TextBox();
            this.clear__btn = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(8, 15);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(220, 37);
            this.result.TabIndex = 0;
            // 
            // clear__btn
            // 
            this.clear__btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear__btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear__btn.Location = new System.Drawing.Point(8, 70);
            this.clear__btn.Name = "clear__btn";
            this.clear__btn.Size = new System.Drawing.Size(110, 32);
            this.clear__btn.TabIndex = 1;
            this.clear__btn.Text = "C";
            this.clear__btn.UseVisualStyleBackColor = false;
            this.clear__btn.Click += new System.EventHandler(this.clear_click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(174, 109);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(55, 32);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.plus_click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.ForeColor = System.Drawing.Color.White;
            this.nine.Location = new System.Drawing.Point(119, 109);
            this.nine.Margin = new System.Windows.Forms.Padding(0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(55, 32);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.btn9_click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.ForeColor = System.Drawing.Color.White;
            this.eight.Location = new System.Drawing.Point(64, 109);
            this.eight.Margin = new System.Windows.Forms.Padding(0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(55, 32);
            this.eight.TabIndex = 4;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.btn8_click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(76)))));
            this.seven.ForeColor = System.Drawing.Color.White;
            this.seven.Location = new System.Drawing.Point(9, 109);
            this.seven.Margin = new System.Windows.Forms.Padding(0);
            this.seven.Name = "seven";
            this.seven.Padding = new System.Windows.Forms.Padding(2);
            this.seven.Size = new System.Drawing.Size(55, 32);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.btn7_click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.ForeColor = System.Drawing.Color.White;
            this.four.Location = new System.Drawing.Point(9, 141);
            this.four.Margin = new System.Windows.Forms.Padding(0);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 32);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.btn4_click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.ForeColor = System.Drawing.Color.White;
            this.five.Location = new System.Drawing.Point(64, 141);
            this.five.Margin = new System.Windows.Forms.Padding(0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(55, 32);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.btn5_click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.ForeColor = System.Drawing.Color.White;
            this.six.Location = new System.Drawing.Point(119, 141);
            this.six.Margin = new System.Windows.Forms.Padding(0);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(55, 32);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.btn6_click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.subtract.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.subtract.FlatAppearance.BorderSize = 0;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.ForeColor = System.Drawing.Color.White;
            this.subtract.Location = new System.Drawing.Point(174, 141);
            this.subtract.Margin = new System.Windows.Forms.Padding(0);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(55, 32);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.minus_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(9, 205);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 32);
            this.button8.TabIndex = 13;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn10_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(119, 205);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 32);
            this.button10.TabIndex = 11;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.equal_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(174, 205);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 32);
            this.button11.TabIndex = 10;
            this.button11.Text = "/";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.divide_click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(9, 173);
            this.one.Margin = new System.Windows.Forms.Padding(0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 32);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.btn1_click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(64, 173);
            this.two.Margin = new System.Windows.Forms.Padding(0);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(55, 32);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.btn2_click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.ForeColor = System.Drawing.Color.White;
            this.three.Location = new System.Drawing.Point(119, 173);
            this.three.Margin = new System.Windows.Forms.Padding(0);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(55, 32);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.btn3_click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.mul.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.mul.FlatAppearance.BorderSize = 0;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.ForeColor = System.Drawing.Color.White;
            this.mul.Location = new System.Drawing.Point(174, 174);
            this.mul.Margin = new System.Windows.Forms.Padding(0);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(55, 32);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.dot.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.dot.FlatAppearance.BorderSize = 0;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.Color.White;
            this.dot.Location = new System.Drawing.Point(64, 205);
            this.dot.Margin = new System.Windows.Forms.Padding(0);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(55, 32);
            this.dot.TabIndex = 18;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cos.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.cos.FlatAppearance.BorderSize = 0;
            this.cos.ForeColor = System.Drawing.Color.White;
            this.cos.Location = new System.Drawing.Point(9, 237);
            this.cos.Margin = new System.Windows.Forms.Padding(0);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(55, 32);
            this.cos.TabIndex = 19;
            this.cos.Text = "Cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.tan.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.tan.FlatAppearance.BorderSize = 0;
            this.tan.ForeColor = System.Drawing.Color.White;
            this.tan.Location = new System.Drawing.Point(119, 237);
            this.tan.Margin = new System.Windows.Forms.Padding(0);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(55, 32);
            this.tan.TabIndex = 20;
            this.tan.Text = "Tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.sin.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.sin.FlatAppearance.BorderSize = 0;
            this.sin.ForeColor = System.Drawing.Color.White;
            this.sin.Location = new System.Drawing.Point(64, 237);
            this.sin.Margin = new System.Windows.Forms.Padding(0);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(55, 32);
            this.sin.TabIndex = 21;
            this.sin.Text = "Sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.log.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.log.FlatAppearance.BorderSize = 0;
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(173, 237);
            this.log.Margin = new System.Windows.Forms.Padding(0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(55, 32);
            this.log.TabIndex = 22;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(244, 293);
            this.Controls.Add(this.log);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear__btn);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button clear__btn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button log;
    }
}

