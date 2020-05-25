using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMontre
{
    /// ===================================================================================
    /// <summary>
    /// Représente une montre indiquant l'heure dans le format: HH:MM:SS
    /// On peut faire avancer le temps d'une seconde à la fois.
    /// </summary>
    /// ===================================================================================
    public class Montre:IMontre
    {
        #region PROPRIÉTÉS
        /// <summary>
        /// Obtient l'heure courante de la montre
        /// </summary>
        public int Heures { get; private set; }

        /// <summary>
        /// Obtient les minutes courantes de la montre
        /// </summary>
        public int Minutes { get; private set; }

        /// <summary>
        /// Obtient les secondes courantes de la montre
        /// </summary>-
        public int Secondes { get; private set; }

        /// <summary>
        /// Obtient le temps courant de la montre formaté
        /// </summary>
        public string TempsCourant
        {
            get
            {
                return Heures + ":" +
                       Minutes.ToString("00") + ":" +
                       Secondes.ToString("00");
            }
        }
        #endregion

        #region CONSTRUCTEURS (2 surcharges)
        ///===================================================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Montre.
        ///  Le temps au départ est 00:00:00
        /// </summary>
        public Montre()
        {
            Heures = 0;
            Minutes = 0;
            Secondes = 0;
        }

        ///===================================================================================
        /// <summary>
        /// Initialise une nouvelle instance de la classe Montre.
        /// Le temps au départ est celui spécifié par les paramètres.
        /// </summary>
        /// <param name="pHeures">heure courante</param>
        /// <param name="pMinutes">minute courante</param>
        /// <param name="pSecondes">seconde courante</param>
        public Montre(int pHeures, int pMinutes, int pSecondes)
        {
            Heures = pHeures;
            Minutes = pMinutes;
            Secondes = pSecondes;
        }

        #endregion

        #region MÉTHODE
        /// <summary>
        /// Augmente le temps courant d'une seconde 
        /// </summary>
        public void AvancerUneSeconde()
        {
            Secondes++;
            if (Secondes > 59)
            {
                Secondes = 0;                
                Minutes++;    //  avancer d'une minute

                if (Minutes > 59)
                {
                    Minutes = 0;
                    Heures++; //	avancer d'une heure

                    if (Heures > 23)
                    {
                        Heures = 0;
                    }
                }
            }
        }
        #endregion
    }


}
