using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vue
{
    public partial class ajouter_expediteur : Form
    {
        public ajouter_expediteur()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            expediteur ex = new expediteur(1, textBox1.Text, textBox3.Text, "sfax", richTextBox1.Text, "sfax sud", textBox4.Text, textBox5.Text, "espece", Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text)) ;
            gestlivraisonEntities1 ctx = new gestlivraisonEntities1();
            ctx.expediteur.Add(ex);
            ctx.SaveChanges();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
