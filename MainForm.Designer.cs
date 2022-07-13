namespace Cookie_Master
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.AddPaymentButton = new System.Windows.Forms.Button();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.MainLabel = new System.Windows.Forms.Label();
            this.DeleteWorkerButton = new System.Windows.Forms.Button();
            this.RefreshDataButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(368, 58);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(220, 35);
            this.AddWorkerButton.TabIndex = 0;
            this.AddWorkerButton.Text = "Добавить сотрудника";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Location = new System.Drawing.Point(368, 140);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(220, 35);
            this.AddPurchaseButton.TabIndex = 1;
            this.AddPurchaseButton.Text = "Добавить покупку печенья";
            this.AddPurchaseButton.UseVisualStyleBackColor = true;
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // AddPaymentButton
            // 
            this.AddPaymentButton.Location = new System.Drawing.Point(368, 181);
            this.AddPaymentButton.Name = "AddPaymentButton";
            this.AddPaymentButton.Size = new System.Drawing.Size(220, 35);
            this.AddPaymentButton.TabIndex = 2;
            this.AddPaymentButton.Text = "Добавить оплату долга";
            this.AddPaymentButton.UseVisualStyleBackColor = true;
            this.AddPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Location = new System.Drawing.Point(12, 35);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.ReadOnly = true;
            this.MainDataGrid.RowTemplate.Height = 25;
            this.MainDataGrid.Size = new System.Drawing.Size(350, 272);
            this.MainDataGrid.TabIndex = 3;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(12, 4);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(185, 21);
            this.MainLabel.TabIndex = 6;
            this.MainLabel.Text = "Таблица сотрудников:";
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.Location = new System.Drawing.Point(368, 99);
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.Size = new System.Drawing.Size(220, 35);
            this.DeleteWorkerButton.TabIndex = 9;
            this.DeleteWorkerButton.Text = "Удалить сотрудника";
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.Location = new System.Drawing.Point(368, 222);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(220, 35);
            this.RefreshDataButton.TabIndex = 11;
            this.RefreshDataButton.Text = "Обновить данные";
            this.RefreshDataButton.UseVisualStyleBackColor = true;
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(368, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(220, 23);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.Location = new System.Drawing.Point(298, 4);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(64, 21);
            this.SearchLabel.TabIndex = 13;
            this.SearchLabel.Text = "Поиск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "By Nikita Gavrilov 2022©";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RefreshDataButton);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.AddPaymentButton);
            this.Controls.Add(this.AddPurchaseButton);
            this.Controls.Add(this.AddWorkerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cookie Master V1.0";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddWorkerButton;
        private Button AddPurchaseButton;
        private Button AddPaymentButton;
        private DataGridView MainDataGrid;
        private Label MainLabel;
        private Button DeleteWorkerButton;
        private Button RefreshDataButton;
        private TextBox SearchBox;
        private Label SearchLabel;
        private Label label1;
    }
}