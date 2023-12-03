namespace Inventory_System
{
    partial class ItemLowStocks
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
            btnNo = new Button();
            btnYes = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.Location = new Point(259, 95);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(92, 36);
            btnNo.TabIndex = 29;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.Location = new Point(161, 95);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(92, 36);
            btnYes.TabIndex = 28;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(304, 25);
            label2.TabIndex = 27;
            label2.Text = "<Item Name> stock is less than 10.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 67);
            label1.Name = "label1";
            label1.Size = new Size(308, 25);
            label1.TabIndex = 30;
            label1.Text = "Would you like to contact supplier?";
            // 
            // ItemLowStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 150);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label2);
            Name = "ItemLowStocks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Low Contact Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNo;
        private Button btnYes;
        private Label label2;
        private Label label1;
    }
}