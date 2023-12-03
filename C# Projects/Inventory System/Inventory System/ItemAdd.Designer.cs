namespace Inventory_System
{
    partial class frmItemAdd
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
            txtName = new TextBox();
            label1 = new Label();
            txtStocks = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbbSupplier = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(143, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 33);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // txtStocks
            // 
            txtStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStocks.Location = new Point(143, 59);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(236, 33);
            txtStocks.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 7;
            label2.Text = "Stocks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 101);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Supplier";
            // 
            // cbbSupplier
            // 
            cbbSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSupplier.FormattingEnabled = true;
            cbbSupplier.Location = new Point(143, 101);
            cbbSupplier.Name = "cbbSupplier";
            cbbSupplier.Size = new Size(236, 33);
            cbbSupplier.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(143, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(241, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmItemAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 205);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cbbSupplier);
            Controls.Add(label3);
            Controls.Add(txtStocks);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmItemAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtStocks;
        private Label label2;
        private Label label3;
        private ComboBox cbbSupplier;
        private Button btnAdd;
        private Button btnCancel;
    }
}