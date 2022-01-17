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
    public partial class UpdateRegionalHub : Form
    {
        private readonly IRegionalHubRepository regionalHubRepository;

        public UpdateRegionalHub(IRegionalHubRepository regionalHubRepository)
        {
            this.regionalHubRepository = regionalHubRepository;
            InitializeComponent();
        }

        private async void UpdateRegionalHub_Load(object sender, EventArgs e)
        {
            if (long.TryParse(id.Text, out var result))
            {
                var regionalHub = await regionalHubRepository.Find(result);
                serialNumber.Text = regionalHub.Device.SerialNumber;
                regionName.Text = regionalHub.RegionName;
            }
            else
            {
                MessageBox.Show("Invalid Regional Hub Id.");
                this.Close();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var regionalHub = await regionalHubRepository.Find(long.Parse(id.Text));
            regionalHub.Device.SerialNumber = serialNumber.Text;
            regionalHub.RegionName = regionName.Text;
            await regionalHubRepository.Update(regionalHub);
            MessageBox.Show("Regional Hub successfully updated.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
