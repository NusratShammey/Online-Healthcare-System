
namespace OnlineHealthCare
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.Doctorlogin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doctorlogin
            // 
            this.Doctorlogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Doctorlogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Doctorlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorlogin.Location = new System.Drawing.Point(437, 136);
            this.Doctorlogin.Name = "Doctorlogin";
            this.Doctorlogin.Size = new System.Drawing.Size(140, 60);
            this.Doctorlogin.TabIndex = 1;
            this.Doctorlogin.Text = "Doctor";
            this.Doctorlogin.UseVisualStyleBackColor = false;
            this.Doctorlogin.Click += new System.EventHandler(this.Doctorlogin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(609, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Patient";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineHealthCare.Properties.Resources.medicine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Doctorlogin);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Doctorlogin;
        private System.Windows.Forms.Button button3;
    }
}