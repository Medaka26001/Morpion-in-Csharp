using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // Variable
        int player = 0;
        int nombredevictoireX = 0;
        int nombredevictoireY = 0;
        int victoire = 0;
        string Joueur1 = "X";
        string Joueur2 = "O";
        string JoueurActuel = "X";
        string MessageErreur = "Emplacement Invalide";

        public Form1()
        {
            InitializeComponent();
        }
        private void pion2_Click(object sender, EventArgs e)
        {
            if (pion2.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion2.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion3_Click(object sender, EventArgs e)
        {
            if (pion3.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion3.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion4_Click(object sender, EventArgs e)
        {
            if (pion4.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion4.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion5_Click(object sender, EventArgs e)
        {
            if (pion5.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion5.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion6_Click(object sender, EventArgs e)
        {
            if (pion6.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion6.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion7_Click(object sender, EventArgs e)
        {
            if (pion7.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion7.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion8_Click(object sender, EventArgs e)
        {
            if (pion8.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion8.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void pion9_Click(object sender, EventArgs e)
        {
            if (pion9.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion9.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void changementdejoueur()
        {
            if (JoueurActuel == "O")
            {
                JoueurActuel = "X";
                lblinfo.Text = "Au tour de : Joueur X";

            }
            else
            {
                JoueurActuel = "O";
                lblinfo.Text = "Au tour de : Joueur O";
            }
        }

        private void Vnul()
        {
            if (pion1.Text.ToString() != "" && pion2.Text.ToString() != "" && pion3.Text.ToString() != "" && pion4.Text.ToString() != "" && pion5.Text.ToString() != "" && pion6.Text.ToString() != "" && pion7.Text.ToString() != "" && pion8.Text.ToString() != "" && pion9.Text.ToString() != "" && victoire == 0)
            {
                MessageBox.Show("Match nul! Personne ne peut gagné Reset de la partie");
                reset();
            }
        }

        private void Btncommencer_Click(object sender, EventArgs e)
        {

        }

        private void lblinfo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pion1.Text.ToString() != "")
            {
                //emplacement invalide
                MessageBox.Show(MessageErreur);
            }
            else
            {
                //Marquer le Symbole
                pion1.Text = JoueurActuel;
                //Verifier si le joueur Gagne
                VVictoire();
                //Verifier si Match Nul
                Vnul();
                //Changer le Joueur Actuelle
                changementdejoueur();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void VVictoire()
        {
            if (pion1.Text.ToString() == JoueurActuel && pion2.Text.ToString() == JoueurActuel && pion3.Text.ToString() == JoueurActuel)
            {
                pion1.ForeColor = Color.Red;
                pion2.ForeColor = Color.Red;
                pion3.ForeColor = Color.Red;

                victoire = 1;

            }
            if (pion4.Text.ToString() == JoueurActuel && pion5.Text.ToString() == JoueurActuel && pion6.Text.ToString() == JoueurActuel)
            {
                pion4.ForeColor = Color.Red;
                pion5.ForeColor = Color.Red;
                pion6.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion7.Text.ToString() == JoueurActuel && pion8.Text.ToString() == JoueurActuel && pion9.Text.ToString() == JoueurActuel)
            {
                pion7.ForeColor = Color.Red;
                pion8.ForeColor = Color.Red;
                pion9.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion1.Text.ToString() == JoueurActuel && pion5.Text.ToString() == JoueurActuel && pion9.Text.ToString() == JoueurActuel)
            {
                pion1.ForeColor = Color.Red;
                pion5.ForeColor = Color.Red;
                pion9.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion3.Text.ToString() == JoueurActuel && pion5.Text.ToString() == JoueurActuel && pion7.Text.ToString() == JoueurActuel)
            {
                pion3.ForeColor = Color.Red;
                pion5.ForeColor = Color.Red;
                pion7.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion1.Text.ToString() == JoueurActuel && pion4.Text.ToString() == JoueurActuel && pion7.Text.ToString() == JoueurActuel)
            {
                pion1.ForeColor = Color.Red;
                pion4.ForeColor = Color.Red;
                pion7.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion2.Text.ToString() == JoueurActuel && pion5.Text.ToString() == JoueurActuel && pion8.Text.ToString() == JoueurActuel)
            {
                pion2.ForeColor = Color.Red;
                pion5.ForeColor = Color.Red;
                pion8.ForeColor = Color.Red;
                victoire = 1;
            }
            if (pion3.Text.ToString() == JoueurActuel && pion6.Text.ToString() == JoueurActuel && pion9.Text.ToString() == JoueurActuel)
            {
                pion6.ForeColor = Color.Red;
                pion3.ForeColor = Color.Red;
                pion9.ForeColor = Color.Red;
                victoire = 1;
            }
            if (victoire == 1)
            {
                if (JoueurActuel == "O")
                {
                    MessageBox.Show("Bravo Joueur 2, Vous avez gagner la partie!");
                    nombredevictoireY = nombredevictoireY + 1;
                    lblscoreY.Text = nombredevictoireY.ToString();
                    reset();
                }
                else
                {
                    MessageBox.Show("Bravo Joueur 1, Vous avez gagner la partie!");
                    nombredevictoireX = nombredevictoireX + 1;
                    lblscoreX.Text = nombredevictoireX.ToString();
                    reset();
                }
            }
        }
        private void reset()
        {
            pion1.Text = "";
            pion2.Text = "";
            pion3.Text = "";
            pion4.Text = "";
            pion5.Text = "";
            pion6.Text = "";
            pion7.Text = "";
            pion8.Text = "";
            pion9.Text = "";
            victoire = 0;
            resetcouleur();
        }
        private void resetcouleur()
        {
            pion1.ForeColor = Color.Black;
            pion2.ForeColor = Color.Black;
            pion3.ForeColor = Color.Black;
            pion4.ForeColor = Color.Black;
            pion5.ForeColor = Color.Black;
            pion6.ForeColor = Color.Black;
            pion7.ForeColor = Color.Black;
            pion8.ForeColor = Color.Black;
            pion9.ForeColor = Color.Black;
        }
    }
}
