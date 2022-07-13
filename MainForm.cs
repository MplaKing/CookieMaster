using System.Data;
using System.Data.SqlClient;

namespace Cookie_Master
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainForm : Form
    {

        DataBaseFirstCon CookieFirst = new DataBaseFirstCon();
        
        DataBase CookieDataBase = new DataBase();

        public void CreateAll()
        {
            CookieFirst.ConnectionOpen();
            
            var dataBaseCreation = $"IF EXISTS (SELECT * FROM sys.databases WHERE name = 'CookieMasterDB') BEGIN DROP DATABASE CookieMasterDB; END; CREATE DATABASE CookieMasterDB";
            SqlCommand dbCreateQuerry = new SqlCommand(dataBaseCreation, CookieFirst.ConnectionGet());
            dbCreateQuerry.ExecuteNonQuery();

            var tableCreation = $"USE CookieMasterDB; DROP TABLE IF EXISTS WorkersData; CREATE TABLE WorkersData (wname varchar(50) NOT NULL, wbalance int NOT NULL, isbuyer bit NOT NULL)";
            SqlCommand tableCreateQuerry = new SqlCommand(tableCreation, CookieFirst.ConnectionGet());
            tableCreateQuerry.ExecuteNonQuery();

            CookieFirst.ConnectionClose();
        }
        
        public MainForm()
        {
            CreateAll();
            InitializeComponent();
        }


        private void ColumnCreation()
        {
            MainDataGrid.Columns.Add("worker_name", "Имя сотрудника");
            MainDataGrid.Columns.Add("worker_balance", "Баланс");
            MainDataGrid.Columns.Add("IsBuyer", "WorkerState");
            MainDataGrid.Columns.Add("IsNew", "RowState");

            MainDataGrid.Columns[0].Width = 155;
            MainDataGrid.Columns[1].Width = 150;
            MainDataGrid.Columns[2].Visible = false;
            MainDataGrid.Columns[3].Visible = false;
        }

        private void RowRead(DataGridView dataGrid, IDataRecord dataRecord)
        {
            dataGrid.Rows.Add(dataRecord.GetString(0), dataRecord.GetInt32(1), dataRecord.GetBoolean(2), RowState.ModifiedNew);
        }

        private void DataUpdater(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string updater = $"SELECT * FROM WorkersData";

            SqlCommand performUpdate = new SqlCommand(updater, CookieDataBase.ConnectionGet());

            CookieDataBase.ConnectionOpen();

            SqlDataReader reader = performUpdate.ExecuteReader();

            while (reader.Read())
            {
                RowRead(dataGrid, reader);
            }

            reader.Close();

            CookieDataBase.ConnectionClose();
        }

        private void Search(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string searcher = $"SELECT * FROM WorkersData WHERE CONCAT (wname, wbalance) LIKE '%" + SearchBox.Text + "%'";

            SqlCommand performSearch = new SqlCommand(searcher, CookieDataBase.ConnectionGet());

            CookieDataBase.ConnectionOpen();

            SqlDataReader reader = performSearch.ExecuteReader();

            while (reader.Read())
            {
                RowRead(dataGrid, reader);
            }

            reader.Close();

            CookieDataBase.ConnectionClose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ColumnCreation();
            DataUpdater(MainDataGrid);
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.Show();
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            AddPurchaseForm addPurchaseForm = new AddPurchaseForm();
            addPurchaseForm.Show();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            AddPaymentForm addPaymentForm = new AddPaymentForm();
            addPaymentForm.Show();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            DataUpdater(MainDataGrid);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Search(MainDataGrid);
        }

        private void RowDelete()
        {
            int index = MainDataGrid.CurrentCell.RowIndex;

            MainDataGrid.Rows[index].Visible = false;

            if (MainDataGrid.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                MainDataGrid.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }

            MainDataGrid.Rows[index].Cells[3].Value = RowState.Deleted;

            CookieDataBase.ConnectionOpen();

            for (index = 0; index < MainDataGrid.Rows.Count; index++)
            {
                if (MainDataGrid.Rows[index].Cells[3].Value != null)
                {
                    var rowState = (RowState)MainDataGrid.Rows[index].Cells[3].Value;

                    if (rowState == RowState.Existed)
                    {
                        continue;
                    }

                    if (rowState == RowState.Deleted)
                    {
                        var name = Convert.ToString(MainDataGrid.Rows[index].Cells[0].Value);
                        var deleteQuerry = $"DELETE FROM WorkersData WHERE wname = '{name}'";

                        SqlCommand command = new SqlCommand(deleteQuerry, CookieDataBase.ConnectionGet());
                        command.ExecuteNonQuery();
                    }
                }
            }

            CookieDataBase.ConnectionClose();
        }

        private void RowUpdate()
        {
            CookieDataBase.ConnectionOpen();

            for (int index = 0; index < MainDataGrid.Rows.Count; index++)
            {
                if (MainDataGrid.Rows[index].Cells[3].Value != null)
                {
                    var rowState = (RowState)MainDataGrid.Rows[index].Cells[3].Value;

                    if (rowState == RowState.Existed)
                    {
                        continue;
                    }

                    if (rowState == RowState.Deleted)
                    {
                        var name = Convert.ToString(MainDataGrid.Rows[index].Cells[0].Value);
                        var deleteQuerry = $"DELETE FROM WorkersData WHERE wname = '{name}'";

                        SqlCommand command = new SqlCommand(deleteQuerry, CookieDataBase.ConnectionGet());
                        command.ExecuteNonQuery();
                    }
                }
            }

            CookieDataBase.ConnectionClose();
        }

        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            if (MainDataGrid.CurrentCell != null)
            {
                RowDelete();
            }

            MessageBox.Show("Сотрудник успешно удален.", "Дело сделано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            RowUpdate();

            MessageBox.Show("Данные успешно сохранены.", "Дело сделано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            DataUpdater(MainDataGrid);
        }
    }
}