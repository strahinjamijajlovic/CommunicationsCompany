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
    public partial class IndexCommNodes : Form
    {
        private readonly ICommNodeRepository commNodeRepository;
        private readonly AddCommNode addCommNodeForm;
        private readonly UpdateCommNode updateCommNodeForm;
        public IndexCommNodes(ICommNodeRepository commNodeRepository, AddCommNode addCommNodeForm, UpdateCommNode updateCommNodeForm)
        {
            this.commNodeRepository = commNodeRepository;
            this.addCommNodeForm = addCommNodeForm;
            this.updateCommNodeForm = updateCommNodeForm;
            InitializeComponent();
        }

        private async void IndexCommNodes_Load(object sender, EventArgs e)
        {
        }

        private async void showCommNode_Click(object sender, EventArgs e)
        {
            var commNode = await commNodeRepository.Find(long.Parse(showId.Text));
            if (commNode != null)
                MessageBox.Show(commNode.Description); //show the data however you want
            else
                MessageBox.Show("Comm Node not found.");
        }

        private async void deleteCommNode_Click(object sender, EventArgs e)
        {
            if (long.TryParse(deleteId.Text, out var id))
            {
                await commNodeRepository.Remove(id);
                MessageBox.Show($"Comm Node with the id: {id} succesfully deleted.");
            }
            else
                MessageBox.Show("Enter a valid Id");
        }

        private void updateCommNode_Click(object sender, EventArgs e)
        {
            updateCommNodeForm.id.Text = updateId.Text;
            updateCommNodeForm.ShowDialog();            
        }

        private void addCommNode_Click(object sender, EventArgs e)
        {
            addCommNodeForm.ShowDialog();
        }
    }
}
