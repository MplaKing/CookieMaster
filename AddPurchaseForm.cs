using System.Data.SqlClient;

namespace Cookie_Master
{
    public partial class AddPurchaseForm : Form
    {
        
        DataBase CookieDataBase = new DataBase();
        
        public AddPurchaseForm()
        {
            InitializeComponent();

            MessageBox.Show("При добавлении новой покупки, информация о старой будет очищена. Баланс всех сотрудников вернется к 0.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelPurchaseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            
            CookieDataBase.ConnectionOpen();

            string buyerName = AddPurchaseNameBox.Text;
            int cost;

            var findBuyer = $"SELECT COUNT(*) FROM WorkersData WHERE wname='{buyerName}'";
            SqlCommand commandFind = new SqlCommand(findBuyer, CookieDataBase.ConnectionGet());
            int isThereABuyer = (int)commandFind.ExecuteScalar();

            if (isThereABuyer == 1)
            {
                if (Int32.TryParse(PurchaseCostBox.Text, out cost))
                {   
                    
                    var countQuerry = $"SELECT COUNT(*) FROM WorkersData";
                    SqlCommand commandCount = new SqlCommand(countQuerry, CookieDataBase.ConnectionGet());
                    int eatercount = (int)commandCount.ExecuteScalar();

                    if (eatercount < 1)
                    {
                        MessageBox.Show("У нас нет сотрудников, которые едят печенье.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (eatercount == 1)
                    {
                        MessageBox.Show("Печенье ест только один сотрудник, ему не нужно вести учет расходов.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        var clearBuyer = $"UPDATE WorkersData SET isbuyer=0 WHERE isbuyer=1";
                        SqlCommand commandClearBuyer = new SqlCommand(clearBuyer, CookieDataBase.ConnectionGet());
                        commandClearBuyer.ExecuteNonQuery();
                        
                        var selectBuyer = $"UPDATE WorkersData SET isbuyer=1 WHERE wname='{buyerName}'";
                        SqlCommand commandSelectBuyer = new SqlCommand(selectBuyer, CookieDataBase.ConnectionGet());
                        commandSelectBuyer.ExecuteNonQuery();

                        var clearBalances = $"UPDATE WorkersData SET wbalance=0";
                        SqlCommand commandClearBalances = new SqlCommand(clearBalances, CookieDataBase.ConnectionGet());
                        commandClearBalances.ExecuteNonQuery();

                        var addDebtQuerry = $"UPDATE WorkersData SET wbalance=wbalance-({cost}/{eatercount})";
                        SqlCommand commandDebt = new SqlCommand(addDebtQuerry, CookieDataBase.ConnectionGet());
                        commandDebt.ExecuteNonQuery();

                        var addPurchaseQuerry = $"UPDATE WorkersData SET wbalance=wbalance+{cost} WHERE isbuyer=1";
                        SqlCommand commandPurchase = new SqlCommand(addPurchaseQuerry, CookieDataBase.ConnectionGet());
                        commandPurchase.ExecuteNonQuery();

                        MessageBox.Show("Покупка произведена успешно!", "Дело сделано!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Close();
                }

                else
                {
                    MessageBox.Show("Необходимо задать корректную цену.", "У нас проблема!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            else if (isThereABuyer < 1)
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
