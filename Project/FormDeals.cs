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
    public partial class FormDeals : Form
    {
        public FormDeals()
        {
            InitializeComponent();
            ShowAgent();
            ShowClient();
            ShowRealEstate();
            ShowDealsSet();

        }

        private void FormDeals_Load(object sender, EventArgs e)
        {

        }
        void ShowAgent()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentSet in Program.wftDb.AgentsSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClient()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()

        {
            comboBoxTypeOfGoods.Items.Clear();
            foreach (TypeOfGoodsSet typeOfGoodsSet in Program.wftDb.TypeOfGoodsSet)
            {
                string[] item = { typeOfGoodsSet.Id.ToString() + ".", typeOfGoodsSet.Manufacturer + ",", typeOfGoodsSet.Model + ",", typeOfGoodsSet.Country + ",",   typeOfGoodsSet.PriceMax + ",", typeOfGoodsSet.PriceMin + ",", typeOfGoodsSet.Year + ",", typeOfGoodsSet.SIMСards + ",", typeOfGoodsSet.Color };
                comboBoxTypeOfGoods.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
                if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxTypeOfGoods.SelectedItem!= null)
                {
                    DealsSet deals = new DealsSet();
                deals.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                deals.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                deals.IdTypeOfGoods = Convert.ToInt32(comboBoxTypeOfGoods.SelectedItem.ToString().Split('.')[0]);
           
                    Program.wftDb.DealsSet.Add(deals);
                    Program.wftDb.SaveChanges();
                ShowDealsSet();


                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        void ShowDealsSet()
        {
            listViewDealSet.Items.Clear();
            foreach (DealsSet deals in Program.wftDb.DealsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
deals.IdAgent.ToString(),
deals.AgentsSet.LastName+" "+ deals.AgentsSet.FirstName+ " "+ deals.AgentsSet.MiddleName,

deals.IdClient.ToString(),
deals.ClientsSet.LastName+" "+ deals.ClientsSet.FirstName+ " "+ deals.ClientsSet.MiddleName,

deals.IdTypeOfGoods.ToString(),
deals.TypeOfGoodsSet.Manufacturer + ",", deals.TypeOfGoodsSet.Model + ",", deals.TypeOfGoodsSet.Country + ",",   deals.TypeOfGoodsSet.PriceMax + ",", deals.TypeOfGoodsSet.PriceMin + ",", deals.TypeOfGoodsSet.Year + ",", deals.TypeOfGoodsSet.SIMСards + ",", deals.TypeOfGoodsSet.Color


                });
                item.Tag = deals;
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
          
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                DealsSet deals = listViewDealSet.SelectedItems[0].Tag as DealsSet;
                deals.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                deals.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                deals.IdTypeOfGoods = Convert.ToInt32(comboBoxTypeOfGoods.SelectedItem.ToString().Split('.')[0]);
                 
                    Program.wftDb.SaveChanges();
                ShowDealsSet();
            }
            }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealsSet deals = listViewDealSet.SelectedItems[0].Tag as DealsSet;

                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(deals.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(deals.IdClient.ToString());
                comboBoxTypeOfGoods.SelectedIndex = comboBoxTypeOfGoods.FindString(deals.IdTypeOfGoods.ToString());
               
            }

            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxTypeOfGoods.SelectedItem = null;
              
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealsSet deals = listViewDealSet.SelectedItems[0].Tag as DealsSet;
                    Program.wftDb.DealsSet.Remove(deals);
                    Program.wftDb.SaveChanges();
                    ShowDealsSet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                comboBoxTypeOfGoods.SelectedItem = null;
              
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    
    

