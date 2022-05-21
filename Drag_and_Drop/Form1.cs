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


namespace Drag_and_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e) //w własciwościach TextBox przejść na Zdarzenia i wybrać DragEnter, posługuje się argumentem 'e'
        {
            e.Effect = DragDropEffects.Copy;   //pokazuje ale jeszcze nie dodaje do pola tekstowego (Copy-kopuje, Move - posi itd..)

            textBox1.Text += e.Data.GetData(DataFormats.Text).ToString();   //teraz dodaje (+=) tekst do okna 'textBox1'


        }

        private void button1_Click(object sender, EventArgs e)   //wykasuj zawsartoć okna
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)      //skasuj linię tekstu
        {
            
            string[] tablica_linii = { "aaa", "bbb", "ccc" };     //lub z góry określone znaki w tablicy
            var nowe_linie = (from ln in tablica_linii select ln).SkipWhile(ln => ln != "aaa");
            

            foreach (var nowsze_linie in nowe_linie)
            {
                
               // this.textBox1.Lines = nowsze_linie.ToArray();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] tablica_linii = this.textBox1.Lines;       //przepisz wszytkie linie do tablicy (array)
            int ile_linii = 2;
            var noweLinie = tablica_linii.Skip(ile_linii);  // kasuje ilość linii podanych w 'int ile_linii = 2;' zaczynając od początku
            this.textBox1.Lines = noweLinie.ToArray();
        }
    }
}
