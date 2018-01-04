namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.clearE = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 85);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(43, 145);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(53, 44);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.processClick);
            // 
            // clearE
            // 
            this.clearE.Location = new System.Drawing.Point(102, 145);
            this.clearE.Name = "clearE";
            this.clearE.Size = new System.Drawing.Size(53, 44);
            this.clearE.TabIndex = 2;
            this.clearE.Text = "CE";
            this.clearE.UseVisualStyleBackColor = true;
            this.clearE.Click += new System.EventHandler(this.processClick);
            // 
            // percentage
            // 
            this.percentage.Location = new System.Drawing.Point(161, 145);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(53, 44);
            this.percentage.TabIndex = 3;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = true;
            this.percentage.Click += new System.EventHandler(this.processClick);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(43, 195);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(53, 44);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.numberClick);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(102, 195);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(53, 44);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.numberClick);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(161, 195);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(53, 44);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.numberClick);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(43, 245);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(53, 44);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.numberClick);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(102, 245);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(53, 44);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.numberClick);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(161, 245);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(53, 44);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.numberClick);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(43, 295);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(53, 44);
            this.one.TabIndex = 10;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.numberClick);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(102, 295);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 44);
            this.two.TabIndex = 11;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.numberClick);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(161, 295);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(53, 44);
            this.three.TabIndex = 12;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.numberClick);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(43, 345);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(112, 44);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numberClick);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(161, 345);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(53, 44);
            this.point.TabIndex = 14;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.numberClick);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(220, 145);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(53, 44);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.processClick);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(220, 195);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(53, 44);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.processClick);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(220, 245);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(53, 44);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.processClick);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(220, 295);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(53, 44);
            this.subtract.TabIndex = 18;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.processClick);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(220, 345);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(53, 44);
            this.equals.TabIndex = 19;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.processClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 449);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.clearE);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearE;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button equals;
    }
}

