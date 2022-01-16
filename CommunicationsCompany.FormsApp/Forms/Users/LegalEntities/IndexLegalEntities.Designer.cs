namespace CommunicationsCompany.FormsApp.Forms.Users.LegalEntities
{
    partial class IndexLegalEntities
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
            this.addLegalEntity = new System.Windows.Forms.Button();
            this.updateLegalEntity = new System.Windows.Forms.Button();
            this.deleteLegalEntity = new System.Windows.Forms.Button();
            this.showLegalEntity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateId = new System.Windows.Forms.TextBox();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.showId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addLegalEntity
            // 
            this.addLegalEntity.Location = new System.Drawing.Point(13, 13);
            this.addLegalEntity.Name = "addLegalEntity";
            this.addLegalEntity.Size = new System.Drawing.Size(232, 23);
            this.addLegalEntity.TabIndex = 0;
            this.addLegalEntity.Text = "Add Legal Entity";
            this.addLegalEntity.UseVisualStyleBackColor = true;
            this.addLegalEntity.Click += new System.EventHandler(this.addLegalEntity_Click);
            // 
            // updateLegalEntity
            // 
            this.updateLegalEntity.Location = new System.Drawing.Point(12, 42);
            this.updateLegalEntity.Name = "updateLegalEntity";
            this.updateLegalEntity.Size = new System.Drawing.Size(159, 23);
            this.updateLegalEntity.TabIndex = 1;
            this.updateLegalEntity.Text = "Update";
            this.updateLegalEntity.UseVisualStyleBackColor = true;
            this.updateLegalEntity.Click += new System.EventHandler(this.updateLegalEntity_Click);
            // 
            // deleteLegalEntity
            // 
            this.deleteLegalEntity.Location = new System.Drawing.Point(13, 72);
            this.deleteLegalEntity.Name = "deleteLegalEntity";
            this.deleteLegalEntity.Size = new System.Drawing.Size(158, 23);
            this.deleteLegalEntity.TabIndex = 2;
            this.deleteLegalEntity.Text = "Delete";
            this.deleteLegalEntity.UseVisualStyleBackColor = true;
            this.deleteLegalEntity.Click += new System.EventHandler(this.deleteLegalEntity_Click);
            // 
            // showLegalEntity
            // 
            this.showLegalEntity.Location = new System.Drawing.Point(12, 102);
            this.showLegalEntity.Name = "showLegalEntity";
            this.showLegalEntity.Size = new System.Drawing.Size(159, 23);
            this.showLegalEntity.TabIndex = 3;
            this.showLegalEntity.Text = "Show";
            this.showLegalEntity.UseVisualStyleBackColor = true;
            this.showLegalEntity.Click += new System.EventHandler(this.showLegalEntity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(201, 42);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(44, 23);
            this.updateId.TabIndex = 7;
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(201, 72);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(44, 23);
            this.deleteId.TabIndex = 8;
            // 
            // showId
            // 
            this.showId.Location = new System.Drawing.Point(201, 102);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(44, 23);
            this.showId.TabIndex = 9;
            // 
            // IndexLegalEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 142);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showLegalEntity);
            this.Controls.Add(this.deleteLegalEntity);
            this.Controls.Add(this.updateLegalEntity);
            this.Controls.Add(this.addLegalEntity);
            this.Name = "IndexLegalEntities";
            this.Text = "IndexLegalEntities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addLegalEntity;
        private System.Windows.Forms.Button updateLegalEntity;
        private System.Windows.Forms.Button deleteLegalEntity;
        private System.Windows.Forms.Button showLegalEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.TextBox showId;
    }
}