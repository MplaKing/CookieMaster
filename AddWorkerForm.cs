using System.Data.SqlClient;

namespace Cookie_Master
{
    public partial class AddWorkerForm : Form
    {

        DataBase CookieDataBase = new DataBase();

        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void CancelWorkerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            CookieDataBase.ConnectionOpen();

            var name = AddWorkerNameBox.Text;
            
            var addWorkerQuerry = $"INSERT INTO WorkersData (wname, wbalance, isbuyer) VALUES ('{name}', '0', '0')";
            SqlCommand command = new SqlCommand(addWorkerQuerry, CookieDataBase.ConnectionGet());
            command.ExecuteNonQuery();

            MessageBox.Show("Работник успешно добавлен.", "Дело сделано!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CookieDataBase.ConnectionClose();
            Close();
        }
    }
}
