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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            custCategory.Text = "Select Category";
            custVisitDay.Text = "Select Day";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //clears text fields
        private void button4_Click(object sender, EventArgs e)
        {
            custAddress.Text = "";
            custCategory.Text = "Select Category";
            custName.Text = "";
            custPhone.Text = "";
            custNumber.Text = "";
            custInTime.Text = "";
            custOutTime.Text = "";
            custTicketRate.Text = "";
            custTotalPayment.Text = "";
            custVisitDate.Text = "";
            custVisitDay.Text = "Select Day";
            custVisitTime.Text = "";
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        //logout button
        private void button1_Click(object sender, EventArgs e)
        {
            StaffLogin staffLogout = new StaffLogin();
            staffLogout.Show();
            this.Hide();
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

        //helps to select csv file
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            staffTicketViewTxt.Text = openFileDialog1.FileName;
            BindTicketData(staffTicketViewTxt.Text);
        }

        //binds ticket data
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
                staffTicketRateView.DataSource = dt;
            }

        }

        //binds customer data,
        //helps to import csv data
        private void BindCustomerData(string filePath)
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
                dataGridView4.DataSource = dt;
            }

        }

        //add customer details with ticket info
        private void button2_Click(object sender, EventArgs e)
        {

            if (custName.Text.Trim() == "" || custAddress.Text.Trim() == "" || custCategory.Text.Trim() == "Select Category" || custNumber.Text.Trim() == "" || custPhone.Text.Trim() == "" || custVisitDay.Text.Trim() == "Select Day" || custVisitTime.Text.Trim() == "" || custTicketRate.Text.Trim() == "" || custTotalPayment.Text.Trim() == "")
            {
                MessageBox.Show("Please do not leave empty field");
            }
            else
            {
                string FileName = @"customer.csv";
                if (!File.Exists(FileName)) { string HeaderText = "Name" + ", " + "Address" + ", " + "Category" + ", " + "No.of Visitors" + ", " + "Phone" + ", " + "Day" + ", " + "In time" + ", " + "Out time" + ", " + "Total Time" + ", " + "Rate" + ", " + "Total amount" + ", " + "Date" + Environment.NewLine; File.WriteAllText(FileName, HeaderText); }
                string customerDetails = custName.Text + ", " + custAddress.Text + ", " + custCategory.Text + ", " + custNumber.Text + ", " + custPhone.Text + ", " + custVisitDay.Text + ", " + custInTime.Text + ", " + custOutTime.Text + ", " + custVisitTime.Text + ", " + custTicketRate.Text + ", " + custTotalPayment.Text + ", " + custVisitDate.Text + "\n"; File.AppendAllText(FileName, customerDetails); MessageBox.Show("Data Inserted");
            }
        }

        //view customer details
        private void button5_Click(object sender, EventArgs e)
        {
            staffViewCustomerOpenDialog.ShowDialog();
            staffViewCustDetail.Text = staffViewCustomerOpenDialog.FileName;
            BindCustomerData(staffViewCustDetail.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //extracts csv file of daily report
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
                staffDailyReportView.DataSource = dt;
            }

        }

        //opens file explorer to choose file
        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            staffDailyReportViewTxt.Text = openFileDialog2.FileName;
            BindDailyReportData(staffDailyReportViewTxt.Text);
        }

        private void custCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void custNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //checks for invalid character input
        private void custNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void custPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide phone number in numeric form.");
            }
        }

        private void custTicketRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please provide rate in numeric form.");
            }
        }

        private void custVisitTime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void custVisitTime_TextChanged(object sender, EventArgs e)
        {

        }

        //deletes millisecond
        private void custVisitTime_Click(object sender, EventArgs e)
        {
            TimeSpan time_differ = this.custOutTime.Value - this.custInTime.Value;
            this.custVisitTime.Text = time_differ.ToString();
            string[] deleteMilliSec = custVisitTime.Text.Split('.');
            custVisitTime.Text = deleteMilliSec[0];
        }

        private void custTotalPayment_Click(object sender, EventArgs e)
        {

        }

        private void custTotalPayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_Click(object sender, EventArgs e)
        {

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

                        string data = "Day," + "Total People," + "Total Income" + "\nSunday," + peopleSundayCount + "," + moneySundayCount + "\nMonday," + peopleMondayCount + "," + moneyMondayCount + "\nTuesday," + peopleTuesdayCount + "," + moneyTuesdayCount + "\nWednesday," + peopleWednesdayCount + "," + moneyWednesdayCount + "\nThursday," + peopleThursdayCount + "," + moneyThursdayCount + "\nFriday," + peopleFridayCount + "," + moneyFridayCount + "\nSaturday," + peopleSaturdayCount + "," + moneySaturdayCount;
                        sw.WriteLine(data);

                    }
                }
            }
            MessageBox.Show("Weekly Report created sucessfully.", "Sucess");
        }

        //generates chart
        private void button9_Click_1(object sender, EventArgs e)
        {
            string[] weeklyData = File.ReadAllLines(@"weeklyreport.csv");
            if (weeklyData.Length > 0)
            {

                for (int i = 1; i < weeklyData.Length; i++)
                {
                    string[] Words = weeklyData[i].Split(',');
                    string chart_day = Words[0];
                    string chart_numberofvisitors = Words[1];
                    string chart_totalearning = Words[2];
                    this.chart1.Series["no_of_visitor"].Points.AddXY(chart_day, chart_numberofvisitors);
                    this.chart2.Series["earning"].Points.AddXY(chart_day, chart_totalearning);
                }
            }
        }

        //reads data from csv
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
                staffWeeklyReportView.DataSource = dt;
            }

        }

        //chooses file to read data
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            staffWeeklyReportViewTxt.Text = openFileDialog3.FileName;
            BindWeeklyReportData(staffWeeklyReportViewTxt.Text);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //sort data
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortOption.SelectedIndex == 0)
            {
                staffWeeklyReportView.Sort(staffWeeklyReportView.Columns[2], ListSortDirection.Ascending);
            }
            else if(sortOption.SelectedIndex == 1)
            {
                staffWeeklyReportView.Sort(staffWeeklyReportView.Columns[1], ListSortDirection.Ascending);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void staffWeeklyReportView_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}


