namespace CommunicationsCompany.FormsApp.Forms.CommNodes
{
    partial class AddCommNode
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.mainHubId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appartmentNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device Serial Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Main Hub Id";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(156, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(478, 23);
            this.description.TabIndex = 4;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(156, 63);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 23);
            this.street.TabIndex = 4;
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(156, 92);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(100, 23);
            this.serialNumber.TabIndex = 4;
            // 
            // mainHubId
            // 
            this.mainHubId.Location = new System.Drawing.Point(345, 98);
            this.mainHubId.Name = "mainHubId";
            this.mainHubId.Size = new System.Drawing.Size(69, 23);
            this.mainHubId.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ADDRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "App. nr:";
            // 
            // appartmentNumber
            // 
            this.appartmentNumber.Location = new System.Drawing.Point(345, 63);
            this.appartmentNumber.Name = "appartmentNumber";
            this.appartmentNumber.Size = new System.Drawing.Size(69, 23);
            this.appartmentNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "City:";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(475, 63);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(159, 23);
            this.City.TabIndex = 4;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(478, 119);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(559, 119);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddCommNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 154);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.appartmentNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mainHubId);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.street);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCommNode";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox mainHubId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appartmentNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancel;
    }
}