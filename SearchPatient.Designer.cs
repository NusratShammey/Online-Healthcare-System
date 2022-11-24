
namespace OnlineHealthCare
{
    partial class SearchPatient
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
            this.GetPatient = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPatient
            // 
            this.GetPatient.Location = new System.Drawing.Point(284, 29);
            this.GetPatient.Name = "GetPatient";
            this.GetPatient.Size = new System.Drawing.Size(194, 23);
            this.GetPatient.TabIndex = 0;
            this.GetPatient.Text = "Get Patients List";
            this.GetPatient.UseVisualStyleBackColor = true;
            this.GetPatient.Click += new System.EventHandler(this.GetPatient_Click);
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(34, 86);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(638, 228);
            this.dgView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search any patient information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineHealthCare.Properties.Resources.medicine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.GetPatient);
            this.Name = "SearchPatient";
            this.Text = "SearchPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetPatient;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}