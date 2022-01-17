using CommunicationsCompany.Domain.Entities;
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
    public partial class UpdateMainHub : Form
    {
        private readonly IMainHubRepository mainHubRepository;
        private readonly IRegionalHubRepository regionalHubRepository;

        public UpdateMainHub(IRegionalHubRepository regionalHubRepository, IMainHubRepository mainHubRepository)
        {
            this.regionalHubRepository = regionalHubRepository;
            this.mainHubRepository = mainHubRepository;
            InitializeComponent();
        }

        private async void UpdateMainHub_Load(object sender, EventArgs e)
        {
            if (long.TryParse(id.Text, out var result))
            {
                var mainHub = await mainHubRepository.Find(result);
                serialNumber.Text = mainHub.Device.SerialNumber;
                regionalHubId.Text = mainHub.RegionalHubId.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Main Hub Id.");
                this.Close();
            }

        }

        private async void save_Click(object sender, EventArgs e)
        {
            RegionalHub regionalHub;
            if (long.TryParse(regionalHubId.Text, out var result))
            {
                regionalHub = await regionalHubRepository.Find(result);
                if (regionalHub == null)
                {
                    MessageBox.Show("Enter an Id of an existing regional hub.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Regional Hub Id");
                return;
            }

            var mainHub = await mainHubRepository.Find(long.Parse(id.Text));
            mainHub.Device.SerialNumber = serialNumber.Text;
            mainHub.RegionalHub = regionalHub;
            await mainHubRepository.Update(mainHub);
            MessageBox.Show("Main Hub successfully updated.");
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
