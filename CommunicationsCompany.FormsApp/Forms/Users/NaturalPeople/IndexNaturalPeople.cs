using CommunicationsCompany.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunicationsCompany.FormsApp.Forms.Users.NaturalPeople
{
    public partial class IndexNaturalPeople : Form
    {
        private readonly INaturalPersonRepository naturalPersonRepository;
        private readonly AddNaturalPerson addNaturalPersonForm;
        private readonly UpdateNaturalPerson updateNaturalPersonForm;

        public IndexNaturalPeople(INaturalPersonRepository naturalPersonRepository, AddNaturalPerson addNaturalPersonForm, UpdateNaturalPerson updateNaturalPersonForm)
        {
            this.naturalPersonRepository = naturalPersonRepository;
            this.addNaturalPersonForm = addNaturalPersonForm;
            this.updateNaturalPersonForm = updateNaturalPersonForm;
            InitializeComponent();
        }

        private void addNaturalPerson_Click(object sender, EventArgs e)
        {
            addNaturalPersonForm.ShowDialog();
        }

        private void updateNaturalPerson_Click(object sender, EventArgs e)
        {
            updateNaturalPersonForm.id.Text = updateId.Text;
            updateNaturalPersonForm.ShowDialog();
        }

        private async void deleteNaturalPerson_Click(object sender, EventArgs e)
        {
            if (long.TryParse(deleteId.Text, out var id))
            {
                await naturalPersonRepository.Remove(id);
                MessageBox.Show($"Person with the id: {id.ToString()} succesfully deleted.", );
            }
            else
                MessageBox.Show("Enter a valid Id");

        }

        private async void showNaturalPerson_Click(object sender, EventArgs e)
        {
            var naturalPerson = await naturalPersonRepository.Find(long.Parse(showId.Text));
            if (naturalPerson != null)
                MessageBox.Show($"User: {naturalPerson.User.FirstName} {naturalPerson.User.LastName}"); //show the data however you want
            else
                MessageBox.Show("Comm Node not found.");

        }
    }
}
