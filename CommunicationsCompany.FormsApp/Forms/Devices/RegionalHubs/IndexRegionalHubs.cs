using CommunicationsCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp.Forms.RegionalHubs
{
    public partial class IndexRegionalHubs : Form
    {
        private readonly IRegionalHubRepository regionalHubRepository;
        private readonly AddRegionalHub addRegionalHubForm;
        private readonly UpdateRegionalHub updateRegionalHubForm;
        public IndexRegionalHubs(IRegionalHubRepository regionalHubRepository, AddRegionalHub addRegionalHubForm, UpdateRegionalHub updateRegionalHubForm)
        {
            this.regionalHubRepository = regionalHubRepository;
            this.addRegionalHubForm = addRegionalHubForm;
            this.updateRegionalHubForm = updateRegionalHubForm;
            InitializeComponent();
        }

        private void addRegionalHub_Click(object sender, EventArgs e)
        {
            addRegionalHubForm.ShowDialog();
        }

        private void updateRegionalHub_Click(object sender, EventArgs e)
        {
            updateRegionalHubForm.id.Text = updateId.Text;
            updateRegionalHubForm.ShowDialog();
        }

        private async void deleteRegionalHub_Click(object sender, EventArgs e)
        {
            if (long.TryParse(deleteId.Text, out var id))
            {
                await regionalHubRepository.Remove(id);
                MessageBox.Show($"Regional Hub with the id: {id} succesfully deleted.");
            }
            else
                MessageBox.Show("Enter a valid Id");

        }

        private async void showRegionalHub_Click(object sender, EventArgs e)
        {
            var regionalHub = await regionalHubRepository.Find(long.Parse(showId.Text));
            if (regionalHub != null)
                MessageBox.Show(regionalHub.RegionName); //show the data however you want
            else
                MessageBox.Show("Regional Hub not found.");
        }
    }
}
