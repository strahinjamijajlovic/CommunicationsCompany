namespace CommunicationsCompany.FormsApp.Forms.RegionalHubs
{
    partial class IndexRegionalHubs
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
            this.addRegionalHub = new System.Windows.Forms.Button();
            this.updateRegionalHub = new System.Windows.Forms.Button();
            this.deleteRegionalHub = new System.Windows.Forms.Button();
            this.showRegionalHub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateId = new System.Windows.Forms.TextBox();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.showId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addRegionalHub
            // 
            this.addRegionalHub.Location = new System.Drawing.Point(13, 13);
            this.addRegionalHub.Name = "addRegionalHub";
            this.addRegionalHub.Size = new System.Drawing.Size(266, 23);
            this.addRegionalHub.TabIndex = 0;
            this.addRegionalHub.Text = "Add Regional Hub";
            this.addRegionalHub.UseVisualStyleBackColor = true;
            this.addRegionalHub.Click += new System.EventHandler(this.addRegionalHub_Click);
            // 
            // updateRegionalHub
            // 
            this.updateRegionalHub.Location = new System.Drawing.Point(13, 43);
            this.updateRegionalHub.Name = "updateRegionalHub";
            this.updateRegionalHub.Size = new System.Drawing.Size(196, 23);
            this.updateRegionalHub.TabIndex = 1;
            this.updateRegionalHub.Text = "Update";
            this.updateRegionalHub.UseVisualStyleBackColor = true;
            this.updateRegionalHub.Click += new System.EventHandler(this.updateRegionalHub_Click);
            // 
            // deleteRegionalHub
            // 
            this.deleteRegionalHub.Location = new System.Drawing.Point(13, 73);
            this.deleteRegionalHub.Name = "deleteRegionalHub";
            this.deleteRegionalHub.Size = new System.Drawing.Size(196, 23);
            this.deleteRegionalHub.TabIndex = 2;
            this.deleteRegionalHub.Text = "Delete";
            this.deleteRegionalHub.UseVisualStyleBackColor = true;
            this.deleteRegionalHub.Click += new System.EventHandler(this.deleteRegionalHub_Click);
            // 
            // showRegionalHub
            // 
            this.showRegionalHub.Location = new System.Drawing.Point(13, 103);
            this.showRegionalHub.Name = "showRegionalHub";
            this.showRegionalHub.Size = new System.Drawing.Size(196, 23);
            this.showRegionalHub.TabIndex = 3;
            this.showRegionalHub.Text = "Show";
            this.showRegionalHub.UseVisualStyleBackColor = true;
            this.showRegionalHub.Click += new System.EventHandler(this.showRegionalHub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id:";
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(241, 39);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(38, 23);
            this.updateId.TabIndex = 7;
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(241, 68);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(38, 23);
            this.deleteId.TabIndex = 8;
            // 
            // showId
            // 
            this.showId.Location = new System.Drawing.Point(241, 95);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(38, 23);
            this.showId.TabIndex = 9;
            // 
            // IndexRegionalHubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 141);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showRegionalHub);
            this.Controls.Add(this.deleteRegionalHub);
            this.Controls.Add(this.updateRegionalHub);
            this.Controls.Add(this.addRegionalHub);
            this.Name = "IndexRegionalHubs";
            this.Text = "IndexRegionalHubs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRegionalHub;
        private System.Windows.Forms.Button updateRegionalHub;
        private System.Windows.Forms.Button deleteRegionalHub;
        private System.Windows.Forms.Button showRegionalHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.TextBox showId;
        private System.Windows.Forms.TextBox updateId;
    }
}