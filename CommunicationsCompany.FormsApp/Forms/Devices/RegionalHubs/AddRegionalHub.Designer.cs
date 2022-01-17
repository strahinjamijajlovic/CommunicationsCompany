namespace CommunicationsCompany.FormsApp.Forms.RegionalHubs
{
    partial class AddRegionalHub
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
            this.regionName = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Serial Number";
            // 
            // regionName
            // 
            this.regionName.Location = new System.Drawing.Point(139, 10);
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(100, 23);
            this.regionName.TabIndex = 2;
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(139, 39);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(100, 23);
            this.serialNumber.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(164, 68);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(83, 68);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddRegionalHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 101);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRegionalHub";
            this.Text = "AddRegionalHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regionName;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}