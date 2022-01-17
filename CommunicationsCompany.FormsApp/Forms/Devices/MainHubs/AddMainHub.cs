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
    public partial class AddMainHub : Form
    {
        private readonly IMainHubRepository mainHubRepository;
        private readonly IRegionalHubRepository regionalHubRepository;

        public AddMainHub(IRegionalHubRepository regionalHubRepository, IMainHubRepository mainHubRepository)
        {
            this.regionalHubRepository = regionalHubRepository;
            this.mainHubRepository = mainHubRepository;
            InitializeComponent();
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

            MainHub mainHub = new MainHub
            {
                Device = new Device
                {
                    InstallationDate = DateTime.Today.AddDays(-1),
                    LastServiceDate = null,
                    SerialNumber = serialNumber.Text,
                    LastServiceReason = "",
                    ManufacturerName = "Manufacturer"
                },
                RegionalHub = regionalHub,
            };

            await mainHubRepository.Add(mainHub);
            MessageBox.Show("Main Hub successfully saved.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
