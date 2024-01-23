using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shepard_Hawj_CPT_206_A01S_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void QuerySearch1(string num, string des, int moreUnit)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox.Items.Clear();
            var results = from item in db.Products
                          where item.Product_Number.Contains(num)
                          where item.Description.Contains(des)
                          where item.Units_On_Hand > moreUnit
                          select item.Product_Number + " " + item.Description + "............" + item.Price;
            foreach (string item in results)
            {
                outputListBox.Items.Add(item);
            }

            if(outputListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }
        private void QuerySearch2(string num, string des, int lessUnit)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox.Items.Clear();
            var results = from item in db.Products
                          where item.Product_Number.Contains(num)
                          where item.Description.Contains(des)
                          where item.Units_On_Hand < lessUnit
                          select item.Product_Number + " " + item.Description + "............" + item.Price;
            foreach (string item in results)
            {
                outputListBox.Items.Add(item);
            }

            if (outputListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }

        //QuerySearch1_1 Method, for Product Num and Product Description
        private void QuerySearch1_1(string num, string des)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox.Items.Clear(); //clear items in listbox
            var results = from item in db.Products //linq query for product number and description
                          where item.Product_Number.Contains(num)
                          where item.Description.Contains(des)
                          select item.Product_Number + " " + item.Description + "............" + item.Price;
            foreach (string item in results)
            {
                outputListBox.Items.Add(item);
            }

            if (outputListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }
        
        //QuerySearch2_1 Method, for units on hand that are more than 
        private void QuerySearch2_1(int moreUnit)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox2.Items.Clear();
            var results = from item in db.Products //linq query for units on hand, more than
                          where item.Units_On_Hand > moreUnit 
                          select item.Product_Number + " " + item.Description + "............" + item.Units_On_Hand;
            foreach (string item in results)
            {
                outputListBox2.Items.Add(item);
            }

            if (outputListBox2.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }

        //QuerySearch2_2 Method, for units on hand that are less than
        private void QuerySearch2_2(int lessUnit)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox2.Items.Clear();
            var results = from item in db.Products //linq query for units on hand, less than
                          where item.Units_On_Hand < lessUnit
                          select item.Product_Number + " " + item.Description + "............" + item.Units_On_Hand;
            foreach (string item in results)
            {
                outputListBox2.Items.Add(item);
            }

            if (outputListBox2.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }

        //QuerySearch3_1 Method, for prices that are more than
        private void QuerySearch3_1(decimal min)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox3.Items.Clear();
            var results = from item in db.Products //linq query for prices, more than
                          where item.Price > min
                          select item.Product_Number + " " + item.Description + "............" + item.Price;
            foreach (string item in results)
            {
                outputListBox3.Items.Add(item);
            }

            if (outputListBox3.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }

        //QuerySearch3_2 Method, for prices that are less than
        private void QuerySearch3_2(decimal max)
        {
            ProductDBDataContext db = new ProductDBDataContext();
            outputListBox3.Items.Clear();
            var results = from item in db.Products
                          where item.Price < max //linq query for prices, less than
                          select item.Product_Number + " " + item.Description + "............" + item.Price;
            foreach (string item in results)
            {
                outputListBox3.Items.Add(item);
            }

            if (outputListBox3.Items.Count == 0)
            {
                MessageBox.Show("There are no matches.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
            ProductDBDataContext db = new ProductDBDataContext();

            var results = from item in db.Products
                          orderby item.Units_On_Hand ascending
                          select item.Product_Number + " " + item.Description + "............" + item.Units_On_Hand;

            foreach (string item in results) //loads the second list box, outputListBox2
            {
                outputListBox2.Items.Add(item);
            }

            var priceResults = from item1 in db.Products
                               orderby item1.Price ascending
                               select item1.Product_Number + " " + item1.Description + "............" + item1.Price;
            foreach (string item1 in priceResults) //loads the third list box, outputListBox3
            {
                outputListBox3.Items.Add(item1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string inputProdNum = "";
            string inputProdDes = "";
            int num_input1 = 0;
            int num_input2 = 0;
            //decimal num_input3 = 0m;
            //decimal num_input4 = 0m;
            inputProdNum = productNumTextBox.Text;
            inputProdDes = productDesTextBox.Text;
            if ((!string.IsNullOrWhiteSpace(moreTextBox.Text)) && (!string.IsNullOrWhiteSpace(lessTextBox.Text)))
            {
                MessageBox.Show("Cannot have values in multiple text boxes. Please enter a value in ONLY one text box.");
            }
            else if (int.TryParse(moreTextBox.Text, out num_input1))
            {
                QuerySearch1(inputProdNum, inputProdDes, num_input1);
            }
            else if (int.TryParse(lessTextBox.Text, out num_input2))
            {
                QuerySearch2(inputProdNum, inputProdDes, num_input2);
            }
            //else if (decimal.TryParse(minTextBox.Text, out num_input3))
            //{
            //    QuerySearch1(inputProdNum, inputProdDes, num_input1, num_input2, num_input3);
            //}
            else
            {
                if (moreTextBox.Text != "" || lessTextBox.Text != "")
                {
                    MessageBox.Show("Incorrect data type, please enter correct data type.");
                }
                else
                {
                    moreTextBox.Text = "0";
                    lessTextBox.Text = "0";
                    btnSearch_Click(sender, e);
                }
            }
            //if(string.IsNullOrWhiteSpace(productNumTextBox.Text) && string.IsNullOrWhiteSpace(productDesTextBox.Text) && string.IsNullOrWhiteSpace(moreTextBox.Text) && string.IsNullOrWhiteSpace(lessTextBox.Text))
            //{
            //    MessageBox.Show("Please enter an entry into one of the text boxes.");
            //}
            //else if((!string.IsNullOrWhiteSpace(productNumTextBox.Text)) || (!string.IsNullOrWhiteSpace(productDesTextBox.Text)) || (!string.IsNullOrWhiteSpace(moreTextBox.Text)) || (!string.IsNullOrWhiteSpace(lessTextBox.Text)))
            //{
            //    MessageBox.Show("Cannot have values in multiple text boxes. Please enter a value in ONLY one text box.");
            //}
            //if(!string.IsNullOrWhiteSpace(productNumTextBox.Text))
            //{
            //    outputListBox.Items.Clear();
            //    inputProdNum = productNumTextBox.Text;
            //    QuerySearch(input);
            //    var results = from item in db.Products
            //                  where item.Product_Number.Contains(input)
            //                  select item.Product_Number + " " + item.Description + "............" + item.Price;
            //    foreach (string item in results)
            //    {
            //        outputListBox.Items.Add(item);
            //    }
            //}
            //else if(!string.IsNullOrEmpty(productDesTextBox.Text))
            //{
            //    outputListBox.Items.Clear();
            //    input = productDesTextBox.Text;
            //    QuerySearch(input);
            //    var results = from item in db.Products
            //                  where item.Description.Contains(input)
            //                  select item.Product_Number + " " + item.Description + "............" + item.Price;
            //    foreach (string item in results)
            //    {
            //        outputListBox.Items.Add(item);
            //    }
            //}
            //else if(!string.IsNullOrEmpty(moreTextBox.Text))
            //{
            //    outputListBox.Items.Clear();
            //    num_input = int.Parse(moreTextBox.Text);
            //    var results = from item in db.Products
            //                  where item.Units_On_Hand > num_input
            //                  select item.Product_Number + " " + item.Description + "............" + item.Price;
            //    foreach(string item in results)
            //    {
            //        outputListBox.Items.Add(item);
            //    }
            //}
            //else if(!string.IsNullOrEmpty(lessTextBox.Text))
            //{
            //    outputListBox.Items.Clear();
            //    num_input = int.Parse(lessTextBox.Text);
            //    var results = from item in db.Products
            //                  where item.Units_On_Hand < num_input
            //                  select item.Product_Number + " " + item.Description + "............" + item.Price;
            //    foreach(string item in results)
            //    {
            //        outputListBox.Items.Add(item);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter an entry into one of the text boxes.");
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            productNumTextBox.Clear();
            productDesTextBox.Clear();
            moreTextBox.Clear();
            lessTextBox.Clear();
            outputListBox.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_1_Click(object sender, EventArgs e)
        {
            string inputProdNum = "";
            string inputProdDes = "";
            inputProdNum = productNumTextBox.Text;
            inputProdDes = productDesTextBox.Text;
            if (string.IsNullOrWhiteSpace(productNumTextBox.Text) && string.IsNullOrWhiteSpace(productDesTextBox.Text))
            {
                MessageBox.Show("Please enter an entry into one of the text boxes.");
            }
            //else if (!string.IsNullOrEmpty(productDesTextBox.Text) && !string.IsNullOrEmpty(productNumTextBox.Text))
            //{
            //    MessageBox.Show("Cannot have text in both text boxes. Please enter text in one text box.");
            //}
            else if(!string.IsNullOrWhiteSpace(productNumTextBox.Text))
            {
                QuerySearch1_1(inputProdNum, inputProdDes); //run method for search of product number and product description
            }
            else if (!string.IsNullOrWhiteSpace(productDesTextBox.Text))
            {
                QuerySearch1_1(inputProdNum, inputProdDes);
            }

        }

        private void btnClear_1_Click(object sender, EventArgs e)
        {
            productNumTextBox.Clear();
            productDesTextBox.Clear();
            outputListBox.Items.Clear();
        }

        private void btnSearch_2_Click(object sender, EventArgs e)
        {
            int moreThan = 0;
            int lessThan = 0;
            if (int.TryParse(moreTextBox.Text, out moreThan))
            {
                QuerySearch2_1(moreThan);
            }
            else if (int.TryParse(lessTextBox.Text, out lessThan))
            {
                QuerySearch2_2(lessThan);
            }
            else
            {
                MessageBox.Show("Please enter an entry into one of the text boxes.");
            }
        }

        private void btnClear_2_Click(object sender, EventArgs e)
        {
            moreTextBox.Clear();
            lessTextBox.Clear();
        }

        private void btnSearch_3_Click(object sender, EventArgs e)
        {
            decimal min = 0m;
            decimal max = 0m;
            if (decimal.TryParse(minTextBox.Text, out min))
            {
                QuerySearch3_1(min);
            }
            else if (decimal.TryParse(maxTextBox.Text, out max))
            {
                QuerySearch3_2(max);
            }
            else
            {
                MessageBox.Show("Please enter an entry into one of the text boxes.");
            }
        }

        private void btnClear_3_Click(object sender, EventArgs e)
        {
            maxTextBox.Clear();
            minTextBox.Clear();
        }
    }
}
