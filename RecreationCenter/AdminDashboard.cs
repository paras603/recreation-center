using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            adminComboBox.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogout = new AdminLogin();
            adminLogout.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                if (adminComboBox.Text.Trim() == "" && price1txt.Text.Trim() == "" && price2txt.Text.Trim() == "" && price3txt.Text.Trim() == "" && price4txt.Text.Trim() == "" && wholePricetxt.Text.Trim() == "")
                {
                    MessageBox.Show("Error, Empty field found");
                }
                else if (price1txt.Text.Trim() == "")
                {
                    MessageBox.Show("Enter price for 1 hour");
                    price1txt.Focus();
                }
                else if (price2txt.Text.Trim() == "")
                {
                    MessageBox.Show("Enter price for 2 hour");
                    price2txt.Focus();
                }
                else if (price3txt.Text.Trim() == "")
                {
                    MessageBox.Show("Enter price for 3 hour");
                    price3txt.Focus();
                }
                else if (price4txt.Text.Trim() == "")
                {
                    MessageBox.Show("Enter price for 4 hour");
                    price4txt.Focus();
                }
                else if (wholePricetxt.Text.Trim() == "")
                {
                    MessageBox.Show("Enter price for whole day");
                    wholePricetxt.Focus();
                }
                else
                {
                //stores ticket in new csv file
                    string FileName = @"ticket.csv";
                    if (!File.Exists(FileName)) { string HeaderText = "Ticket category" + ", " + "1 hour rate" + ", " + "2 hours rate" + ", " + "3 hours rate" + ", " + "4 hours rate" + ", " + "Whole day rate" + Environment.NewLine; File.WriteAllText(FileName, HeaderText); }
                    string clientDetails = adminComboBox.Text + "," + price1txt.Text + ", " + price2txt.Text + ", " + price3txt.Text + ", " + "" + price4txt.Text + ", " + wholePricetxt.Text + "\n"; File.AppendAllText(FileName, clientDetails); MessageBox.Show("Data Inserted");
                }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //disables key pressed except numeric key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        //helps to read line of csv file
        private void BindTicketData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                adminTicketView.DataSource = dt;
            }

        }

        //allows user to choose file
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            adminViewTicket.Text = openFileDialog1.FileName;
            BindTicketData(adminViewTicket.Text);
        }

        //clears text fields
        private void button5_Click(object sender, EventArgs e)
        {
            price1txt.Text = "";
            price2txt.Text = "";
            price3txt.Text = "";
            price4txt.Text = "";
            wholePricetxt.Text = "";
            adminComboBox.SelectedIndex = 0;
        }

        private void adminComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //method for generating daily report
        private void button6_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"customer.csv");
            int childCount = 0;
            int adultCount = 0;
            int group5Count = 0;
            int group10Count = 0;
            int group15Count = 0;


            DateTime date = DateTime.Now;
            string currentDate = date.ToString(" yyyy-MM-dd");

            if (lines.Length > 0)
            {
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');

                    if (currentDate.Equals(dataWords[11]))
                    {
                        if (dataWords[2].Equals(" Child (5-12)"))
                        {
                            childCount += int.Parse(dataWords[3]);
                        }
                        else if (dataWords[2].Equals(" Adult > 12"))
                        {
                            adultCount += int.Parse(dataWords[3]);
                        }
                        else if (dataWords[2].Equals(" Group of 5"))
                        {
                            group5Count += int.Parse(dataWords[3]);
                        }
                        else if (dataWords[2].Equals(" Group of 10"))
                        {
                            group10Count += int.Parse(dataWords[3]);
                        }
                        else if (dataWords[2].Equals(" Group of 15"))
                        {
                            group15Count += int.Parse(dataWords[3]);
                        }
                    }
                }

                string filename = @"dailyreport.csv";
                if (File.Exists(filename))
                {
                    string[] reportWords = File.ReadAllLines(filename);
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        if (reportWords.Length != 0)
                        {
                            string data = "Category," + "Total People," + "Date" + "\nChild (5-12)," + childCount + "," + currentDate + "\n(Adult >12)," + adultCount + "," + currentDate + "\n(Group 5)," + group5Count + "," + currentDate + "\n(Group 10)," + group10Count + "," + currentDate + "\n(Group 15)," + group15Count + "," + currentDate;
                            sw.WriteLine(data);
                        }
                        else
                        {
                            string data = "Child (5-12)," + childCount + "," + currentDate + "\n(Adult >12)," + adultCount + "," + currentDate + "\n(Group 5)," + group5Count + "," + currentDate + "\n(Group 10)," + group10Count + "," + currentDate + "\n(Group 15)," + group15Count + "," + currentDate;
                            sw.WriteLine(data);
                        }
                    }
                }
                else
                {
                    var myFile = File.Create(filename);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        string data = "Category," + "Total People," + "Date" + "\nChild (5-12)," + childCount + "," + currentDate + "\n(Adult >12)," + adultCount + "," + currentDate + "\n(Group 5)," + group5Count + "," + currentDate + "\n(Group 10)," + group10Count + "," + currentDate + "\n(Group 15)," + group15Count + "," + currentDate;
                        sw.WriteLine(data);

                    }
                }
                MessageBox.Show("Daily Report created sucessfully.", "Sucess");
            }
        }

        //binding data for daily report
        private void BindDailyReportData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                adminDailyReportView.DataSource = dt;
            }

        }

        //helps to choose csv file
        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            adminDailyReportViewTxt1.Text = openFileDialog2.FileName;
            BindDailyReportData(adminDailyReportViewTxt1.Text);
        }

        //method for generating weekly report
        private void button7_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"customer.csv");
            int peopleSundayCount = 0;
            int peopleMondayCount = 0;
            int peopleTuesdayCount = 0;
            int peopleWednesdayCount = 0;
            int peopleThursdayCount = 0;
            int peopleFridayCount = 0;
            int peopleSaturdayCount = 0;

            double moneySundayCount = 0;
            double moneyMondayCount = 0;
            double moneyTuesdayCount = 0;
            double moneyWednesdayCount = 0;
            double moneyThursdayCount = 0;
            double moneyFridayCount = 0;
            double moneySaturdayCount = 0;

            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    string dataDate = dataWords[11];

                    DateTime date = DateTime.Now;
                    string presentDate = date.ToString(" yyyy-MM-dd");

                    DateTime initialDate = Convert.ToDateTime(dataDate);
                    DateTime finalDate = Convert.ToDateTime(presentDate);

                    double diff = (finalDate - initialDate).TotalDays;

                    if (diff <= 7)
                    {
                        if (dataWords[5].Equals(" Sunday"))
                        {
                            peopleSundayCount += int.Parse(dataWords[3]);
                            moneySundayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Monday"))
                        {
                            peopleMondayCount += int.Parse(dataWords[3]);
                            moneyMondayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Tuesday"))
                        {
                            peopleTuesdayCount += int.Parse(dataWords[3]);
                            moneyTuesdayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Wednesday"))
                        {
                            peopleWednesdayCount += int.Parse(dataWords[3]);
                            moneyWednesdayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Thursday"))
                        {
                            peopleThursdayCount += int.Parse(dataWords[3]);
                            moneyThursdayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Friday"))
                        {
                            peopleFridayCount += int.Parse(dataWords[3]);
                            moneyFridayCount += double.Parse(dataWords[10]);
                        }
                        else if (dataWords[5].Equals(" Saturday"))
                        {
                            peopleSaturdayCount += int.Parse(dataWords[3]);
                            moneySaturdayCount += double.Parse(dataWords[10]);
                        }
                    }
                }

                string filename = @"weeklyreport.csv";
                if (File.Exists(filename))
                {
                    string[] reportWords = File.ReadAllLines(filename);
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        if (reportWords.Length != 0)
                        {
                            string data = "Day," + "Total People," + "Total Income" + "\nSunday," + peopleSundayCount + "," + moneySundayCount + "\nMonday," + peopleMondayCount + "," + moneyMondayCount + "\nTuesday," + peopleTuesdayCount + "," + moneyTuesdayCount + "\nWednesday," + peopleWednesdayCount + "," + moneyWednesdayCount + "\nThursday," + peopleThursdayCount + "," + moneyThursdayCount + "\nFriday," + peopleFridayCount + "," + moneyFridayCount + "\nSaturday," + peopleSaturdayCount + "," + moneySaturdayCount;
                            sw.WriteLine(data);
                        }
                        else
                        {
                            string data = "Sunday," + peopleSundayCount + "," + moneySundayCount + "\nMonday," + peopleMondayCount + "," + moneyMondayCount + "\nTuesday," + peopleTuesdayCount + "," + moneyTuesdayCount + "\nWednesday," + peopleWednesdayCount + "," + moneyWednesdayCount + "\nThursday," + peopleThursdayCount + "," + moneyThursdayCount + "\nFriday," + peopleFridayCount + "," + moneyFridayCount + "\nSaturday," + peopleSaturdayCount + "," + moneySaturdayCount;
                            sw.WriteLine(data);
                        }
                    }
                }
                else
                {
                    var myFile = File.Create(filename);
                    myFile.Close();

                    using (StreamWriter sw = new StreamWriter(filename))
                    {

                        string data = "Day," + "Total People," + "Total Income" + "\nSunday," + peopleSundayCount + "," + moneySundayCount + "\nMonday," + peopleMondayCount  + "," + moneyMondayCount + "\nTuesday," + peopleTuesdayCount + "," + moneyTuesdayCount + "\nWednesday," + peopleWednesdayCount + "," + moneyWednesdayCount + "\nThursday," + peopleThursdayCount + "," + moneyThursdayCount + "\nFriday," + peopleFridayCount + "," + moneyFridayCount + "\nSaturday," + peopleSaturdayCount + "," + moneySaturdayCount;
                        sw.WriteLine(data);

                    }
                }
            }
            MessageBox.Show("Weekly Report created sucessfully.", "Sucess");
        }

        //sort code
        private void sortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminSortOption.SelectedIndex == 0)
            {
                adminWeeklyReportView.Sort(adminWeeklyReportView.Columns[2], ListSortDirection.Ascending);
            }
            else if (adminSortOption.SelectedIndex == 1)
            {
                adminWeeklyReportView.Sort(adminWeeklyReportView.Columns[1], ListSortDirection.Ascending);
            }
        }

        //bind weekly report data
        private void BindWeeklyReportData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                adminWeeklyReportView.DataSource = dt;
            }

        }

        //helps to choose csv file
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            adminViewReportTxt2.Text = openFileDialog3.FileName;
            BindWeeklyReportData(adminViewReportTxt2.Text);
        }

        //generates chart
        private void button9_Click(object sender, EventArgs e)
        {
            string[] weeklyReport = File.ReadAllLines(@"weeklyreport.csv");
            if (weeklyReport.Length > 0)
            {

                for (int i = 1; i < weeklyReport.Length; i++)
                {
                    string[] Data = weeklyReport[i].Split(',');
                    string chart = Data[0];
                    string visitorsChart = Data[1];
                    string totalEarningChart = Data[2];
                    this.chart1.Series["no_of_visitor"].Points.AddXY(chart, visitorsChart);
                    this.chart2.Series["earning"].Points.AddXY(chart, totalEarningChart);
                }

            }
        }
    }
    
}
