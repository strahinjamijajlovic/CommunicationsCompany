namespace CommunicationsCompany.FormsApp.Forms.MainHubs
{
    partial class IndexMainHubs
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
            this.addMainHub = new System.Windows.Forms.Button();
            this.updateMainHub = new System.Windows.Forms.Button();
            this.deleteMainHub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateId = new System.Windows.Forms.TextBox();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.showId = new System.Windows.Forms.TextBox();
            this.lsbel3 = new System.Windows.Forms.Label();
            this.showMainHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMainHub
            // 
            this.addMainHub.Location = new System.Drawing.Point(13, 13);
            this.addMainHub.Name = "addMainHub";
            this.addMainHub.Size = new System.Drawing.Size(227, 23);
            this.addMainHub.TabIndex = 0;
            this.addMainHub.Text = "Add Main Hub";
            this.addMainHub.UseVisualStyleBackColor = true;
            this.addMainHub.Click += new System.EventHandler(this.addMainHub_Click);
            // 
            // updateMainHub
            // 
            this.updateMainHub.Location = new System.Drawing.Point(13, 43);
            this.updateMainHub.Name = "updateMainHub";
            this.updateMainHub.Size = new System.Drawing.Size(161, 23);
            this.updateMainHub.TabIndex = 1;
            this.updateMainHub.Text = "Update";
            this.updateMainHub.UseVisualStyleBackColor = true;
            this.updateMainHub.Click += new System.EventHandler(this.updateMainHub_Click);
            // 
            // deleteMainHub
            // 
            this.deleteMainHub.Location = new System.Drawing.Point(13, 73);
            this.deleteMainHub.Name = "deleteMainHub";
            this.deleteMainHub.Size = new System.Drawing.Size(161, 23);
            this.deleteMainHub.TabIndex = 2;
            this.deleteMainHub.Text = "Delete";
            this.deleteMainHub.UseVisualStyleBackColor = true;
            this.deleteMainHub.Click += new System.EventHandler(this.deleteMainHub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // UpdateId
            // 
            this.UpdateId.Location = new System.Drawing.Point(203, 43);
            this.UpdateId.Name = "UpdateId";
            this.UpdateId.Size = new System.Drawing.Size(37, 23);
            this.UpdateId.TabIndex = 5;
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(203, 73);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(37, 23);
            this.deleteId.TabIndex = 6;
            // 
            // showId
            // 
            this.showId.Location = new System.Drawing.Point(203, 103);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(37, 23);
            this.showId.TabIndex = 7;
            // 
            // lsbel3
            // 
            this.lsbel3.AutoSize = true;
            this.lsbel3.Location = new System.Drawing.Point(180, 103);
            this.lsbel3.Name = "lsbel3";
            this.lsbel3.Size = new System.Drawing.Size(17, 15);
            this.lsbel3.TabIndex = 8;
            this.lsbel3.Text = "Id";
            // 
            // showMainHub
            // 
            this.showMainHub.Location = new System.Drawing.Point(13, 103);
            this.showMainHub.Name = "showMainHub";
            this.showMainHub.Size = new System.Drawing.Size(161, 23);
            this.showMainHub.TabIndex = 9;
            this.showMainHub.Text = "Show";
            this.showMainHub.UseVisualStyleBackColor = true;
            this.showMainHub.Click += new System.EventHandler(this.showMainHub_Click);
            // 
            // IndexMainHubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 147);
            this.Controls.Add(this.showMainHub);
            this.Controls.Add(this.lsbel3);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.UpdateId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteMainHub);
            this.Controls.Add(this.updateMainHub);
            this.Controls.Add(this.addMainHub);
            this.Name = "IndexMainHubs";
            this.Text = "IndexMainHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMainHub;
        private System.Windows.Forms.Button updateMainHub;
        private System.Windows.Forms.Button deleteMainHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UpdateId;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.TextBox showId;
        private System.Windows.Forms.Label lsbel3;
        private System.Windows.Forms.Button showMainHub;
    }
}