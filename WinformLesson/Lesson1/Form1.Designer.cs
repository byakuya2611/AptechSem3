
namespace Lesson1
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
            this.txtName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullname1 = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtName.Location = new System.Drawing.Point(186, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(65, 17);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Fullname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(225, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input and Show";
            // 
            // txtFullname1
            // 
            this.txtFullname1.Location = new System.Drawing.Point(272, 110);
            this.txtFullname1.Name = "txtFullname1";
            this.txtFullname1.Size = new System.Drawing.Size(100, 20);
            this.txtFullname1.TabIndex = 1;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(272, 162);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(100, 20);
            this.txtShow.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(189, 218);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "OK";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(305, 218);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Exit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(597, 359);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtFullname1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtShowFullname;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullname1;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnQuit;
    }
}

