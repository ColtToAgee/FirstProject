using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productdal = new ProductDal();
        private void Form1_Load(object sender,EventArgs e)
        { 
            dgwProducts.DataSource = productdal.GetAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        ProductDal _productdal = new ProductDal();
        private void button1_Click(object sender, EventArgs e)
        {
            _productdal.Add_Product(new Product
            {
                product_name = Convert.ToString(textBox1.Text),
                product_category = Convert.ToString(textBox2.Text),
                product_price = Convert.ToDouble(textBox3.Text),
                product_number = Convert.ToInt32(textBox4.Text),
            }) ;
            DataTable dataTable = new ProductDal().GetAll();
            dgwProducts.DataSource=dataTable;
            MessageBox.Show("Eklendi!!!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _productdal.Update_Product(new Product
            {
                Id= Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                product_name=textBox8.Text,
                product_category=textBox7.Text,
                product_price=Convert.ToDouble(textBox6.Text),
                product_number=Convert.ToInt32(textBox5.Text),
            });
            DataTable dataTable = new ProductDal().GetAll();
            dgwProducts.DataSource=dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _productdal.Delete_Product(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                product_name = textBox8.Text,
                product_category = textBox7.Text,
                product_price = Convert.ToDouble(textBox6.Text),
                product_number = Convert.ToInt32(textBox5.Text),
            });
            DataTable dataTable=new ProductDal().GetAll();
            dgwProducts.DataSource = dataTable;
        }
    }
}
