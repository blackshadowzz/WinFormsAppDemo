namespace WinFormsAppDemo.Forms.Lists.Categories
{
    partial class UpdateCategoryForm
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
            label1 = new Label();
            txtCategoryName = new TextBox();
            richTextBoxDesc = new RichTextBox();
            label2 = new Label();
            checkBoxIsActive = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(148, 24);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(362, 29);
            txtCategoryName.TabIndex = 1;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(149, 77);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(487, 46);
            richTextBoxDesc.TabIndex = 2;
            richTextBoxDesc.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Checked = true;
            checkBoxIsActive.CheckState = CheckState.Checked;
            checkBoxIsActive.Location = new Point(550, 26);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(86, 25);
            checkBoxIsActive.TabIndex = 4;
            checkBoxIsActive.Text = "Is Active";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(535, 155);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(444, 155);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 37);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // CreateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 221);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(checkBoxIsActive);
            Controls.Add(label2);
            Controls.Add(richTextBoxDesc);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UpdatCategoryForm";
            Text = "Update Category";
            Load += UpdateCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private RichTextBox richTextBoxDesc;
        private Label label2;
        private CheckBox checkBoxIsActive;
        private Button btnSave;
        private Button btnClose;
    }
}