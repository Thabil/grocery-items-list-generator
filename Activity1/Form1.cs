using System;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form

        
    {
        private int itemNumber = 1;
        public Form1()
        {
            InitializeComponent();
            //prepopulated grocery items
            comboBox1.Items.AddRange(new object[] { "Laptop", "Calculator" ,"Smart Watch", "TV", "PlayStation"," Hard BitCoin Wa"});

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //to add items from comboBox to the list
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (!listBox1.Items.Contains(selectedItem))
                {
                    listBox1.Items.Add(selectedItem);
                    DisplayMessage(selectedItem);
                    itemNumber++;

                }
                else
                {
                    MessageBox.Show("Item already exists in the list!", "Error");
                }

            }
        }
        
        //remove Items from the list
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) { 
                listBox1.Items.Remove(listBox1.SelectedItem);
                //itemNumber--;
            }


        }
        private void DisplayMessage(string addedItem)
        {
            label1.Text = $"Item Number: {itemNumber} has been added";
            itemNumber--;
        }
    }
}
