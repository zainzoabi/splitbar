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
        SqlConnection co = new SqlConnection(@"data source=199.203.140.245,41433;initial catalog=GMS_DAYAG;user id=sa;password=Abulele1972;MultipleActiveResultSets=True;");

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
        private void button4_Click_1(object sender, EventArgs e)
        {
           
                string code = codeTextBox.Text;
                int fromQut = int.Parse(fromQutTextBox.Text);
                int toQut = int.Parse(toQutTextBox.Text);
                int fromSKU = int.Parse(fromSKUTextBox.Text);
                int toSKU = int.Parse(toSKUTextBox.Text);
                int fromDate = int.Parse(fromDateTextBox.Text);
                int toDate = int.Parse(toDateTextBox.Text);
                int fromStocknum = int.Parse(fromStocknumTextBox.Text);
                int toStocknum = int.Parse(toStocknumTextBox.Text);
               // bool ignoreStocknum = checkBox1.Checked;

            string[] codeArray = new string[4]; // נכון לגודל המערך

            GetSubstring(codeArray, code, fromQut, toQut, "Qut");
            GetSubstring(codeArray, code, fromSKU, toSKU, "SKU");
            GetSubstring(codeArray, code, fromDate, toDate, "Date");
            GetSubstring(codeArray, code, fromStocknum, toStocknum, "Stock");

           for(int i=0;i< codeArray.Length; i++)
            {
                string name = codeArray[i];
                string start = codeArray[i++];
                string end = codeArray[i+2];

                using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            { 

                try
                {
                    int.TryParse(name, out int fromstart);
                    int.TryParse(start, out int toend);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName= "Qut" , FromPosition = fromstart, ToPosition= toend };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                      MessageBox.Show("add Barcode Parts");


                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }

            }
        }

        private static void GetSubstring(string[] codeArray, string input, int startIndex, int endIndex, string PartName)
        {
            string substring = input.Substring(startIndex, endIndex - startIndex + 1);

            // הוסף את התת-מחרוזת למערך
            int index = Array.IndexOf(codeArray, null);
            if (index != -1)
            {
                codeArray[index] = PartName + ": " + substring;
            }
        }
    


    // בניית שאילתת החיפוש בהתאם לפרמטרים שהתקבלו
    //  string sqlQuery = "SELECT * FROM BarcodePartsTBL WHERE  ";




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
