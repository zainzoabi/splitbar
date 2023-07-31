using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace splitbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            // קבלת הערכים מה-TextBoxes והצ'קבוקס
            string code = codeTextBox.Text;
            int fromQut = int.Parse(fromQutTextBox.Text);
            int toQut = int.Parse(toQutTextBox.Text);
            int fromSKU = int.Parse(fromSKUTextBox.Text);
            int toSKU = int.Parse(toSKUTextBox.Text);
            int fromDate = int.Parse(fromDateTextBox.Text);
            int toDate = int.Parse(toDateTextBox.Text);
            int fromStocknum = int.Parse(fromStocknumTextBox.Text);
            int toStocknum = int.Parse(toStocknumTextBox.Text);
            bool ignoreStocknum = checkBox1.Checked;

            // בניית מערך שמכיל את התווים מהקוד
            string[] codeArray = new string[]
            {
        GetSubstring(code, fromQut, toQut),          // Qut
        GetSubstring(code, fromSKU, toSKU),          // SKU
        GetSubstring(code, fromDate, toDate),        // Date
        GetSubstring(code, fromStocknum, toStocknum) // Stock
            };
             string GetSubstring(string input, int startIndex, int length)
            {
                if (startIndex >= 0 && length > 0 && input.Length >= startIndex + length)
                {
                    return input.Substring(startIndex, length);
                }
                return string.Empty;
            }




            // בניית שאילתת החיפוש בהתאם לפרמטרים שהתקבלו
            string sqlQuery = "SELECT * FROM YourTable WHERE Code = @code AND Quantity BETWEEN @fromQut AND @toQut " +
                              "AND SKU BETWEEN @fromSKU AND @toSKU AND Date BETWEEN @fromDate AND @toDate ";

            if (!ignoreStocknum)
            {
                sqlQuery += "AND StockNum BETWEEN @fromStocknum AND @toStocknum ";
            }

            // כמובן שכדאי להתאים את שמות העמודות והטבלה לבסיס הנתונים שלך

            using (SqlConnection connection = new SqlConnection("Your_Connection_String"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // הגדרת הפרמטרים של השאילתה
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@fromQut", fromQut);
                    command.Parameters.AddWithValue("@toQut", toQut);
                    command.Parameters.AddWithValue("@fromSKU", fromSKU);
                    command.Parameters.AddWithValue("@toSKU", toSKU);
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    if (!ignoreStocknum)
                    {
                        command.Parameters.AddWithValue("@fromStocknum", fromStocknum);
                        command.Parameters.AddWithValue("@toStocknum", toStocknum);
                    }

                    // ביצוע השאילתה ועיבוד התוצאות
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // כאן תוכל לעשות משהו עם התוצאות, לדוגמה להציגם בטבלה או ברשימת בחירה
                    // dataGridView1.DataSource = dataTable;
                    // listBox1.DataSource = dataTable;
                    // וכדומה...
                }
            }
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = "שם_הטבלה"; // השלם כאן את שם הטבלה בבסיס הנתונים שלך

            string connectionString = "Data Source=שם_שרת;Initial Catalog=שם_בסיס_הנתונים;Integrated Security=True"; // השלם כאן את פרטי החיבור לבסיס הנתונים

            string sql = string.Format("SELECT * FROM {0}", tableName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // כאן תוכל לעשות משהו עם הנתונים, לדוגמה להציגם בטבלה או ברשימת בחירה (CheckedListBox)
                    // checkedListBox1.DataSource = dataTable;
                    // checkedListBox1.DisplayMember = "שם העמודה להצגה";
                    // וכדומה...
                }
                catch (Exception ex)
                {
                    // טיפול בשגיאות במידה ויש
                    MessageBox.Show("שגיאה בעת טעינת הנתונים: " + ex.Message);
                }
            }
        }

    }
}
