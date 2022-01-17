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
    public partial class UpdateCommNode : Form
    {
        private readonly ICommNodeRepository commNodeRepository;
        private readonly IMainHubRepository mainHubRepository;

        public UpdateCommNode(ICommNodeRepository commNodeRepository, IMainHubRepository mainHubRepository)
        {
            this.commNodeRepository = commNodeRepository;
            this.mainHubRepository = mainHubRepository;
            InitializeComponent();
        }

        private async void UpdateCommNode_Load(object sender, EventArgs e)
        {
            if(long.TryParse(id.Text, out var result))
            {
                var commNode = await commNodeRepository.Find(result);
                description.Text = commNode.Description;
                street.Text = commNode.Address.Street;
                appartmentNumber.Text = commNode.Address.ApartmentNumber.ToString();
                City.Text = commNode.Address.City;
                serialNumber.Text = commNode.Device.SerialNumber;
                mainHubId.Text = commNode.MainHubId.ToString();
                //there should be other data on this page, like letting the user update the list of users, service data for the device etc.
                //I just see this as very tedious and not at all as the point of this project
            }
            else
            {
                MessageBox.Show("Invalid Comm Node Id.");
                this.Close();
            }
        }

        private async void save_Click(object sender, EventArgs e)
        {
            MainHub mainHub;
            if (long.TryParse(mainHubId.Text, out var result))
            {
                mainHub = await mainHubRepository.Find(result);
                if (mainHub == null)
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

            var commNode = await commNodeRepository.Find(long.Parse(id.Text));

            commNode.Address.ApartmentNumber = int.Parse(appartmentNumber.Text);
            commNode.Address.Street = street.Text;
            commNode.Address.City = City.Text;
            commNode.Description = description.Text;
            commNode.Device.SerialNumber = serialNumber.Text;

            await commNodeRepository.Update(commNode);
            MessageBox.Show("Comm Node successfully updated.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
