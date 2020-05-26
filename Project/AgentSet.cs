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
    public partial class AgentSet : Form
    {
        public AgentSet()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void AgentSet_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            AgentsSet agenttSet = new AgentsSet();
            agenttSet.FirstName = textBoxFirstName.Text;
            agenttSet.MiddleName = textBoxMiddleName.Text;
            agenttSet.LastName = textBoxLastName.Text;

            Program.wftDb.AgentsSet.Add(agenttSet);
            Program.wftDb.SaveChanges();
            ShowAgent();

        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentsSet agenttSet in Program.wftDb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
agenttSet.Id.ToString(), agenttSet.FirstName, agenttSet.MiddleName, agenttSet.LastName
                });
                item.Tag = agenttSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                textBoxFirstName.Text = agentsSet.FirstName;
                textBoxMiddleName.Text = agentsSet.MiddleName;
                textBoxLastName.Text = agentsSet.LastName;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                agentsSet.FirstName = textBoxFirstName.Text;
                agentsSet.MiddleName = textBoxMiddleName.Text;
                agentsSet.LastName = textBoxLastName.Text;
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        if (listViewAgent.SelectedItems.Count == 1)
                        {
                            AgentsSet agentsSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                            Program.wftDb.AgentsSet.Remove(agentsSet);
                            Program.wftDb.SaveChanges();
                            ShowAgent();
                        }
                        textBoxFirstName.Text = "";
                        textBoxMiddleName.Text = "";
                        textBoxLastName.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

