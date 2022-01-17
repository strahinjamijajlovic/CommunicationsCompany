using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp.Forms.Users.LegalEntities
{
    public partial class UpdateLegalEntity : Form
    {
        private readonly ILegalEntityRepository legalEntityRepository;
        private readonly ICommNodeRepository commNodeRepository;
        public UpdateLegalEntity(ILegalEntityRepository legalEntityRepository, ICommNodeRepository commNodeRepository)
        {
            this.legalEntityRepository = legalEntityRepository;
            this.commNodeRepository = commNodeRepository;
            InitializeComponent();
        }

        private async void UpdateLegalEntity_Load(object sender, EventArgs e)
        {
            if (long.TryParse(id.Text, out var result))
            {
                var legalEntity = await legalEntityRepository.Find(result);
                firstName.Text = legalEntity.ContactPerson.FirstName;
                lastName.Text = legalEntity.ContactPerson.LastName;
                pib.Text = legalEntity.PIB;
                fax.Text = legalEntity.FaxNumber;
                commNodeId.Text = legalEntity.ContactPerson.CommNodeId.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Legal Entity Id.");
                this.Close();
            }

        }

        private async void save_Click(object sender, EventArgs e)
        {
            CommNode commNode;
            if (long.TryParse(commNodeId.Text, out var result))
            {
                commNode = await commNodeRepository.Find(result);
                if (commNode == null)
                {
                    MessageBox.Show("Enter an Id of an existing Comm Node.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Main Hub Id");
                return;
            }

            var legalEntity = await legalEntityRepository.Find(long.Parse(id.Text));

            legalEntity.PIB = pib.Text;
            legalEntity.FaxNumber = fax.Text;
            legalEntity.ContactPerson.FirstName = firstName.Text;
            legalEntity.ContactPerson.LastName = lastName.Text;
            legalEntity.ContactPerson.CommNode = commNode;

            await legalEntityRepository.Update(legalEntity);
            MessageBox.Show("Legal Entity successfully updated.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
