
namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.x_kwadr = new System.Windows.Forms.Button();
            this.skobka2 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 40);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // x_kwadr
            // 
            this.x_kwadr.Location = new System.Drawing.Point(12, 87);
            this.x_kwadr.Name = "x_kwadr";
            this.x_kwadr.Size = new System.Drawing.Size(75, 41);
            this.x_kwadr.TabIndex = 2;
            this.x_kwadr.Text = "x²";
            this.x_kwadr.UseVisualStyleBackColor = true;
            this.x_kwadr.Click += new System.EventHandler(this.skobka1_Click);
            // 
            // skobka2
            // 
            this.skobka2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.skobka2.Location = new System.Drawing.Point(93, 87);
            this.skobka2.Name = "skobka2";
            this.skobka2.Size = new System.Drawing.Size(75, 41);
            this.skobka2.TabIndex = 3;
            this.skobka2.Text = "1/x";
            this.skobka2.UseVisualStyleBackColor = true;
            this.skobka2.Click += new System.EventHandler(this.skobka2_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(174, 87);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 41);
            this.sqrt.TabIndex = 4;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.procent_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(255, 87);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 41);
            this.clear.TabIndex = 5;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(12, 134);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 41);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number0_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(174, 132);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 41);
            this.number9.TabIndex = 7;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number0_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(93, 132);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 41);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number0_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(255, 132);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 41);
            this.divide.TabIndex = 9;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.minus_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(93, 181);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 41);
            this.number5.TabIndex = 10;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number0_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(12, 181);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 41);
            this.number4.TabIndex = 11;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number0_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(174, 181);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 41);
            this.number6.TabIndex = 12;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number0_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(255, 181);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 41);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.minus_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 228);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 41);
            this.number1.TabIndex = 14;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number0_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(174, 228);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 41);
            this.number3.TabIndex = 15;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number0_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(93, 228);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 41);
            this.number2.TabIndex = 16;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number0_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(255, 228);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 41);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(12, 275);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 41);
            this.number0.TabIndex = 18;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(93, 275);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 41);
            this.dot.TabIndex = 19;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.button18_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.PaleTurquoise;
            this.equals.Location = new System.Drawing.Point(174, 275);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 41);
            this.equals.TabIndex = 20;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.button19_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(255, 275);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 41);
            this.plus.TabIndex = 21;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 339);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.skobka2);
            this.Controls.Add(this.x_kwadr);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button x_kwadr;
        private System.Windows.Forms.Button skobka2;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button plus;
    }
}

