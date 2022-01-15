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
        public IndexCommNodes(ICommNodeRepository commNodeRepository)
        {
            this.commNodeRepository = commNodeRepository;
            InitializeComponent();
        }

        private async void IndexCommNodes_Load(object sender, EventArgs e)
        {
        }
    }
}
