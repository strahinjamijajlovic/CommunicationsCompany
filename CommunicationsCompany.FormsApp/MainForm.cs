using CommunicationsCompany.Domain.Repositories;
using CommunicationsCompany.FormsApp.Forms.CommNodes;
using CommunicationsCompany.FormsApp.Forms.MainHubs;
using CommunicationsCompany.FormsApp.Forms.RegionalHubs;
using CommunicationsCompany.FormsApp.Forms.Users.LegalEntities;
using CommunicationsCompany.FormsApp.Forms.Users.NaturalPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp
{
    public partial class MainForm : Form
    {
        private readonly IndexCommNodes indexCommNodes;
        private readonly IndexMainHubs indexMainHubs;
        private readonly IndexRegionalHubs indexRegionalHubs;
        private readonly IndexNaturalPeople indexNaturalPeople;
        private readonly IndexLegalEntities indexLegalEntities;
        public MainForm(IndexCommNodes indexCommNodes, 
            IndexMainHubs indexMainHubs, 
            IndexRegionalHubs indexRegionalHubs, 
            IndexNaturalPeople indexNaturalPeople, 
            IndexLegalEntities indexLegalEntities)
        {
            this.indexCommNodes = indexCommNodes;
            this.indexMainHubs = indexMainHubs;
            this.indexRegionalHubs = indexRegionalHubs;
            this.indexNaturalPeople = indexNaturalPeople;
            this.indexLegalEntities = indexLegalEntities;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ManageCommNodes_Click(object sender, EventArgs e)
        {
            indexCommNodes.ShowDialog();
        }

        private void ManageMainHubs_Click(object sender, EventArgs e)
        {
            indexMainHubs.ShowDialog();
        }

        private void ManageRegionalHubs_Click(object sender, EventArgs e)
        {
            indexRegionalHubs.ShowDialog();
        }

        private void ManageNaturalPersons_Click(object sender, EventArgs e)
        {
            indexNaturalPeople.ShowDialog();
        }

        private void ManageLegalEntities_Click(object sender, EventArgs e)
        {
            indexLegalEntities.ShowDialog();
        }
    }
}
