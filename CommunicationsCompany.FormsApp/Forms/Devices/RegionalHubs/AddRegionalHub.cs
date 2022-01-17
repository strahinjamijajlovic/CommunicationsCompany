using CommunicationsCompany.Domain.Entities;
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
    public partial class AddRegionalHub : Form
    {
        private readonly IRegionalHubRepository regionalHubRepository;

        public AddRegionalHub(IRegionalHubRepository regionalHubRepository)
        {
            this.regionalHubRepository = regionalHubRepository;
            InitializeComponent();
        }

        private async void save_Click(object sender, EventArgs e)
        {

            RegionalHub regionalHub = new RegionalHub
            {
                Device = new Device
                {
                    InstallationDate = DateTime.Today.AddDays(-1),
                    LastServiceDate = null,
                    SerialNumber = serialNumber.Text,
                    LastServiceReason = "",
                    ManufacturerName = "Manufacturer"
                },
                RegionName = regionName.Text,
            };

            await regionalHubRepository.Add(regionalHub);
            MessageBox.Show("Regional Hub successfully saved.");
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
