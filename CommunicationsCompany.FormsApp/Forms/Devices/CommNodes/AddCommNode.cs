using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp.Forms.CommNodes
{
    public partial class AddCommNode : Form
    {
        private readonly ICommNodeRepository commNodeRepository;
        private readonly IMainHubRepository mainHubRepository;

        public AddCommNode(ICommNodeRepository commNodeRepository, IMainHubRepository mainHubRepository)
        {
            this.commNodeRepository = commNodeRepository;
            this.mainHubRepository = mainHubRepository;
            InitializeComponent();
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            MainHub mainHub;
            if (long.TryParse(mainHubId.Text, out var result))
            {
                mainHub = await mainHubRepository.Find(result);
                if(mainHub == null)
                {
                    MessageBox.Show("Enter an Id of an existing main hub.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Main Hub Id");
                return;
            }

            CommNode commNode = new CommNode
            {
                Address = new Address
                {
                    ApartmentNumber = int.Parse(appartmentNumber.Text),
                    City = City.Text,
                    Street = street.Text
                },
                Description = description.Text,
                Device = new Device
                {
                    InstallationDate = DateTime.Today.AddDays(-1),
                    LastServiceDate = null,
                    SerialNumber = serialNumber.Text,
                    LastServiceReason = "",
                    ManufacturerName = "Manufacturer"
                },
                MainHub = mainHub,
            };

            await commNodeRepository.Add(commNode);
            MessageBox.Show("Comm Node successfully saved.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
