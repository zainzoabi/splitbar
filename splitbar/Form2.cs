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

        private async void button1_Click_1(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            button1_Click(sender, e);

            await Task.Delay(1000);
            button2_Click(sender, e);

            await Task.Delay(1000);
            button3_Click(sender, e);

            await Task.Delay(1000);
            button4_Click(sender, e);

            await Task.Delay(1000);
            button5_Click(sender, e);
        }

        private void DeleteData(string partName)
        {
            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {
                try
                {
                    var partsToDelete = connection.BarcodePartsTBL
                        .Where(bt => bt.PartName == partName)
                        .ToList();

                    if (partsToDelete.Count > 0)
                    {
                        connection.BarcodePartsTBL.RemoveRange(partsToDelete);
                        connection.SaveChanges();
                        MessageBox.Show("Deleted " + partName);
                    }
                    else
                    {
                        MessageBox.Show("No data found to delete for " + partName);
                    }
                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }
        }

        // השתמש בפונקציה הבאה כדי למחוק נתונים מהטבלה במקום להוסיף
        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] myArray = new string[4];

            // השמה של ערכים לתאי המערך
            myArray[0] = "Weight";
            myArray[1] = "Makat";
            myArray[2] = "SlaughterDate";
            myArray[3] = "Supplier";
            while (i <= myArray.Length)
             {
                string partNameToDelete = myArray[i]; // הגדר את שם המאפיין שברצונך למחוק
                DeleteData(partNameToDelete);

            }

        }
        private void UpdateData(string partName, int newFromPosition, int newToPosition)
        {
            using (GMS_DAYAGEntities connection = new GMS_DAYAGEntities())
            {
                try
                {
                    var partsToUpdate = connection.BarcodePartsTBL
                        .Where(bt => bt.PartName == partName)
                        .ToList();

                    if (partsToUpdate.Count > 0)
                    {
                        foreach (var part in partsToUpdate)
                        {
                            part.FromPosition = newFromPosition;
                            part.ToPosition = newToPosition;
                        }

                        connection.SaveChanges();
                        MessageBox.Show("Updated " + partName);
                    }
                    else
                    {
                        MessageBox.Show("No data found to update for " + partName);
                    }
                }
                catch (Exception ex)
                {
                    // במקרה של שגיאה, כדאי לטפל בה בהתאם לדרישות האפליקציה שלך
                    Console.WriteLine("שגיאה בהתחברות למסד הנתונים: " + ex.Message);
                }
            }
        }

        // השתמש בפונקציה הבאה כדי לעדכן נתונים במקום למחוק
        private void button10_Click(object sender, EventArgs e)
        {
            int newFromPosition = 100; // ערך חדש לשדה FromPosition
            int newToPosition = 200; // ערך חדש לשדה ToPosition

            string[] myArray = new string[4];

            // השמה של ערכים לתאי המערך
            myArray[0] = "Weight";
            myArray[1] = "Makat";
            myArray[2] = "SlaughterDate";
            myArray[3] = "Supplier";

            for (int i = 0; i < myArray.Length; i++)
            {
                string partNameToUpdate = myArray[i]; // הגדר את שם המאפיין שברצונך לעדכן
                UpdateData(partNameToUpdate, newFromPosition, newToPosition);
            }
        }

    }
}
