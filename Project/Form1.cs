using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenProd.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenProd_Click(object sender, EventArgs e)
        {
            Form formAgent = new AgentSet();
            formAgent.Show();

        }

        private void buttonOpenGoods_Click(object sender, EventArgs e)
        {
            Form formGoods = new Goods();
            formGoods.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeals = new FormDeals();
            formDeals.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
