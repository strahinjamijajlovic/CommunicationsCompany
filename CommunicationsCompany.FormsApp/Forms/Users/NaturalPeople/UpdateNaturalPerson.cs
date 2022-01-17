using CommunicationsCompany.Domain.Entities;
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
    public partial class UpdateNaturalPerson : Form
    {
        private readonly INaturalPersonRepository naturalPersonRepository;
        private readonly ICommNodeRepository commNodeRepository;
        public UpdateNaturalPerson(INaturalPersonRepository naturalPersonRepository, ICommNodeRepository commNodeRepository)
        {
            this.naturalPersonRepository = naturalPersonRepository;
            this.commNodeRepository = commNodeRepository;
            InitializeComponent();
        }

        private async void UpdateNaturalPerson_Load(object sender, EventArgs e)
        {
            if (long.TryParse(id.Text, out var result))
            {
                var naturalPerson = await naturalPersonRepository.Find(result);
                firstName.Text = naturalPerson.User.FirstName;
                lastName.Text = naturalPerson.User.LastName;
                jmbg.Text = naturalPerson.JMBG;
                contactNumber.Text = naturalPerson.ContactNumber;
                commNodeId.Text = naturalPerson.User.CommNodeId.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Natural Person Id.");
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

            var naturalPerson = await naturalPersonRepository.Find(long.Parse(id.Text));

            naturalPerson.JMBG = jmbg.Text;
            naturalPerson.ContactNumber = contactNumber.Text;
            naturalPerson.User.FirstName = firstName.Text;
            naturalPerson.User.LastName = lastName.Text;
            naturalPerson.User.CommNode = commNode;

            await naturalPersonRepository.Update(naturalPerson);
            MessageBox.Show("User successfully updated.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
