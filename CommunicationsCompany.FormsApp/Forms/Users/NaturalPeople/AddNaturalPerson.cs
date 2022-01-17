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
    public partial class AddNaturalPerson : Form
    {
        private readonly INaturalPersonRepository naturalPersonRepository;
        private readonly ICommNodeRepository commNodeRepository;
        public AddNaturalPerson(INaturalPersonRepository naturalPersonRepository, ICommNodeRepository commNodeRepository)
        {
            this.naturalPersonRepository = naturalPersonRepository;
            this.commNodeRepository = commNodeRepository;
            InitializeComponent();
        }

        private async void save_Click(object sender, EventArgs e)
        {
            CommNode commNode;
            if (long.TryParse(commNodeId.Text, out var result))
            {
                commNode = await commNodeRepository.Find(result);
                if (commNode == null)
                {
                    MessageBox.Show("Enter an Id of an existing comm node.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Comm Node Id");
                return;
            }


            var naturalPerson = new NaturalPerson
            {
                JMBG = jmbg.Text,
                ContactNumber = contactNumber.Text,
                User = new User
                {
                    CommNode = commNode,
                    FirstName = firstName.Text,
                    LastName = lastName.Text
                },
                Services = new Services
                {
                    InternetService = new InternetService
                    {
                        Prepaid = true,
                        AccountBalance = 0,
                        LastPaymentDate = DateTime.Today,
                        FlatRate = true,
                        StaticIPs = new HashSet<StaticIp>
                                        {
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.1"
                                            },
                                            new StaticIp
                                            {
                                                IpAddress = "192.168.1.2"
                                            },
                                        }
                    },
                    ExtraTvPrograms = new HashSet<ExtraProgram>
                                    {
                                        new ExtraProgram
                                        {
                                            Name = "Program 1"
                                        },
                                        new ExtraProgram
                                        {
                                            Name = "Program 2"
                                        }
                                    },
                    PhoneNumbers = new HashSet<PhoneNumber>
                                    {
                                        new PhoneNumber
                                        {
                                            Number = "+381641234567",
                                            MinutesCount = 0
                                        },
                                        new PhoneNumber
                                        {
                                            Number = "+381647654321",
                                            MinutesCount = 0
                                        },
                                    }
                }
            };

            await naturalPersonRepository.Add(naturalPerson);
            MessageBox.Show("User successfully saved.");
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
