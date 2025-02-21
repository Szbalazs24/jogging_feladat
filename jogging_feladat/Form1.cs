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

namespace jogging_feladat
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
        public List<orszagok> orszag = new List<orszagok>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orszag.Clear();
            listBox1.Items.Clear();
            string a = "";
            if (comboBox1.SelectedIndex == 0)
            {
                a = "forras_azsia.txt";
                o_ki.Text = "Ázsia";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                a = "forras_afrika.txt";
                o_ki.Text = "Afrika";
            }
            else if (comboBox1.SelectedIndex == 2) {
                a = "forras_europa.txt";
                o_ki.Text = "Európa";
            }
            StreamReader sr = new StreamReader(a);
            
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                orszag.Add(new orszagok(sor[0], sor[1], Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]), Convert.ToDouble(sor[4])));
            }
            for (int i = 0; i < orszag.Count; i++)
            {
                listBox1.Items.Add(orszag[i].Orszag);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tallozas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiiras.Text = $"Ország: {orszag[listBox1.SelectedIndex].Orszag} Főváros: {orszag[listBox1.SelectedIndex].Fovaros} Terület: {orszag[listBox1.SelectedIndex].Terulet} Népesség: {orszag[listBox1.SelectedIndex].Nepesseg} Népsűrűség: {orszag[listBox1.SelectedIndex].Nepsuruseg}km2";
        }
    }

    public class orszagok
    {
        public string Orszag { get; set; }
        public string Fovaros { get; set; }
        public int Terulet { get; set; }
        public int Nepesseg { get; set; }
        public double Nepsuruseg { get; set; }

        public orszagok(string orszag, string fovaros, int terulet, int nepesseg, double nepsuruseg)
        {
            Orszag = orszag;
            Fovaros = fovaros;
            Terulet = terulet;
            Nepesseg = nepesseg;
            Nepsuruseg = nepsuruseg;
        }
    }
}
