using System.Threading.Tasks;

namespace CommunicationsCompany.FormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ManageCommNodes = new System.Windows.Forms.Button();
            this.ManageMainHubs = new System.Windows.Forms.Button();
            this.ManageRegionalHubs = new System.Windows.Forms.Button();
            this.ManageNaturalPersons = new System.Windows.Forms.Button();
            this.ManageLegalEntities = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ManageRegionalHubs);
            this.groupBox1.Controls.Add(this.ManageMainHubs);
            this.groupBox1.Controls.Add(this.ManageCommNodes);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Devices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ManageLegalEntities);
            this.groupBox2.Controls.Add(this.ManageNaturalPersons);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Users";
            // 
            // ManageCommNodes
            // 
            this.ManageCommNodes.Location = new System.Drawing.Point(7, 23);
            this.ManageCommNodes.Name = "ManageCommNodes";
            this.ManageCommNodes.Size = new System.Drawing.Size(187, 50);
            this.ManageCommNodes.TabIndex = 0;
            this.ManageCommNodes.Text = "Manage Comm Nodes";
            this.ManageCommNodes.UseVisualStyleBackColor = true;
            this.ManageCommNodes.Click += new System.EventHandler(this.ManageCommNodes_Click);
            // 
            // ManageMainHubs
            // 
            this.ManageMainHubs.Location = new System.Drawing.Point(6, 79);
            this.ManageMainHubs.Name = "ManageMainHubs";
            this.ManageMainHubs.Size = new System.Drawing.Size(187, 50);
            this.ManageMainHubs.TabIndex = 1;
            this.ManageMainHubs.Text = "Manage Main Hubs";
            this.ManageMainHubs.UseVisualStyleBackColor = true;
            this.ManageMainHubs.Click += new System.EventHandler(this.ManageMainHubs_Click);
            // 
            // ManageRegionalHubs
            // 
            this.ManageRegionalHubs.Location = new System.Drawing.Point(6, 135);
            this.ManageRegionalHubs.Name = "ManageRegionalHubs";
            this.ManageRegionalHubs.Size = new System.Drawing.Size(187, 50);
            this.ManageRegionalHubs.TabIndex = 2;
            this.ManageRegionalHubs.Text = "Manage Regional Hubs";
            this.ManageRegionalHubs.UseVisualStyleBackColor = true;
            this.ManageRegionalHubs.Click += new System.EventHandler(this.ManageRegionalHubs_Click);
            // 
            // ManageNaturalPersons
            // 
            this.ManageNaturalPersons.Location = new System.Drawing.Point(7, 23);
            this.ManageNaturalPersons.Name = "ManageNaturalPersons";
            this.ManageNaturalPersons.Size = new System.Drawing.Size(187, 78);
            this.ManageNaturalPersons.TabIndex = 0;
            this.ManageNaturalPersons.Text = "Manage Natural Persons";
            this.ManageNaturalPersons.UseVisualStyleBackColor = true;
            this.ManageNaturalPersons.Click += new System.EventHandler(this.ManageNaturalPersons_Click);
            // 
            // ManageLegalEntities
            // 
            this.ManageLegalEntities.Location = new System.Drawing.Point(6, 107);
            this.ManageLegalEntities.Name = "ManageLegalEntities";
            this.ManageLegalEntities.Size = new System.Drawing.Size(187, 78);
            this.ManageLegalEntities.TabIndex = 1;
            this.ManageLegalEntities.Text = "Manage Legal Entities";
            this.ManageLegalEntities.UseVisualStyleBackColor = true;
            this.ManageLegalEntities.Click += new System.EventHandler(this.ManageLegalEntities_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 221);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Communications Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ManageRegionalHubs;
        private System.Windows.Forms.Button ManageMainHubs;
        private System.Windows.Forms.Button ManageCommNodes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ManageLegalEntities;
        private System.Windows.Forms.Button ManageNaturalPersons;
    }
}

