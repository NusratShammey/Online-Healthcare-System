
namespace OnlineHealthCare
{
    partial class ViewPatient
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
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(328, 33);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 0;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(625, 251);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataG
            // 
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Location = new System.Drawing.Point(21, 79);
            this.dataG.Name = "dataG";
            this.dataG.Size = new System.Drawing.Size(570, 233);
            this.dataG.TabIndex = 2;
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineHealthCare.Properties.Resources.medicine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataG);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Name = "ViewPatient";
            this.Text = "ViewPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataG;
    }
}