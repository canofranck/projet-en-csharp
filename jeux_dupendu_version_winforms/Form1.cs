using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppcwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Papier_Click(object sender, EventArgs e)
        {
           Random random = new Random();
           string choixcomputer;
           switch (random.Next(1, 4))
            {
                case 1:
                    choixcomputer = "PAPIER";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " C'est un match null";
                    break;
                case 2:
                    choixcomputer = "PIERRE";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " Vous gagnez !!!";
                    break;
                case 3:
                    choixcomputer = "CISEAUX";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " L'ordinateur gagne :-(";
                    break;
            }
        }

        private void Pierre_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string choixcomputer;
            switch (random.Next(1, 4))
            {
                case 1:
                    choixcomputer = "PAPIER";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " L'ordinateur gagne :-(";
                    break;
                case 2:
                    choixcomputer = "PIERRE";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " C'est un match null";
                    break;
                case 3:
                    choixcomputer = "CISEAUX";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " Vous gagnez !!!";
                    break;
            }
        }

        private void Ciseaux_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string choixcomputer;
            switch (random.Next(1, 4))
            {
                case 1:
                    choixcomputer = "PAPIER";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " Vous gagnez !!!";
                    break;
                case 2:
                    choixcomputer = "PIERRE";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " L'ordinateur gagne :-(";
                    break;
                case 3:
                    choixcomputer = "CISEAUX";
                    textbox_ordinateur.Text = "L'ordinateur a choisi :" + choixcomputer;
                    textboxresultat.Text = " C'est un match null";
                    break;
            }
        }

        private void textboxresultat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
