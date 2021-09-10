using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoMorraCinese
{
    public partial class MorraCineseForm : Form
    {
        int punteggioGioc = 0;
        int punteggioPC = 0;

        public MorraCineseForm()
        {
            InitializeComponent();
            imgUscitaPC.BackgroundImage = Properties.Resources.interrogativo1;
            imgUscitaGioc.BackgroundImage = Properties.Resources.interrogativo1;

            txtPunteggioGioc.Text = "0";
            txtPunteggioPC.Text = "0";
        }

        private void btnSasso_Click(object sender, EventArgs e)
        {
            txtUscitaGiocatore.Text = btnSasso.Text;
           
        }

    

        private void btnCarta_Click(object sender, EventArgs e)
        {
            txtUscitaGiocatore.Text = btnCarta.Text;
        }

        private void btnForbice_Click(object sender, EventArgs e)
        {
            txtUscitaGiocatore.Text = btnForbice.Text;
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            
            Random NumeroCasuale = new Random();
            int sceltaPC = NumeroCasuale.Next(1, 4);
            
            SceltaComputer(sceltaPC);
            RestituisciVincitore(sceltaPC);

        }

        private void btnRicomincia_Click(object sender, EventArgs e)
        {
            txtEsito.Clear();
            txtUscitaGiocatore.Clear();
            txtUscitaPC.Clear();
            imgUscitaPC.BackgroundImage = Properties.Resources.interrogativo1;
            imgUscitaGioc.BackgroundImage = Properties.Resources.interrogativo1;
        }

        private void SceltaComputer(int sceltaPC)
        {    
            Thread.Sleep(500);
          
            if (sceltaPC == 1)
            {
                txtUscitaPC.Text = "Sasso";
            }
            else if (sceltaPC == 2)
            {
                txtUscitaPC.Text = "Carta";
            }
            else if (sceltaPC == 3)
            {
                txtUscitaPC.Text = "Forbice";
            }

        }

        private void RestituisciVincitore(int SceltaPC)
        {
           

            if (SceltaPC == 1 && txtUscitaGiocatore.Text == btnSasso.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Sasso1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Sasso1;
                
                txtEsito.Text = "Pareggio!";
              
            }
            else if (SceltaPC == 1 && txtUscitaGiocatore.Text == btnCarta.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Sasso1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Carta1;
                txtEsito.Text = "Hai vinto!";

                punteggioGioc++;
            }
            else if (SceltaPC == 1 && txtUscitaGiocatore.Text == btnForbice.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Sasso1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Forbice1;
                txtEsito.Text = "Hai perso!";

               
                punteggioPC++;
             
            }
            else if (SceltaPC == 2 && txtUscitaGiocatore.Text == btnSasso.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Carta1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Sasso1;
                txtEsito.Text = "Hai perso!";
           
                punteggioPC++;
                              
            }
            else if (SceltaPC == 2 && txtUscitaGiocatore.Text == btnCarta.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Carta1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Carta1;
                txtEsito.Text = "Pareggio!";
               
               
            }
            else if (SceltaPC == 2 && txtUscitaGiocatore.Text == btnForbice.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Carta1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Forbice1;
                txtEsito.Text = "Hai vinto!";
              
                punteggioGioc++;
             

            }
            else if (SceltaPC == 3 && txtUscitaGiocatore.Text == btnSasso.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Forbice1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Sasso1;
                txtEsito.Text = "Hai vinto!";
               
                punteggioGioc++;
              
            }
            else if (SceltaPC == 3 && txtUscitaGiocatore.Text == btnCarta.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Forbice1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Carta1;
                txtEsito.Text = "Hai perso!";
                
                punteggioPC++;              
            }
            else if (SceltaPC == 3 && txtUscitaGiocatore.Text == btnForbice.Text)
            {
                imgUscitaPC.BackgroundImage = Properties.Resources.Forbice1;
                imgUscitaGioc.BackgroundImage = Properties.Resources.Forbice1;
                txtEsito.Text = "Pareggio!";
             
            

            }

            txtPunteggioGioc.Text = punteggioGioc.ToString();
            txtPunteggioPC.Text = punteggioPC.ToString();

            if (punteggioGioc == 3)
            {
                MessageBox.Show("Hai vinto!");
                txtEsito.Clear();
                txtUscitaGiocatore.Clear();
                txtUscitaPC.Clear();
                txtPunteggioGioc.Clear();
                txtPunteggioPC.Clear();
                punteggioPC = 0;
                punteggioGioc = 0;
            }
            else if (punteggioPC == 3)
            {
                MessageBox.Show("Hai perso!");
                txtEsito.Clear();
                txtUscitaGiocatore.Clear();
                txtUscitaPC.Clear();
                txtPunteggioGioc.Clear();
                txtPunteggioPC.Clear();
                punteggioPC = 0;
                punteggioGioc = 0;
            }
        }

        private void imgProfiloGiocat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
