namespace CommunicationsCompany.FormsApp.Forms.CommNodes
{
    partial class IndexCommNodes
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
            this.addCommNode = new System.Windows.Forms.Button();
            this.updateCommNode = new System.Windows.Forms.Button();
            this.deleteCommNode = new System.Windows.Forms.Button();
            this.updateId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteId = new System.Windows.Forms.TextBox();
            this.showCommNode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addCommNode
            // 
            this.addCommNode.Location = new System.Drawing.Point(13, 13);
            this.addCommNode.Name = "addCommNode";
            this.addCommNode.Size = new System.Drawing.Size(347, 23);
            this.addCommNode.TabIndex = 0;
            this.addCommNode.Text = "Add Comm Node";
            this.addCommNode.UseVisualStyleBackColor = true;
            this.addCommNode.Click += new System.EventHandler(this.addCommNode_Click);
            // 
            // updateCommNode
            // 
            this.updateCommNode.Location = new System.Drawing.Point(13, 43);
            this.updateCommNode.Name = "updateCommNode";
            this.updateCommNode.Size = new System.Drawing.Size(263, 23);
            this.updateCommNode.TabIndex = 1;
            this.updateCommNode.Text = "Update";
            this.updateCommNode.UseVisualStyleBackColor = true;
            this.updateCommNode.Click += new System.EventHandler(this.updateCommNode_Click);
            // 
            // deleteCommNode
            // 
            this.deleteCommNode.Location = new System.Drawing.Point(13, 73);
            this.deleteCommNode.Name = "deleteCommNode";
            this.deleteCommNode.Size = new System.Drawing.Size(263, 23);
            this.deleteCommNode.TabIndex = 2;
            this.deleteCommNode.Text = "Delete";
            this.deleteCommNode.UseVisualStyleBackColor = true;
            this.deleteCommNode.Click += new System.EventHandler(this.deleteCommNode_Click);
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(308, 42);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(52, 23);
            this.updateId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(309, 73);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(51, 23);
            this.deleteId.TabIndex = 6;
            // 
            // showCommNode
            // 
            this.showCommNode.Location = new System.Drawing.Point(13, 103);
            this.showCommNode.Name = "showCommNode";
            this.showCommNode.Size = new System.Drawing.Size(263, 23);
            this.showCommNode.TabIndex = 7;
            this.showCommNode.Text = "Show";
            this.showCommNode.UseVisualStyleBackColor = true;
            this.showCommNode.Click += new System.EventHandler(this.showCommNode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id:";
            // 
            // showId
            // 
            this.showId.Location = new System.Drawing.Point(309, 107);
            this.showId.Name = "showId";
            this.showId.Size = new System.Drawing.Size(51, 23);
            this.showId.TabIndex = 9;
            // 
            // IndexCommNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 143);
            this.Controls.Add(this.showId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showCommNode);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.deleteCommNode);
            this.Controls.Add(this.updateCommNode);
            this.Controls.Add(this.addCommNode);
            this.Name = "IndexCommNodes";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.IndexCommNodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCommNode;
        private System.Windows.Forms.Button updateCommNode;
        private System.Windows.Forms.Button deleteCommNode;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.Button showCommNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox showId;
    }
}