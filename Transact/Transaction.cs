/*         
        Programmeur(s):      Alioune Sarr,
                             El Hadji Cisse Mbengue,
                             Franck Gildas M. K.,
                             Mohamed ESSANHAJI

        Date:                Décembre

        Solution:            RestauManager.sln
        Projet:              RestauManager.csproj
        Classe:              Transaction.cs

        But:                 •	Traiter les données conformément aux règles métier. 
                             •	Validation des contraintes métier.
                             •  Ajouter, supprimer et modifier des données dans le niveau données.


        Info:                Couche de métier.    
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TransactionNS
{
    public class Transaction
    {
        #region Constante et info culture

        private const char DELIMITEUR = ';';
        private static readonly CultureInfo culture = new CultureInfo("en-CA");

        #endregion

        #region Tableaux pour stocker des données à partir de fichiers texte

        private string[] restaurants;
        private string[] specialites;
        private decimal[] prix;

        #endregion

        #region Champs privés

        private string nomStr;
        private DateTime dateTransactionDateTime;
        private string restaurantStr;
        private string specialiteStr;
        private decimal prixTotalDecimal;

        #endregion

        #region Propriétés

        /// <summary>
        /// Obtient ou définit le nom associé à la transaction.
        /// </summary>
        public string Nom
        {
            get
            {
                return nomStr;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Le nom ne peut pas être vide.");
                }

                nomStr = value.Trim(); // Supprime les espaces
            }
        }

        /// <summary>
        /// Obtient ou définit le date associée à la transaction.
        /// </summary>
        public DateTime DateTransaction
        {
            get
            {
                return dateTransactionDateTime;
            }
            set
            {
                dateTransactionDateTime = value;
            }
        }

        /// <summary>
        /// Obtient ou définit le nom du restaurant associé à la transaction.
        /// </summary>
        public string Restaurant
        {
            get
            {
                return restaurantStr;
            }
            set
            {
                if (value == null || !restaurants.Contains(value))
                {
                    throw new Exception("Le restaurant doit exister dans la liste des restaurants.");
                }
               
                restaurantStr = value.Trim();
            }
        }

        /// <summary>
        /// Obtient ou définit le nom de la spécialité associé à la transaction.
        /// </summary>
        public string Specialite
        {
            get
            {
                return specialiteStr;
            }
            set
            {
                if (value == null || !specialites.Contains(value))
                {
                    throw new Exception("La boisson doit exister dans la liste des boissons.");
                }

                specialiteStr = value.Trim();
            }
        }

        /// <summary>
        /// Obtient ou définit le prix total associé à la transaction.
        /// </summary>
        public decimal PrixTotal
        {
            get
            {
                return prixTotalDecimal;
            }
            set
            {
                if (value <= 0.00M)
                {
                    throw new Exception("Le prix total doit être supérieur à $0,00.");
                }

                prixTotalDecimal = value;
            }
        }

        #endregion

        #region Constructeur par défaut

        public Transaction()
        {
            InitRestaurants();
            InitSpecialitesPrix();
        }

        #endregion

        #region Méthode pour initialiser le tableau de restaurants et de spécialités de Restaurant.data et Specialite.data respectivement

        /// <summary>
        /// Initialise les restaurants
        /// </summary>
        private void InitRestaurants()
        {
            try
            {
                var lignes = File.ReadAllLines(@"DATA\Restaurant.data");
                int nombreRestaurants = int.Parse(lignes[0]);
                restaurants = new string[nombreRestaurants];

                for (int i = 0; i < nombreRestaurants; i++)
                {
                    restaurants[i] = lignes[i + 1];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de lecture de Restaurant.data : {ex.Message}");
            }
        }

        /// <summary>
        /// Initialise les spécialités et les prix
        /// </summary>
        private void InitSpecialitesPrix()
        {
            try
            {
                var lignes = File.ReadAllLines(@"DATA\Specialite.data");
                int nombreSpecialites = lignes.Length;

                specialites = new string[nombreSpecialites];
                prix = new decimal[nombreSpecialites];

                int i = 0;

                while (i < nombreSpecialites)
                {
                    var champs = lignes[i].Split(DELIMITEUR);
                    specialites[i] = champs[0];
                    prix[i] = decimal.Parse(champs[1], culture);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de lecture de Boissons.data : {ex.Message}");
            }
        }

        #endregion

        #region Méthode pour obtenir tous les restaurants, spécialités, et prix par index

        /// <summary>
        /// Obtenir la liste des restaurants
        /// </summary>
        /// <returns>restaurants</returns>
        public string[] GetRestaurants()
        {
            return restaurants;
        }

        /// <summary>
        /// Obtenir la liste des spécialités
        /// </summa ry>
        /// <returns>Les spécialités</returns>
        public string[] GetSpecialites() 
        { 
            return specialites; 
        }

        /// <summary>
        /// Obtenir le prix quand une spécialité est sélectionnée
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Le prix d'une spécialité</returns>
        /// <exception cref="Exception">Index out of range</exception>
        public decimal GetPrix(int index)
        {
            if (index < 0 || index >= prix.Length)
            {
                throw new Exception("Index out of range.");
            }

            return prix[index];
        }

        #endregion

        #region Méthode pour enregistrer une transaction dans Transactions.data

        /// <summary>
        /// Méthode pour enregistrer la transaction
        /// </summary>
        /// <param name="nomStr">Nom du cuisinimane</param>
        /// <param name="dateDateTime">Date de transaction</param>
        /// <param name="restauStr">Nom du restaurant</param>
        /// <param name="specialiteStr">Nom de la spécialité du restaurant</param>
        /// <param name="prixTotalDecimal">Le prix total après taxe</param>
        /// <exception cref="Exception">Erreur d'écriture dans le fichier Transaction.data</exception>
        public void Enregistrer(string nomStr, DateTime dateDateTime, string restauStr, string specialiteStr, decimal prixTotalDecimal)
        {
            // Initialise les champs via les propriétés
            Nom = nomStr;
            DateTransaction = dateDateTime;
            Restaurant = restauStr;
            Specialite = specialiteStr;
            PrixTotal = prixTotalDecimal;

            // Préparez la ligne à écrire dans le fichier
            var ligne = string.Join(DELIMITEUR.ToString(), 
                                     Nom, 
                                     DateTransaction.ToString("d", CultureInfo.CurrentCulture), 
                                     Restaurant,
                                     Specialite, 
                                     PrixTotal.ToString("F2", culture));

            try
            {
                // Écrire dans le fichier Transactions.data
                File.AppendAllText(@"DATA\Transactions.data", ligne + Environment.NewLine, Encoding.UTF8);
            }
            catch (Exception ex) 
            {
                throw new Exception($"Erreur d'écriture dans Transactions.data : {ex.Message}");
            }
        }

        #endregion

        #region Méthode pour imprimer toutes les transactions de Transactions.data

        /// <summary>
        /// Imprimer les données de Transaction.data à la Console.
        /// </summary>
        /// <exception cref="Exception">Erreur de lecture de Transactions.data.</exception>
        public void Imprimer()
        {
            try
            {
                var lignes = File.ReadAllLines(@"DATA\Transactions.data");
                decimal ventesTotalesDecimal = 0.00M;

                Console.WriteLine("Restaurant".PadRight(48) + "Spécialité".PadRight(39) + "Prix".PadRight(26) + "Acheteur".PadRight(46) + "Date".PadRight(20) + Environment.NewLine);

                foreach (var ligne in lignes)
                {
                    var champs = ligne.Split(DELIMITEUR);
                    decimal prixDecimal = decimal.Parse(champs[4], culture);
                    ventesTotalesDecimal += prixDecimal;

                    string ligneFormateeStr = string.Format("{2,-40}        {3,-30}         {4,-20}      {0, -40}      {1,-20}",
                                                            champs[0].PadRight(30),
                                                            DateTime.Parse(champs[1]).ToString("d", CultureInfo.CurrentCulture).PadRight(20),
                                                            champs[2].PadRight(40),
                                                            champs[3].PadRight(30),
                                                            prixDecimal.ToString("C2").PadRight(20));

                    Console.WriteLine(ligneFormateeStr);
                }

                Console.WriteLine($"Ventes totales : {ventesTotalesDecimal:C2}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur de lecture de Transactions.data : {ex.Message}");
            }
        }

        #endregion
    }
}
