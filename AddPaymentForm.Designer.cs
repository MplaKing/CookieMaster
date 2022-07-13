namespace Cookie_Master
{
    partial class AddPaymentForm
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
            this.NameLabelPayment = new System.Windows.Forms.Label();
            this.AddPaymentButton = new System.Windows.Forms.Button();
            this.CancelPaymentButton = new System.Windows.Forms.Button();
            this.AddPaymentNameBox = new System.Windows.Forms.TextBox();
            this.PaymentCostLabel = new System.Windows.Forms.Label();
            this.PaymentCostBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabelPayment
            // 
            this.NameLabelPayment.AutoSize = true;
            this.NameLabelPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabelPayment.Location = new System.Drawing.Point(26, 24);
            this.NameLabelPayment.Name = "NameLabelPayment";
            this.NameLabelPayment.Size = new System.Drawing.Size(143, 21);
            this.NameLabelPayment.TabIndex = 2;
            this.NameLabelPayment.Text = "Имя сотрудника:";
            // 
            // AddPaymentButton
            // 
            this.AddPaymentButton.Location = new System.Drawing.Point(26, 114);
            this.AddPaymentButton.Name = "AddPaymentButton";
            this.AddPaymentButton.Size = new System.Drawing.Size(150, 35);
            this.AddPaymentButton.TabIndex = 4;
            this.AddPaymentButton.Text = "Добавить";
            this.AddPaymentButton.UseVisualStyleBackColor = true;
            this.AddPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click_1);
            // 
            // CancelPaymentButton
            // 
            this.CancelPaymentButton.Location = new System.Drawing.Point(202, 114);
            this.CancelPaymentButton.Name = "CancelPaymentButton";
            this.CancelPaymentButton.Size = new System.Drawing.Size(150, 35);
            this.CancelPaymentButton.TabIndex = 5;
            this.CancelPaymentButton.Text = "Отмена";
            this.CancelPaymentButton.UseVisualStyleBackColor = true;
            this.CancelPaymentButton.Click += new System.EventHandler(this.CancelPaymentButton_Click);
            // 
            // AddPaymentNameBox
            // 
            this.AddPaymentNameBox.Location = new System.Drawing.Point(202, 22);
            this.AddPaymentNameBox.Name = "AddPaymentNameBox";
            this.AddPaymentNameBox.Size = new System.Drawing.Size(150, 23);
            this.AddPaymentNameBox.TabIndex = 7;
            // 
            // PaymentCostLabel
            // 
            this.PaymentCostLabel.AutoSize = true;
            this.PaymentCostLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentCostLabel.Location = new System.Drawing.Point(26, 66);
            this.PaymentCostLabel.Name = "PaymentCostLabel";
            this.PaymentCostLabel.Size = new System.Drawing.Size(109, 21);
            this.PaymentCostLabel.TabIndex = 8;
            this.PaymentCostLabel.Text = "Возвращает:";
            // 
            // PaymentCostBox
            // 
            this.PaymentCostBox.Location = new System.Drawing.Point(202, 64);
            this.PaymentCostBox.Name = "PaymentCostBox";
            this.PaymentCostBox.Size = new System.Drawing.Size(150, 23);
            this.PaymentCostBox.TabIndex = 9;
            this.PaymentCostBox.Text = "0";
            // 
            // AddPaymentForm
            // 
            this.AcceptButton = this.AddPaymentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPaymentButton;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.PaymentCostBox);
            this.Controls.Add(this.PaymentCostLabel);
            this.Controls.Add(this.AddPaymentNameBox);
            this.Controls.Add(this.CancelPaymentButton);
            this.Controls.Add(this.AddPaymentButton);
            this.Controls.Add(this.NameLabelPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация об оплате";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabelPayment;
        private Button AddPaymentButton;
        private Button CancelPaymentButton;
        private TextBox AddPaymentNameBox;
        private Label PaymentCostLabel;
        private TextBox PaymentCostBox;
    }
}