/*         
        Programmeur(s):      Franck Gildas M. K.,
                             Alioune Sarr,
                             El Hadji Cisse Mbengue,
                             Mohamed ESSANHAJI

        Date:                Décembre 2023

        Solution:            RestauManager.sln
        Projet:              RestauManager.csproj
        Classe:              RestauManagerForm.cs

        But:                 •	Gérer la logique de l'interface utilisateur. 
                             •  Afficher des informations et collecter des informations auprès de l'utilisateur.
                             •	Valider la date avant de transmettre les données à la couche métier.
                             •  Calculer le prix de la transaction.

        Info:                Couche de présentation.    
*/

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

using TransactionNS;

namespace RestauManager
{
    public partial class RestauManagerForm : Form
    {
        #region Variables privées

        private const decimal TAX = 0.15M;
        private readonly Transaction oTrans = new Transaction();

        #endregion

        #region Constructeur
        public RestauManagerForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Initialisation
        private void RestauManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Remplir les listes déroulantes
                restaurantComboBox.Items.AddRange(oTrans.GetRestaurants());
                specialiteComboBox.Items.AddRange(oTrans.GetSpecialites());

                // Sélectionner le premier élément par défaut
                restaurantComboBox.SelectedIndex = 0;
                specialiteComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'initialisation du formulaire : {ex.Message}");
            }
        }

        #endregion

        #region Enregistrer
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string prixText = totalLabel.Text.Replace("$", string.Empty);

                DateTime date = ValiderDate();

                oTrans.Enregistrer(nomTextBox.Text,
                                   date,
                                   restaurantComboBox.SelectedItem.ToString(),
                                   specialiteComboBox.SelectedItem.ToString(),
                                   decimal.Parse(prixText));
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Erreur lors de l'enregistrement de la transaction : {ex.Message}");
            }
        }

        #endregion

        #region Valider et retourner la date de la transaction
        private DateTime ValiderDate()
        {
            if (!DateTime.TryParse(dateTextBox.Text, out DateTime date))
            {
                date = DateTime.Now;
                dateTextBox.Text = DateTime.Now.ToShortDateString();
            }

            return date;
        }

        #endregion

        #region Imprimer

        // Gestionnaire d'événements pour l'élément de menu Imprimer
        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                oTrans.Imprimer();
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Erreur d'impression des transactions : {ex.Message}");
            }
        }

        #endregion

        #region Obtenir le prix selon le gestionnaire d'événements pour l'événement SelectedIndexChanged de la liste déroulante Spécialité

        private void specialiteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (specialiteComboBox.SelectedIndex == -1)
                {
                    throw new Exception("Veuillez sélectionner un vendeur.");
                }

                // Obtenir le prix de la spécialité sélectionnée en classe métier
                decimal prixDecimal = oTrans.GetPrix(specialiteComboBox.SelectedIndex);

                // Calculer le prix total TTC(Total Taxes Comprises)
                decimal prixTotalDecimal = prixDecimal * (1 + TAX);

                // Mettre à jour les zones de labels Prix et Prix total sur le formulaire
                prixLabel.Text = prixDecimal.ToString("C2");
                totalLabel.Text = prixTotalDecimal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour du prix : {ex.Message}");
            }
        }



        #endregion
    }
}
