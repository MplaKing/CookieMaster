namespace Cookie_Master
{
    partial class AddPurchaseForm
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
            this.NameLabelPurchase = new System.Windows.Forms.Label();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.CancelPurchaseButton = new System.Windows.Forms.Button();
            this.PurchaseCostLabel = new System.Windows.Forms.Label();
            this.AddPurchaseNameBox = new System.Windows.Forms.TextBox();
            this.PurchaseCostBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabelPurchase
            // 
            this.NameLabelPurchase.AutoSize = true;
            this.NameLabelPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabelPurchase.Location = new System.Drawing.Point(26, 24);
            this.NameLabelPurchase.Name = "NameLabelPurchase";
            this.NameLabelPurchase.Size = new System.Drawing.Size(143, 21);
            this.NameLabelPurchase.TabIndex = 1;
            this.NameLabelPurchase.Text = "Имя сотрудника:";
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Location = new System.Drawing.Point(26, 114);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(150, 35);
            this.AddPurchaseButton.TabIndex = 3;
            this.AddPurchaseButton.Text = "Добавить";
            this.AddPurchaseButton.UseVisualStyleBackColor = true;
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // CancelPurchaseButton
            // 
            this.CancelPurchaseButton.Location = new System.Drawing.Point(202, 114);
            this.CancelPurchaseButton.Name = "CancelPurchaseButton";
            this.CancelPurchaseButton.Size = new System.Drawing.Size(150, 35);
            this.CancelPurchaseButton.TabIndex = 4;
            this.CancelPurchaseButton.Text = "Отмена";
            this.CancelPurchaseButton.UseVisualStyleBackColor = true;
            this.CancelPurchaseButton.Click += new System.EventHandler(this.CancelPurchaseButton_Click);
            // 
            // PurchaseCostLabel
            // 
            this.PurchaseCostLabel.AutoSize = true;
            this.PurchaseCostLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchaseCostLabel.Location = new System.Drawing.Point(26, 66);
            this.PurchaseCostLabel.Name = "PurchaseCostLabel";
            this.PurchaseCostLabel.Size = new System.Drawing.Size(167, 21);
            this.PurchaseCostLabel.TabIndex = 5;
            this.PurchaseCostLabel.Text = "Стоимость печенья:";
            // 
            // AddPurchaseNameBox
            // 
            this.AddPurchaseNameBox.Location = new System.Drawing.Point(202, 22);
            this.AddPurchaseNameBox.Name = "AddPurchaseNameBox";
            this.AddPurchaseNameBox.Size = new System.Drawing.Size(150, 23);
            this.AddPurchaseNameBox.TabIndex = 6;
            // 
            // PurchaseCostBox
            // 
            this.PurchaseCostBox.Location = new System.Drawing.Point(202, 64);
            this.PurchaseCostBox.Name = "PurchaseCostBox";
            this.PurchaseCostBox.Size = new System.Drawing.Size(150, 23);
            this.PurchaseCostBox.TabIndex = 7;
            this.PurchaseCostBox.Text = "0";
            // 
            // AddPurchaseForm
            // 
            this.AcceptButton = this.AddPurchaseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPurchaseButton;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.PurchaseCostBox);
            this.Controls.Add(this.AddPurchaseNameBox);
            this.Controls.Add(this.PurchaseCostLabel);
            this.Controls.Add(this.CancelPurchaseButton);
            this.Controls.Add(this.AddPurchaseButton);
            this.Controls.Add(this.NameLabelPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о покупке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabelPurchase;
        private Button AddPurchaseButton;
        private Button CancelPurchaseButton;
        private Label PurchaseCostLabel;
        private TextBox AddPurchaseNameBox;
        private TextBox PurchaseCostBox;
    }
}