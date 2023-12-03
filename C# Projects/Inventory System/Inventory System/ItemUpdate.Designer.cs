namespace Inventory_System
{
    partial class frmItemUpdate
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
            btnCancel = new Button();
            btnUpdate = new Button();
            txtStocks = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnContactSupplier = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(279, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 36);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(181, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 36);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtStocks
            // 
            txtStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStocks.Location = new Point(181, 130);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(236, 33);
            txtStocks.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 133);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 19;
            label2.Text = "Updated Stocks";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(181, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 33);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 94);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // btnContactSupplier
            // 
            btnContactSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnContactSupplier.Location = new Point(12, 12);
            btnContactSupplier.Name = "btnContactSupplier";
            btnContactSupplier.Size = new Size(199, 36);
            btnContactSupplier.TabIndex = 27;
            btnContactSupplier.Text = "Contact Supplier";
            btnContactSupplier.UseVisualStyleBackColor = true;
            // 
            // frmItemUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 246);
            ControlBox = false;
            Controls.Add(btnContactSupplier);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtStocks);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmItemUpdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtStocks;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnContactSupplier;
    }
}