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
        public Form1()
        {
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
                var line = reader.ReadLine();
                var values = line.Split(';');
                var line2 = reader.ReadLine();
                var values2 = line.Split(' ');

                listView1.Items.Add(values[0],values2[0]);
                listView1.Items.Add(values[1],values2[1]);
                foreach (string coloumn1 in listView1.Items) //per ogni valore presente sulla listview
                {
                    listView1.Columns.Add(coloumn1,20); //permette di creare delle colonne comprendenti le info sul file
                }
                foreach (string coloumn2 in listView1.Items)
                {
                    listView1.Columns.Add(coloumn2, 20);
                }


            }
            #endregion


        }
    }
}
