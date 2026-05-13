namespace WinFormsAppDemo.Forms.Lists.Products
{
    partial class ProductListForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripBtnAdd = new ToolStripButton();
            toolStripButtonDetails = new ToolStripButton();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridViewProducts = new DataGridView();
            productBindingSource = new BindingSource(components);
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageUrlDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modifiedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Search: ";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnAdd, toolStripButtonDetails });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1050, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAdd
            // 
            toolStripBtnAdd.Image = (Image)resources.GetObject("toolStripBtnAdd.Image");
            toolStripBtnAdd.ImageTransparentColor = Color.Magenta;
            toolStripBtnAdd.Name = "toolStripBtnAdd";
            toolStripBtnAdd.Size = new Size(94, 22);
            toolStripBtnAdd.Text = "Add Product";
            toolStripBtnAdd.Click += toolStripBtnAdd_Click;
            // 
            // toolStripButtonDetails
            // 
            toolStripButtonDetails.Image = (Image)resources.GetObject("toolStripButtonDetails.Image");
            toolStripButtonDetails.ImageTransparentColor = Color.Magenta;
            toolStripButtonDetails.Name = "toolStripButtonDetails";
            toolStripButtonDetails.Size = new Size(107, 22);
            toolStripButtonDetails.Text = "Details Product";
            toolStripButtonDetails.Click += toolStripButtonDetails_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(82, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(848, 29);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(936, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockQtyDataGridViewTextBoxColumn, imageUrlDataGridViewTextBoxColumn, isActiveDataGridViewCheckBoxColumn, createdDateDataGridViewTextBoxColumn, modifiedDateDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productBindingSource;
            dataGridViewProducts.Location = new Point(12, 80);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.ShowEditingIcon = false;
            dataGridViewProducts.Size = new Size(1026, 425);
            dataGridViewProducts.TabIndex = 4;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            dataGridViewProducts.CellFormatting += dataGridViewProducts_CellFormatting;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQtyDataGridViewTextBoxColumn
            // 
            stockQtyDataGridViewTextBoxColumn.DataPropertyName = "StockQty";
            stockQtyDataGridViewTextBoxColumn.HeaderText = "StockQty";
            stockQtyDataGridViewTextBoxColumn.Name = "stockQtyDataGridViewTextBoxColumn";
            stockQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            imageUrlDataGridViewTextBoxColumn.ReadOnly = true;
            imageUrlDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            imageUrlDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            imageUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            modifiedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 552);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ProductListForm";
            Text = "Product Form";
            Load += ProductListForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridViewProducts;
        private BindingSource productBindingSource;
        private ToolStripButton toolStripButtonDetails;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private DataGridViewImageColumn imageUrlDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}