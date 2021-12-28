
namespace Lesson3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1stInteger = new System.Windows.Forms.TextBox();
            this.txt2ndInteger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtDifference = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtQuotient = new System.Windows.Forms.TextBox();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Integer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd Integer";
            // 
            // txt1stInteger
            // 
            this.txt1stInteger.Location = new System.Drawing.Point(300, 87);
            this.txt1stInteger.Name = "txt1stInteger";
            this.txt1stInteger.Size = new System.Drawing.Size(100, 20);
            this.txt1stInteger.TabIndex = 2;
            // 
            // txt2ndInteger
            // 
            this.txt2ndInteger.Location = new System.Drawing.Point(300, 120);
            this.txt2ndInteger.Name = "txt2ndInteger";
            this.txt2ndInteger.Size = new System.Drawing.Size(100, 20);
            this.txt2ndInteger.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(246, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "2 Integer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Difference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quotient";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(300, 165);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 2;
            // 
            // txtDifference
            // 
            this.txtDifference.Location = new System.Drawing.Point(300, 212);
            this.txtDifference.Name = "txtDifference";
            this.txtDifference.Size = new System.Drawing.Size(100, 20);
            this.txtDifference.TabIndex = 2;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(300, 259);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // txtQuotient
            // 
            this.txtQuotient.Location = new System.Drawing.Point(300, 312);
            this.txtQuotient.Name = "txtQuotient";
            this.txtQuotient.Size = new System.Drawing.Size(100, 20);
            this.txtQuotient.TabIndex = 2;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(251, 370);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(75, 23);
            this.btnCaculate.TabIndex = 3;
            this.btnCaculate.Text = "Caculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnCaculate);
            this.Controls.Add(this.txtQuotient);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtDifference);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txt2ndInteger);
            this.Controls.Add(this.txt1stInteger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1stInteger;
        private System.Windows.Forms.TextBox txt2ndInteger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtDifference;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtQuotient;
        private System.Windows.Forms.Button btnCaculate;
    }
}

