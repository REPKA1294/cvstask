using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class data
        {
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }
            public string Column4 { get; set; }
            public string Column5 { get; set; }
            public string Column6 { get; set; }
            public string Column7 { get; set; }
            public string Column8 { get; set; }
            public string Column9 { get; set; }
            public string Column10 { get; set; }
            public string Column11 { get; set; }


            public static data FromCSV(string CSVLine)
            {
                string[] Values = CSVLine.Split(';');

                data DailyValues = new data();

                DailyValues.Column1 = Values[0];

                DailyValues.Column2 = Values[1];

                DailyValues.Column3 = Values[2];
                DailyValues.Column4 = Values[3];
                DailyValues.Column5 = Values[4];
                DailyValues.Column6 = Values[5];
                DailyValues.Column7 = Values[6];
                DailyValues.Column8 = Values[7];
                DailyValues.Column9 = Values[8];
                DailyValues.Column10 = Values[9];
                DailyValues.Column11 = Values[10];

                return DailyValues;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            string link = @"5_month.csv";
            List<data> Values = File.ReadAllLines(link, Encoding.Default).Where(w => w.Contains(textBox1.Text)).Select(v => data.FromCSV(v)).ToList();
            //проход по csv файлу
            foreach (data x in Values)
            {
                res = res + x.Column1+"; " + x.Column2 + "; " + x.Column3 + "; " + x.Column4 + "; " + x.Column5 + "; " + x.Column6 + "; " + x.Column7 + "; " + x.Column8 + "; " + x.Column9 + "; " + x.Column10 + "; " + x.Column11 + "\n";
               
            }
            //вывод информации
            richTextBox1.Text = res;
        }
    }
}
