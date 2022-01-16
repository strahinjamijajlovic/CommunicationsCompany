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
    public partial class IndexLegalEntities : Form
    {
        private readonly ILegalEntityRepository legalEntityRepository;
        private readonly AddLegalEntity addLegalEntityForm;
        private readonly UpdateLegalEntity updateLegalEntityForm;
        public IndexLegalEntities(ILegalEntityRepository legalEntityRepository, AddLegalEntity addLegalEntityForm, UpdateLegalEntity updateLegalEntityForm)
        {
            this.legalEntityRepository = legalEntityRepository;
            this.addLegalEntityForm = addLegalEntityForm;
            this.updateLegalEntityForm = updateLegalEntityForm;
            InitializeComponent();
        }

        private void addLegalEntity_Click(object sender, EventArgs e)
        {
            addLegalEntityForm.ShowDialog();
        }

        private void updateLegalEntity_Click(object sender, EventArgs e)
        {
            updateLegalEntityForm.id.Text = updateId.Text;
            updateLegalEntityForm.ShowDialog();
        }

        private async void deleteLegalEntity_Click(object sender, EventArgs e)
        {
            if (long.TryParse(deleteId.Text, out var id))
            {
                await legalEntityRepository.Remove(id);
                MessageBox.Show($"Legal Entity with the id: {id} succesfully deleted.");
            }
            else
                MessageBox.Show("Enter a valid Id");
        }

        private async void showLegalEntity_Click(object sender, EventArgs e)
        {
            var legalEntity = await legalEntityRepository.Find(long.Parse(showId.Text));
            if (legalEntity != null)
                MessageBox.Show(legalEntity.PIB); //show the data however you want
            else
                MessageBox.Show("Legal Entity not found.");
        }
    }
}
