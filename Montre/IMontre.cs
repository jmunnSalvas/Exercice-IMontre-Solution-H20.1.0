using System;
namespace ApplicationMontre
{
    /// <summary>
    /// Fournit les propriétés et méthodes pour le fonctionnement d'une montre
    /// </summary>
    interface IMontre
    {
        #region Propriétés
        /// <summary>
        ///  Obtient l'heure courante de la montre
        /// </summary>
        int Heures { get; }

        /// <summary>
        ///  Obtient les minutes courante de la montre
        /// </summary>
        int Minutes { get; }

        /// <summary>
        ///  Obtient les secondes courante de la montre
        /// </summary>
        int Secondes { get; }
        #endregion

        #region Propriété calculée
        /// <summary>
        ///  Obtient une chaîne représentant le temps sous la forme HH:mm:ss
        /// </summary>
        string TempsCourant { get; }
        #endregion

        #region Méthodes


        /// <summary>
        /// Permet d'avancer le temps courant d'une seconde
        /// </summary>
        void AvancerUneSeconde();

        #endregion
    }
}
