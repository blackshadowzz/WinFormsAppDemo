namespace WinFormsAppDemo.Forms.Lists.Products
{
    partial class ProductDetailsForm
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
            numericUpDownQty = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            checkBoxIsActive = new CheckBox();
            btnCancel = new Button();
            label6 = new Label();
            label7 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            comboBoxCategory = new ComboBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            pictureBoxProduct = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.Location = new Point(667, 141);
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(202, 29);
            numericUpDownQty.TabIndex = 30;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(372, 143);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(202, 29);
            numericUpDownPrice.TabIndex = 29;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(783, 52);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(86, 25);
            checkBoxIsActive.TabIndex = 28;
            checkBoxIsActive.Text = "Is Active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(764, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(580, 143);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 26;
            label6.Text = "Stock Qty:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 145);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 25;
            label7.Text = "Price:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(372, 199);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(497, 85);
            txtDescription.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 202);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 23;
            label4.Text = "Description:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(372, 94);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(497, 29);
            comboBoxCategory.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 21;
            label3.Text = "Category:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(372, 48);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(382, 29);
            txtProductName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 51);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 19;
            label2.Text = "Product Name:";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = SystemColors.ControlLight;
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(20, 51);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(194, 194);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProduct.TabIndex = 18;
            pictureBoxProduct.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 31;
            label1.Text = "Details";
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 359);
            Controls.Add(label1);
            Controls.Add(numericUpDownQty);
            Controls.Add(numericUpDownPrice);
            Controls.Add(checkBoxIsActive);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxCategory);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(pictureBoxProduct);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            Load += ProductDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownQty;
        private NumericUpDown numericUpDownPrice;
        private CheckBox checkBoxIsActive;
        private Button btnCancel;
        private Label label6;
        private Label label7;
        private TextBox txtDescription;
        private Label label4;
        private ComboBox comboBoxCategory;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private PictureBox pictureBoxProduct;
        private Label label1;
    }
}