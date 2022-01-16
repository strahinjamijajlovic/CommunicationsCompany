using CommunicationsCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp.Forms.MainHubs
{
    public partial class IndexMainHubs : Form
    {
        private readonly IMainHubRepository mainHubRepository;
        private readonly AddMainHub addMainHubForm;
        private readonly UpdateMainHub updateMainHubForm;
        public IndexMainHubs(IMainHubRepository mainHubRepository, AddMainHub addMainHubForm, UpdateMainHub updateMainHubForm)
        {
            this.mainHubRepository = mainHubRepository;
            this.addMainHubForm = addMainHubForm;
            this.updateMainHubForm = updateMainHubForm;
            InitializeComponent();
        }

        private async void showMainHub_Click(object sender, EventArgs e)
        {
            var mainHub = await mainHubRepository.Find(long.Parse(showId.Text));
            if (mainHub != null)
                MessageBox.Show(mainHub.Device.SerialNumber); //show the data however you want
            else
                MessageBox.Show("Main Hub not found.");

        }

        private async void deleteMainHub_Click(object sender, EventArgs e)
        {
            if (long.TryParse(deleteId.Text, out var id))
            {
                await mainHubRepository.Remove(id);
                MessageBox.Show($"Main Hub with the id: {id} succesfully deleted.");
            }
            else
                MessageBox.Show("Enter a valid Id");

        }

        private void updateMainHub_Click(object sender, EventArgs e)
        {
            updateMainHubForm.id.Text = UpdateId.Text;
            updateMainHubForm.ShowDialog();
        }

        private void addMainHub_Click(object sender, EventArgs e)
        {
            updateMainHubForm.ShowDialog();
        }
    }
}
