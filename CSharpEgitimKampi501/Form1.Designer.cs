namespace CSharpEgitimKampi501
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.lblProductID = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblProductName = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblProductStock = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.lblProductCategory = new System.Windows.Forms.Label();
			this.cmbProductCategory = new System.Windows.Forms.ComboBox();
			this.btnList = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnGetByID = new System.Windows.Forms.Button();
			this.lblTotalBookCount = new System.Windows.Forms.Label();
			this.labelTotalBookCount = new System.Windows.Forms.Label();
			this.labelMaxPriceBook = new System.Windows.Forms.Label();
			this.lblMaxPriceBook = new System.Windows.Forms.Label();
			this.labelCategoryCount = new System.Windows.Forms.Label();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(245, 23);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(344, 22);
			this.txtProductID.TabIndex = 2;
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductID.Location = new System.Drawing.Point(12, 23);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(105, 25);
			this.lblProductID.TabIndex = 1;
			this.lblProductID.Text = "ÜRÜN ID:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(595, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(780, 501);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(125, 400);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(260, 42);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductName.Location = new System.Drawing.Point(12, 102);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(120, 25);
			this.lblProductName.TabIndex = 3;
			this.lblProductName.Text = "ÜRÜN ADI:";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(245, 102);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(344, 22);
			this.txtProductName.TabIndex = 4;
			// 
			// lblProductStock
			// 
			this.lblProductStock.AutoSize = true;
			this.lblProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductStock.Location = new System.Drawing.Point(12, 178);
			this.lblProductStock.Name = "lblProductStock";
			this.lblProductStock.Size = new System.Drawing.Size(149, 25);
			this.lblProductStock.TabIndex = 5;
			this.lblProductStock.Text = "ÜRÜN ADEDİ:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(245, 178);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(344, 22);
			this.txtProductStock.TabIndex = 6;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.AutoSize = true;
			this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductPrice.Location = new System.Drawing.Point(12, 256);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(152, 25);
			this.lblProductPrice.TabIndex = 7;
			this.lblProductPrice.Text = "ÜRÜN FİYATI:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(245, 256);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(344, 22);
			this.txtProductPrice.TabIndex = 8;
			// 
			// lblProductCategory
			// 
			this.lblProductCategory.AutoSize = true;
			this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductCategory.Location = new System.Drawing.Point(12, 340);
			this.lblProductCategory.Name = "lblProductCategory";
			this.lblProductCategory.Size = new System.Drawing.Size(216, 25);
			this.lblProductCategory.TabIndex = 9;
			this.lblProductCategory.Text = "ÜRÜN KATEGORİSİ:";
			// 
			// cmbProductCategory
			// 
			this.cmbProductCategory.FormattingEnabled = true;
			this.cmbProductCategory.Location = new System.Drawing.Point(245, 340);
			this.cmbProductCategory.Name = "cmbProductCategory";
			this.cmbProductCategory.Size = new System.Drawing.Size(344, 24);
			this.cmbProductCategory.TabIndex = 10;
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(125, 448);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(260, 42);
			this.btnList.TabIndex = 12;
			this.btnList.Text = "LİSTELE";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(125, 496);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(260, 42);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(125, 544);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(260, 42);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnGetByID
			// 
			this.btnGetByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetByID.Location = new System.Drawing.Point(125, 592);
			this.btnGetByID.Name = "btnGetByID";
			this.btnGetByID.Size = new System.Drawing.Size(260, 42);
			this.btnGetByID.TabIndex = 15;
			this.btnGetByID.Text = "ID\'YE GÖRE GETİR";
			this.btnGetByID.UseVisualStyleBackColor = true;
			// 
			// lblTotalBookCount
			// 
			this.lblTotalBookCount.AutoSize = true;
			this.lblTotalBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalBookCount.Location = new System.Drawing.Point(483, 570);
			this.lblTotalBookCount.Name = "lblTotalBookCount";
			this.lblTotalBookCount.Size = new System.Drawing.Size(253, 29);
			this.lblTotalBookCount.TabIndex = 16;
			this.lblTotalBookCount.Text = "Toplam Kitap Sayısı:";
			// 
			// labelTotalBookCount
			// 
			this.labelTotalBookCount.AutoSize = true;
			this.labelTotalBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelTotalBookCount.Location = new System.Drawing.Point(770, 570);
			this.labelTotalBookCount.Name = "labelTotalBookCount";
			this.labelTotalBookCount.Size = new System.Drawing.Size(21, 29);
			this.labelTotalBookCount.TabIndex = 17;
			this.labelTotalBookCount.Text = "-";
			// 
			// labelMaxPriceBook
			// 
			this.labelMaxPriceBook.AutoSize = true;
			this.labelMaxPriceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMaxPriceBook.Location = new System.Drawing.Point(770, 634);
			this.labelMaxPriceBook.Name = "labelMaxPriceBook";
			this.labelMaxPriceBook.Size = new System.Drawing.Size(21, 29);
			this.labelMaxPriceBook.TabIndex = 19;
			this.labelMaxPriceBook.Text = "-";
			// 
			// lblMaxPriceBook
			// 
			this.lblMaxPriceBook.AutoSize = true;
			this.lblMaxPriceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaxPriceBook.Location = new System.Drawing.Point(483, 634);
			this.lblMaxPriceBook.Name = "lblMaxPriceBook";
			this.lblMaxPriceBook.Size = new System.Drawing.Size(198, 29);
			this.lblMaxPriceBook.TabIndex = 18;
			this.lblMaxPriceBook.Text = "En Pahalı Kitap:";
			// 
			// labelCategoryCount
			// 
			this.labelCategoryCount.AutoSize = true;
			this.labelCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelCategoryCount.Location = new System.Drawing.Point(770, 704);
			this.labelCategoryCount.Name = "labelCategoryCount";
			this.labelCategoryCount.Size = new System.Drawing.Size(21, 29);
			this.labelCategoryCount.TabIndex = 21;
			this.labelCategoryCount.Text = "-";
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryCount.Location = new System.Drawing.Point(483, 704);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(196, 29);
			this.lblCategoryCount.TabIndex = 20;
			this.lblCategoryCount.Text = "Kategori Sayısı:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(1772, 742);
			this.Controls.Add(this.labelCategoryCount);
			this.Controls.Add(this.lblCategoryCount);
			this.Controls.Add(this.labelMaxPriceBook);
			this.Controls.Add(this.lblMaxPriceBook);
			this.Controls.Add(this.labelTotalBookCount);
			this.Controls.Add(this.lblTotalBookCount);
			this.Controls.Add(this.btnGetByID);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.cmbProductCategory);
			this.Controls.Add(this.lblProductCategory);
			this.Controls.Add(this.lblProductPrice);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.lblProductStock);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblProductID);
			this.Controls.Add(this.txtProductID);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblProductStock;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label lblProductPrice;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label lblProductCategory;
		private System.Windows.Forms.ComboBox cmbProductCategory;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnGetByID;
		private System.Windows.Forms.Label lblTotalBookCount;
		private System.Windows.Forms.Label labelTotalBookCount;
		private System.Windows.Forms.Label labelMaxPriceBook;
		private System.Windows.Forms.Label lblMaxPriceBook;
		private System.Windows.Forms.Label labelCategoryCount;
		private System.Windows.Forms.Label lblCategoryCount;
	}
}

