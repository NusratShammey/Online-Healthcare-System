
namespace OnlineHealthCare
{
    partial class ViewDoctors
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(52, 86);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(695, 260);
            this.dgv2.TabIndex = 0;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(310, 31);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 1;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineHealthCare.Properties.Resources.medicine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.dgv2);
            this.Name = "ViewDoctors";
            this.Text = "ViewDoctors";
            this.Load += new System.EventHandler(this.ViewDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button button1;
    }
}