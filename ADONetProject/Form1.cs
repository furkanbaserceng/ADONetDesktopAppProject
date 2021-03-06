using ADONetProject.DataAccess;
using ADONetProject.Entities;

namespace ADONetProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void GetDataSource()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void ClearTextBoxAdd()
        {
            tbxProductNameAdd.Clear();
            tbxProductStockAmountAdd.Clear();
            tbxProductUnitPriceAdd.Clear();
        }
        private void ClearTextBoxUpdateOrDelete()
        {
            tbxProductIdUpdate.Clear();
            tbxProductNameUpdate.Clear();
            tbxProductStockAmountUpdate.Clear();
            tbxProductUnitPriceUpdate.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataSource();
            tbxProductIdUpdate.Enabled = false;
        }

        

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

            if(tbxProductNameAdd.Text=="" || tbxProductStockAmountAdd.Text == ""
                                          || tbxProductUnitPriceAdd.Text == "")
            {
                MessageBox.Show("It is not possible to add products!");

            }
            else
            {

                _productDal.Add(new Product
                {
                    ProductName = tbxProductNameAdd.Text,
                    ProductUnitPrice = Convert.ToDecimal(tbxProductUnitPriceAdd.Text),
                    ProductStockAmount = Convert.ToInt32(tbxProductStockAmountAdd.Text)


                });

                MessageBox.Show("Product Added Succesfully!");
                GetDataSource();
                ClearTextBoxAdd();

            }

            
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductIdUpdate.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxProductUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxProductStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {

            if (tbxProductNameUpdate.Text == "" || tbxProductStockAmountUpdate.Text == ""
                                          || tbxProductUnitPriceUpdate.Text == "")
            {
                MessageBox.Show("It is not possible to update products!");

            }

            else
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    ProductUnitPrice = Convert.ToDecimal(tbxProductUnitPriceUpdate.Text),
                    ProductStockAmount = Convert.ToInt32(tbxProductStockAmountUpdate.Text)
                };

                _productDal.Update(product);

                MessageBox.Show("Product Updated Succesfully!");
                GetDataSource();
                ClearTextBoxUpdateOrDelete();
            }

            

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {


            if (tbxProductIdUpdate.Text == "")
            {
                MessageBox.Show("It is not to possible delete products!");
            }
            else
            {
                int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);

                _productDal.Delete(id);

                MessageBox.Show("Product Deleted Successfully!");
                GetDataSource();
                ClearTextBoxUpdateOrDelete();
            }

            
        }
    }
}