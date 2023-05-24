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
        public struct lubs
        {
            public string anno, nazione, info, peso, note;
        }
        public lubs[] p;
        public lubs p2;
        public int d;
        public Form1()
        {
            InitializeComponent();
            lubs[] p = new lubs[d];
            d = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void op_Click(object sender, EventArgs e)
        {
            apri();
            st(p2);
            d++;
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
                listView1.Items.Add(values[d]);
                foreach (string coloumn1 in listView1.Items) //per ogni valore presente sulla listview
                {
                    listView1.Columns.Add(coloumn1,20); //permette di creare delle colonne comprendenti le info sul file
                }
                foreach (string coloumn2 in listView1.Items)
                {
                    listView1.Columns.Add(coloumn2, 20);
                }
                

                
            }
        }
        public string st(lubs p)
        {

            return p2.anno;
        }
        #endregion
    }
}
