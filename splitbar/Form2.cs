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
using System.Configuration;


namespace splitbar
{
    public partial class Form2 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["GMS_DAYAGEntities"].ConnectionString;

        // יצירת חיבור לבסיס הנתונים
       

        public Form2()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            { 

                try
                {
                    int.TryParse(fromQutTextBox.Text, out int fromQut);
                    int.TryParse(toQutTextBox.Text, out int toQut);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName= "Weight", FromPosition =fromQut, ToPosition= toQut };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                      MessageBox.Show("add Weight");


                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {

                try
                {
                    int.TryParse(fromQutTextBox.Text, out int fromSKU);
                    int.TryParse(toQutTextBox.Text, out int toSKU);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName = "Makat", FromPosition = fromSKU, ToPosition = toSKU };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                        MessageBox.Show("add Makat");


            }
            catch (Exception ex)
            {
                // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
            }
                }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {

                try
                {
                    int.TryParse(fromQutTextBox.Text, out int fromDate);
                    int.TryParse(toQutTextBox.Text, out int toDate);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName = "SlaughterDate", FromPosition = fromDate, ToPosition = toDate };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                    MessageBox.Show("add SlaughterDate");


   
                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {

                try
                {
                    int.TryParse(fromQutTextBox.Text, out int fromSupplier);
                    int.TryParse(toQutTextBox.Text, out int toSupplier);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName = "Supplier", FromPosition = fromSupplier, ToPosition = toSupplier };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                    MessageBox.Show("add Supplier");


                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {

                try
                {
                    int.TryParse(fromQutTextBox.Text, out int fromStock);
                    int.TryParse(toQutTextBox.Text, out int toStock);
                    BarcodePartsTBL bt = new BarcodePartsTBL() { PartName = "Stock", FromPosition = fromStock, ToPosition = toStock };
                    connection.BarcodePartsTBL.Add(bt);
                    connection.SaveChanges();
                    MessageBox.Show("add Stock");


                

                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }

        }
    }
}
