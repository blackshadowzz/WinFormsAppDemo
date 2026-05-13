namespace WinFormsAppDemo.Forms.Lists.Products
{
    partial class ProductCreateForm
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
            pictureBoxProduct = new PictureBox();
            label1 = new Label();
            btnBrowse = new Button();
            label2 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            comboBoxCategory = new ComboBox();
            txtDescription = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            checkBoxIsActive = new CheckBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownQty = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = SystemColors.ControlLight;
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(31, 63);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(194, 194);
            pictureBoxProduct.TabIndex = 0;
            pictureBoxProduct.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(31, 263);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(194, 33);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 63);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 3;
            label2.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(383, 60);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(382, 29);
            txtProductName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 109);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(383, 106);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(497, 29);
            comboBoxCategory.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(383, 211);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(497, 85);
            txtDescription.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 214);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 7;
            label4.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 155);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 11;
            label6.Text = "Stock Qty:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 157);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 9;
            label7.Text = "Price:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(774, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 32);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(660, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(794, 64);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(86, 25);
            checkBoxIsActive.TabIndex = 15;
            checkBoxIsActive.Text = "Is Active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(383, 155);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(202, 29);
            numericUpDownPrice.TabIndex = 16;
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.Location = new Point(678, 153);
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(202, 29);
            numericUpDownQty.TabIndex = 17;
            // 
            // ProductCreateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 378);
            Controls.Add(numericUpDownQty);
            Controls.Add(numericUpDownPrice);
            Controls.Add(checkBoxIsActive);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxCategory);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(btnBrowse);
            Controls.Add(label1);
            Controls.Add(pictureBoxProduct);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ProductCreateForm";
            Text = "Product Create";
            Load += ProductCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProduct;
        private Label label1;
        private Button btnBrowse;
        private Label label2;
        private TextBox txtProductName;
        private Label label3;
        private ComboBox comboBoxCategory;
        private TextBox txtDescription;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox checkBoxIsActive;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownQty;
    }
}