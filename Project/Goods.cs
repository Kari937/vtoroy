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
    public partial class Goods : Form
    {
        public Goods()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            TypeOfGoodsSet();
        }

        private void Goods_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listView0.Visible = true;
                textBoxSIMСards.Visible = true;
                labelSIMСards.Visible = true;
                labelManufacturer.Visible = true;
                textBoxManufacturer.Visible = true;
                labelYear.Visible = true;
                textBoxYear.Visible = true;

                listView1.Visible = false;
                listView2.Visible = false;

                textBoxManufacturer.Text = "";
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
                textBoxYear.Text = "";
                textBoxSIMСards.Text = "";
                textBoxColor.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listView1.Visible = true;
                labelYear.Visible = true;
                textBoxYear.Visible = true;
                labelManufacturer.Visible = true;
                textBoxManufacturer.Visible = true;



                listView0.Visible = false;
                listView2.Visible = false;
                textBoxSIMСards.Visible = false;
                labelSIMСards.Visible = false;

                textBoxManufacturer.Text = "";
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
                textBoxYear.Text = "";
               
                textBoxColor.Text = "";


            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listView2.Visible = true;

                listView1.Visible = false;

                listView0.Visible = false;
                labelManufacturer.Visible = false;
                textBoxManufacturer.Visible = false;
                labelYear.Visible = false;
                textBoxYear.Visible = false;
                labelSIMСards.Visible = false;
                textBoxSIMСards.Visible = false;

             
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
           
                textBoxColor.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TypeOfGoodsSet typeOfGoodsSet = new TypeOfGoodsSet();

            typeOfGoodsSet.Model = textBoxModel.Text;
            typeOfGoodsSet.Country = textBoxCountry.Text;
            typeOfGoodsSet.PriceMax = textBoxPriceMax.Text;
            typeOfGoodsSet.PriceMin = textBoxPriceMin.Text;


            typeOfGoodsSet.Color = textBoxColor.Text;
            if (comboBoxType.SelectedIndex == 0)
            {
                typeOfGoodsSet.Type = 0;
                typeOfGoodsSet.Manufacturer = textBoxManufacturer.Text;
                typeOfGoodsSet.Year = textBoxYear.Text;
                typeOfGoodsSet.SIMСards = textBoxSIMСards.Text;
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                typeOfGoodsSet.Type = 1;
                typeOfGoodsSet.Manufacturer = textBoxManufacturer.Text;
                typeOfGoodsSet.Year = textBoxYear.Text;
            }
            else
            {
                typeOfGoodsSet.Type = 2;
            }
            Program.wftDb.TypeOfGoodsSet.Add(typeOfGoodsSet);
            Program.wftDb.SaveChanges();
            TypeOfGoodsSet();


        }
        void TypeOfGoodsSet()
        {
            listView0.Items.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();

            foreach (TypeOfGoodsSet typeOfGoodsSet in Program.wftDb.TypeOfGoodsSet)
            {
                if (typeOfGoodsSet.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
typeOfGoodsSet.Manufacturer, typeOfGoodsSet.Model, typeOfGoodsSet.Country, typeOfGoodsSet.PriceMax, typeOfGoodsSet.PriceMin, typeOfGoodsSet.Year, typeOfGoodsSet.SIMСards, typeOfGoodsSet.Color
                    });

                    item.Tag = typeOfGoodsSet;

                    listView0.Items.Add(item);
                }

                else if (typeOfGoodsSet.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
typeOfGoodsSet.Manufacturer, typeOfGoodsSet.Model, typeOfGoodsSet.Country, typeOfGoodsSet.PriceMax, typeOfGoodsSet.PriceMin, typeOfGoodsSet.Year,typeOfGoodsSet.Color
                    });

                    item.Tag = typeOfGoodsSet;

                    listView1.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
typeOfGoodsSet.Model, typeOfGoodsSet.Country, typeOfGoodsSet.PriceMax, typeOfGoodsSet.PriceMin,typeOfGoodsSet.Color
                    });

                    item.Tag = typeOfGoodsSet;

                    listView2.Items.Add(item);
                }

            }

            listView0.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listView0.SelectedItems.Count == 1)
                {
                    TypeOfGoodsSet typeOfGoodsSet = listView0.SelectedItems[0].Tag as TypeOfGoodsSet;
                    typeOfGoodsSet.Manufacturer = textBoxManufacturer.Text;
                    typeOfGoodsSet.Model = textBoxModel.Text;
                    typeOfGoodsSet.Country = textBoxCountry.Text;
                    typeOfGoodsSet.PriceMax = textBoxPriceMax.Text;
                    typeOfGoodsSet.PriceMin = textBoxPriceMin.Text;
                    typeOfGoodsSet.Year = textBoxYear.Text;
                    typeOfGoodsSet.SIMСards = textBoxSIMСards.Text;
                    typeOfGoodsSet.Color = textBoxColor.Text;
                    Program.wftDb.SaveChanges();
                    TypeOfGoodsSet();

                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listView1.SelectedItems.Count == 1)
                    {
                        TypeOfGoodsSet typeOfGoodsSet = listView1.SelectedItems[0].Tag as TypeOfGoodsSet;
                        typeOfGoodsSet.Manufacturer = textBoxManufacturer.Text;
                        typeOfGoodsSet.Model = textBoxModel.Text;
                        typeOfGoodsSet.Country = textBoxCountry.Text;
                        typeOfGoodsSet.PriceMax = textBoxPriceMax.Text;
                        typeOfGoodsSet.PriceMin = textBoxPriceMin.Text;
                        typeOfGoodsSet.Year = textBoxYear.Text;

                        typeOfGoodsSet.Color = textBoxColor.Text;

                        Program.wftDb.SaveChanges();
                        TypeOfGoodsSet();


                    }
                    else
                    {
                        if (listView2.SelectedItems.Count == 1)
                        {
                            TypeOfGoodsSet typeOfGoodsSet = listView2.SelectedItems[0].Tag as TypeOfGoodsSet;
                            typeOfGoodsSet.Model = textBoxModel.Text;
                            typeOfGoodsSet.Country = textBoxCountry.Text;
                            typeOfGoodsSet.PriceMax = textBoxPriceMax.Text;
                            typeOfGoodsSet.PriceMin = textBoxPriceMin.Text;
                            typeOfGoodsSet.Color = textBoxColor.Text;

                            Program.wftDb.SaveChanges();
                            TypeOfGoodsSet();

                        }
                    }
                }
            }
        }

        private void listView0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView0.SelectedItems.Count == 1)
            {
                TypeOfGoodsSet typeOfGoodsSet = listView0.SelectedItems[0].Tag as TypeOfGoodsSet;
                textBoxManufacturer.Text = typeOfGoodsSet.Manufacturer;
                textBoxModel.Text = typeOfGoodsSet.Model;
                textBoxCountry.Text = typeOfGoodsSet.Country;
                textBoxPriceMax.Text = typeOfGoodsSet.PriceMax;
                textBoxPriceMin.Text = typeOfGoodsSet.PriceMin;
                textBoxYear.Text = typeOfGoodsSet.Year;
                textBoxSIMСards.Text = typeOfGoodsSet.SIMСards;
                textBoxColor.Text = typeOfGoodsSet.Color;

            }
            else
            {
                textBoxManufacturer.Text = "";
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
                textBoxYear.Text = "";
                textBoxSIMСards.Text = "";
                textBoxColor.Text = "";




            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                TypeOfGoodsSet typeOfGoodsSet = listView1.SelectedItems[0].Tag as TypeOfGoodsSet;
                textBoxManufacturer.Text = typeOfGoodsSet.Manufacturer;
                textBoxModel.Text = typeOfGoodsSet.Model;
                textBoxCountry.Text = typeOfGoodsSet.Country;
                textBoxPriceMax.Text = typeOfGoodsSet.PriceMax;
                textBoxPriceMin.Text = typeOfGoodsSet.PriceMin;
                textBoxYear.Text = typeOfGoodsSet.Year;

                textBoxColor.Text = typeOfGoodsSet.Color;

            }
            else
            {
                textBoxManufacturer.Text = "";
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
                textBoxYear.Text = "";
               
                textBoxColor.Text = "";
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                TypeOfGoodsSet typeOfGoodsSet = listView2.SelectedItems[0].Tag as TypeOfGoodsSet;
             
                textBoxModel.Text = typeOfGoodsSet.Model;
                textBoxCountry.Text = typeOfGoodsSet.Country;
                textBoxPriceMax.Text = typeOfGoodsSet.PriceMax;
                textBoxPriceMin.Text = typeOfGoodsSet.PriceMin;
            

                textBoxColor.Text = typeOfGoodsSet.Color;

            }
            else
            {
              
                textBoxModel.Text = "";
                textBoxCountry.Text = "";
                textBoxPriceMax.Text = "";
                textBoxPriceMin.Text = "";
            

                textBoxColor.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listView0.SelectedItems.Count == 1)
                    {
                        TypeOfGoodsSet typeOfGoodsSet = listView0.SelectedItems[0].Tag as TypeOfGoodsSet;
                        Program.wftDb.TypeOfGoodsSet.Remove(typeOfGoodsSet);
                        Program.wftDb.SaveChanges();
                        TypeOfGoodsSet();
                    }
                    textBoxManufacturer.Text = "";
                    textBoxModel.Text = "";
                    textBoxCountry.Text = "";
                    textBoxPriceMax.Text = "";
                    textBoxPriceMin.Text = "";
                    textBoxYear.Text = "";
                    textBoxSIMСards.Text = "";
                    textBoxColor.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listView1.SelectedItems.Count == 1)
                    {
                        TypeOfGoodsSet typeOfGoodsSet = listView1.SelectedItems[0].Tag as TypeOfGoodsSet;
                        Program.wftDb.TypeOfGoodsSet.Remove(typeOfGoodsSet);
                        Program.wftDb.SaveChanges();
                        TypeOfGoodsSet();
                    }
                    textBoxManufacturer.Text = "";
                    textBoxModel.Text = "";
                    textBoxCountry.Text = "";
                    textBoxPriceMax.Text = "";
                    textBoxPriceMin.Text = "";
                    textBoxYear.Text = "";

                    textBoxColor.Text = "";

                }
                else
                {
                    if (listView2.SelectedItems.Count == 1)
                    {
                        TypeOfGoodsSet typeOfGoodsSet = listView2.SelectedItems[0].Tag as TypeOfGoodsSet;
                        Program.wftDb.TypeOfGoodsSet.Remove(typeOfGoodsSet);
                        Program.wftDb.SaveChanges();
                        TypeOfGoodsSet();
                    }
                    textBoxModel.Text = "";
                    textBoxCountry.Text = "";
                    textBoxPriceMax.Text = "";
                    textBoxPriceMin.Text = "";


                    textBoxColor.Text = "";

                }


            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    


