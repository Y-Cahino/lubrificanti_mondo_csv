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

namespace elaborazione_csv
{
    public partial class Form1 : Form
    {
        public int d;
        public string[] a;
        public StreamReader reader = new StreamReader(File.OpenRead(@"Cahino.csv"));
        public StreamWriter writer = new StreamWriter(File.OpenRead(@"Cahino.csv"));
        public Form1()
        {
            d = 0;
            a = new string[1000];
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void op_Click(object sender, EventArgs e)
        {
            apri();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region funzioni
        public void apri()
        {
            var reader = new StreamReader(File.OpenRead(@"Cahino.csv"));
            while (!reader.EndOfStream)
            {
                //string rec = "Record";
                //int[] miovalore = new int[r.Next(9,20)];
                var line = reader.ReadLine();
                var values = line.Split(';');
                for (int i = 0; i < values.Length; i++)
                {
                    listView1.Columns.Add(values[i]);
                    //listView1.Columns.Add(rec);
                    //listView1.Columns[rec]= miovalore[i];
                }
            }
        }
        public void stampaval()
        {
            var line = reader.ReadLine();
            var values = line.Split(';');
            Random r = new Random();
            while (!reader.EndOfStream)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    listView1.Columns.Add(values[d]);
                }
                if (d == 0)
                {
                    a[d] = d + ";miovalore";
                    d++;
                }
                else
                {
                    string b = r.Next(10, 21).ToString();
                    a[d] = a + ";" + b;
                }
                d++;
                a[d] = reader.ReadLine();
            }
            writer.Write(a[d]);
        }
        public void maxval()
        {
            var line = reader.ReadLine();
            var values = line.Split(';');
            while (!reader.EndOfStream)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (values[0].Length > values.Length)
                        writer.WriteLine(a[d].Length);
                }
            }
        }
        #endregion
    }
}
