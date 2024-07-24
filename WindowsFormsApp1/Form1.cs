using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DayInWeek = this.Text.ToString();
        }

        private void dayInMmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DayInMonth = this.Text.ToString();
        }

        private void month1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Month = this.Text.ToString();
        }

        private void yaer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Yaer = this.Text.ToString();
        }


        XDocument doc = XDocument.Load("XMLFile1.xml");

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Root.Add
                (new XElement("quest",
                    new XElement("DayInWeek", day.Text),
                    new XElement("dayInMonth", dayInMmonth.Text),
                    new XElement("Month", month1.Text),
                    new XElement("Yaer", yaer.Text),
                    new XElement("res", $"ב{day.Text} {dayInMmonth.Text} לחודש {month1.Text} בשנת {yaer.Text}")
                    )
                );
            MessageBox.Show($"ב{day.Text} {dayInMmonth.Text} לחודש {month1.Text} בשנת {yaer.Text}");
            doc.Save("XMLFile1.xml");
            
            
        }

        // Add the selected value to the XML document
        //doc.Element("Values").Add(new XElement("Value", selectedValue));

        //// Save the document to a file
        //doc.Save("comboBoxValues.xml");

        //MessageBox.Show("Value saved to XML file.");
    }

    }


