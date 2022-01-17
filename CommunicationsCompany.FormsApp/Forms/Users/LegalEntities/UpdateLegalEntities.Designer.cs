namespace CommunicationsCompany.FormsApp.Forms.Users.LegalEntities
{
    partial class UpdateLegalEntity
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
            this.id = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.commNodeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pib = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(40, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 15);
            this.id.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(379, 102);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(298, 102);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // commNodeId
            // 
            this.commNodeId.Location = new System.Drawing.Point(405, 72);
            this.commNodeId.Name = "commNodeId";
            this.commNodeId.Size = new System.Drawing.Size(49, 23);
            this.commNodeId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comm Node Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(79, 72);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(74, 23);
            this.firstName.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(229, 72);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(75, 23);
            this.lastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(204, 38);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(100, 23);
            this.fax.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fax";
            // 
            // pib
            // 
            this.pib.Location = new System.Drawing.Point(53, 38);
            this.pib.Name = "pib";
            this.pib.Size = new System.Drawing.Size(100, 23);
            this.pib.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "PIB";
            // 
            // UpdateLegalEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 144);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commNodeId);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "UpdateLegalEntity";
            this.Text = "UpdateLegalEntities";
            this.Load += new System.EventHandler(this.UpdateLegalEntity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label id;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox commNodeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pib;
        private System.Windows.Forms.Label label6;
    }
}