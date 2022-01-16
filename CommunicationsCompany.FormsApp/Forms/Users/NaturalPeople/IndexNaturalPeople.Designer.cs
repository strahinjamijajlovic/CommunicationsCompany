namespace CommunicationsCompany.FormsApp.Forms.Users.NaturalPeople
{
    partial class IndexNaturalPeople
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
            this.addNaturalPerson = new System.Windows.Forms.Button();
            this.updateNaturalPerson = new System.Windows.Forms.Button();
            this.deleteNaturalPerson = new System.Windows.Forms.Button();
            this.showNaturalPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateId = new System.Windows.Forms.TextBox();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.showId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNaturalPerson
            // 
            this.addNaturalPerson.Location = new System.Drawing.Point(13, 13);
            this.addNaturalPerson.Name = "addNaturalPerson";
            this.addNaturalPerson.Size = new System.Drawing.Size(249, 23);
            this.addNaturalPerson.TabIndex = 0;
            this.addNaturalPerson.Text = "Add Natural Person";
            this.addNaturalPerson.UseVisualStyleBackColor = true;
            this.addNaturalPerson.Click += new System.EventHandler(this.addNaturalPerson_Click);
            // 
            // updateNaturalPerson
            // 
            this.updateNaturalPerson.Location = new System.Drawing.Point(13, 43);
            this.updateNaturalPerson.Name = "updateNaturalPerson";
            this.updateNaturalPerson.Size = new System.Drawing.Size(165, 23);
            this.updateNaturalPerson.TabIndex = 1;
            this.updateNaturalPerson.Text = "Update";
            this.updateNaturalPerson.UseVisualStyleBackColor = true;
            this.updateNaturalPerson.Click += new System.EventHandler(this.updateNaturalPerson_Click);
            // 
            // deleteNaturalPerson
            // 
            this.deleteNaturalPerson.Location = new System.Drawing.Point(13, 73);
            this.deleteNaturalPerson.Name = "deleteNaturalPerson";
            this.deleteNaturalPerson.Size = new System.Drawing.Size(165, 23);
            this.deleteNaturalPerson.TabIndex = 2;
            this.deleteNaturalPerson.Text = "Delete";
            this.deleteNaturalPerson.UseVisualStyleBackColor = true;
            this.deleteNaturalPerson.Click += new System.EventHandler(this.deleteNaturalPerson_Click);
            // 
            // showNaturalPerson
            // 
            this.showNaturalPerson.Location = new System.Drawing.Point(13, 103);
            this.showNaturalPerson.Name = "showNaturalPerson";
            this.showNaturalPerson.Size = new System.Drawing.Size(165, 23);
            this.showNaturalPerson.TabIndex = 3;
            this.showNaturalPerson.Text = "Show";
            this.showNaturalPerson.UseVisualStyleBackColor = true;
            this.showNaturalPerson.Click += new System.EventHandler(this.showNaturalPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id";
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(209, 42);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(53, 23);
            this.updateId.TabIndex = 7;
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(208, 73);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(54, 23);
            this.deleteId.TabIndex = 8;
            // 
            // showId
            // 
            this.showId.Location = new System.Drawing.Point(208, 103);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(54, 23);
            this.showId.TabIndex = 9;
            // 
            // IndexNaturalPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showNaturalPerson);
            this.Controls.Add(this.deleteNaturalPerson);
            this.Controls.Add(this.updateNaturalPerson);
            this.Controls.Add(this.addNaturalPerson);
            this.Name = "IndexNaturalPeople";
            this.Text = "IndexNaturalPeople";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNaturalPerson;
        private System.Windows.Forms.Button updateNaturalPerson;
        private System.Windows.Forms.Button deleteNaturalPerson;
        private System.Windows.Forms.Button showNaturalPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.TextBox showId;
    }
}