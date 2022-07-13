using System.Data.SqlClient;

namespace Cookie_Master
{
    public partial class AddPaymentForm : Form
    {
        
        DataBase CookieDataBase = new DataBase();
        
        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void CancelPaymentButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPaymentButton_Click_1(object sender, EventArgs e)
        {
            CookieDataBase.ConnectionOpen();

            string returnerName = AddPaymentNameBox.Text;
            int returnDebt;

            var findReturner = $"SELECT COUNT(*) FROM WorkersData WHERE wname='{returnerName}'";
            SqlCommand commandFind = new SqlCommand(findReturner, CookieDataBase.ConnectionGet());
            int isThereAReturner = (int)commandFind.ExecuteScalar();

            if (isThereAReturner == 1)
            {
                if (Int32.TryParse(PaymentCostBox.Text, out returnDebt))
                {
                    var countQuerry = $"SELECT COUNT(*) FROM WorkersData";
                    SqlCommand commandCount = new SqlCommand(countQuerry, CookieDataBase.ConnectionGet());
                    int returnercount = (int)commandCount.ExecuteScalar();

                    if (returnercount < 1)
                    {
                        MessageBox.Show("У нас нет сотрудников, которые едят печенье.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (returnercount == 1)
                    {
                        MessageBox.Show("Печенье ест только один сотрудник, ему не нужно вести учет расходов.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        var findDebtValue = $"SELECT wbalance FROM WorkersData WHERE wname='{returnerName}'";
                        SqlCommand commandDebtValue = new SqlCommand(findDebtValue, CookieDataBase.ConnectionGet());
                        int debt = (int)commandDebtValue.ExecuteScalar();

                        if (Int32.Parse(PaymentCostBox.Text) > -debt)
                        {
                            MessageBox.Show("Вы ввели значение больше, чем составляет долг.", "Будьте внимательнее!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            var returnDebtQuerry = $"UPDATE WorkersData SET wbalance=wbalance+{returnDebt} WHERE wname='{returnerName}'";
                            SqlCommand commandReturnDebt = new SqlCommand(returnDebtQuerry, CookieDataBase.ConnectionGet());
                            commandReturnDebt.ExecuteNonQuery();

                            var pieceOfDebtQuerry = $"UPDATE WorkersData SET wbalance=wbalance-{returnDebt} WHERE isbuyer=1";
                            SqlCommand commandPieceOfDebt = new SqlCommand(pieceOfDebtQuerry, CookieDataBase.ConnectionGet());
                            commandReturnDebt.ExecuteNonQuery();
                        }

                        MessageBox.Show("Возврат произведен успешно!", "Дело сделано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Close();
                }

                else
                {
                    MessageBox.Show("Необходимо задать корректную сумму возврата.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (isThereAReturner < 1)
            {
                MessageBox.Show("Данный сотрудник не найден, попробуйте еще раз.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("В списке более 1 сотрудника с таким именем, введите более полное имя.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CookieDataBase.ConnectionClose();
        }
    }
}
