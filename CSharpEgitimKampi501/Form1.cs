using CSharpEgitimKampi501.DTOs;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//private void Form1_Load(object sender, EventArgs e)
		//{
		//	cmbProductCategory.DisplayMember = "ProductCategory";
		//	cmbProductCategory.ValueMember = "ProductID";
		//}

		//DAPPER DERSİ

		SqlConnection connection = new SqlConnection("Server=LAPTOP-2S32U8I2;initial catalog=EgitimKampi501;integrated security=true");

		private async void btnList_Click(object sender, EventArgs e)
		{
			string query = "select * from Product";

			var value = await connection.QueryAsync<ResultProductDto>(query);

			dataGridView1.DataSource = value;

			
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			string query = "insert into Product (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@ProductCategory)";

			var parametres = new DynamicParameters();

			parametres.Add("@productName", txtProductName.Text);
			parametres.Add("@productStock", int.Parse(txtProductStock.Text));
			parametres.Add("@productPrice", Convert.ToDecimal(txtProductPrice.Text));
			parametres.Add("@ProductCategory", cmbProductCategory.Text);

			await connection.ExecuteAsync(query, parametres);

			MessageBox.Show("Yeni kitap eklendi");
				
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "delete from Product where ProductID = @productID";

			var parametres = new DynamicParameters();

			parametres.Add("@productID",txtProductID.Text);

			await connection.ExecuteAsync(query,parametres);

			MessageBox.Show("Kitap silindi");
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "update Product set ProductName = @productName, ProductStock = @productStock, ProductPrice = @productPrice, ProductCategory = @productCategory where ProductID = @productID";

			var parametres = new DynamicParameters();

			parametres.Add("@productName", txtProductName.Text);
			parametres.Add("@productStock", int.Parse(txtProductStock.Text));
			parametres.Add("@productPrice", Convert.ToDecimal(txtProductPrice.Text));
			parametres.Add("@productCategory",cmbProductCategory.Text);
			parametres.Add("@productID", int.Parse(txtProductID.Text));

			await connection.ExecuteAsync(query,parametres);

			MessageBox.Show("Kitap güncellendi");
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			string query1 = "select count(*) from Product";

			//var value = await connection.ExecuteScalarAsync<int>(query);

			var value1 = await connection.QuerySingleAsync<int>(query1);

			labelTotalBookCount.Text = value1.ToString();


			string query2 = "select top 1 ProductName from Product order by ProductPrice desc";

			var value2 = await connection.QueryFirstOrDefaultAsync<string>(query2);

			labelMaxPriceBook.Text = value2.ToString();


			string query3 = "select count(distinct(ProductCategory)) from Product";

			var value3 = await connection.QueryFirstOrDefaultAsync<int>(query3);

			labelCategoryCount.Text = value3.ToString();
		}
	}
}
