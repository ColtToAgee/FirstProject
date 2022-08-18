using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        productdal _productdal=new productdal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productdal.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Search(textBox9.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productdal.Add(new Products
            {
                product_name=Convert.ToString(textBox1.Text),
                product_category=Convert.ToString(textBox2.Text),
                product_price=Convert.ToDouble(textBox3.Text),
                product_number=Convert.ToInt32(textBox4.Text),
            });
            dataGridView1.DataSource = _productdal.GetAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _productdal.Update(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                product_name = textBox8.Text,
                product_category = textBox7.Text,
                product_price = Convert.ToDouble(textBox6.Text),
                product_number = Convert.ToInt32(textBox5.Text),
            });
            dataGridView1.DataSource=_productdal.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _productdal.Delete(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                product_name = textBox8.Text,
                product_category = textBox7.Text,
                product_price = Convert.ToDouble(textBox6.Text),
                product_number = Convert.ToInt32(textBox5.Text),
            });
            dataGridView1.DataSource = _productdal.GetAll();
            textBox8.Text="";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
        }
        private void Search(string key)
        {
            dataGridView1.DataSource= _productdal.GetAll().Where(p=>p.product_name.ToLower().Contains(key.ToLower())).ToList();
        }
    }
}
