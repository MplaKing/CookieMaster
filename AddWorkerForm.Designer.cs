namespace Cookie_Master
{
    partial class AddWorkerForm
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
            this.NameLabelWorkers = new System.Windows.Forms.Label();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.CancelWorkerButton = new System.Windows.Forms.Button();
            this.AddWorkerNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabelWorkers
            // 
            this.NameLabelWorkers.AutoSize = true;
            this.NameLabelWorkers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabelWorkers.Location = new System.Drawing.Point(26, 24);
            this.NameLabelWorkers.Name = "NameLabelWorkers";
            this.NameLabelWorkers.Size = new System.Drawing.Size(143, 21);
            this.NameLabelWorkers.TabIndex = 0;
            this.NameLabelWorkers.Text = "Имя сотрудника:";
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(26, 61);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(150, 35);
            this.AddWorkerButton.TabIndex = 2;
            this.AddWorkerButton.Text = "Добавить";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // CancelWorkerButton
            // 
            this.CancelWorkerButton.Location = new System.Drawing.Point(202, 61);
            this.CancelWorkerButton.Name = "CancelWorkerButton";
            this.CancelWorkerButton.Size = new System.Drawing.Size(150, 35);
            this.CancelWorkerButton.TabIndex = 3;
            this.CancelWorkerButton.Text = "Отмена";
            this.CancelWorkerButton.UseVisualStyleBackColor = true;
            this.CancelWorkerButton.Click += new System.EventHandler(this.CancelWorkerButton_Click);
            // 
            // AddWorkerNameBox
            // 
            this.AddWorkerNameBox.Location = new System.Drawing.Point(202, 22);
            this.AddWorkerNameBox.Name = "AddWorkerNameBox";
            this.AddWorkerNameBox.Size = new System.Drawing.Size(150, 23);
            this.AddWorkerNameBox.TabIndex = 4;
            // 
            // AddWorkerForm
            // 
            this.AcceptButton = this.AddWorkerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelWorkerButton;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.AddWorkerNameBox);
            this.Controls.Add(this.CancelWorkerButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.NameLabelWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о сотруднике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabelWorkers;
        private Button AddWorkerButton;
        private Button CancelWorkerButton;
        private TextBox AddWorkerNameBox;
    }
}