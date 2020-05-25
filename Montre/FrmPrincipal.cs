using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "Démo H20.1.0";

        // TODO 01 : Dans le menu "Projet" de Visual Studio, choisir l'option "Ajouter une classe..."
        // et nommer le nouveau fichier "Montre.cs"

        // TODO 02 : La première fois que nous avons construit la classe Montre nous utilisé un diagramme de classe. 
        // Dans ce projet il y a une interface nommée IMontre, elle contient les propriétés et méthodes que la montre devra implémenter.


        // TODO 03 : Ajouter deux constructeurs à la classe Montre (impossible d'imposer les constructeurs dans une interface)
        // Le constructeur devra avoir 3 paramètres soit : les heures, les minutes et les secondes.

        // TODO 04 : Compléter le code la classe Montre


        private IMontre m_objMontre; // Une référence vers un objet qui implémente l'interface IMontre
        //==================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 05 : Retirer tous les commentaires devant le code jusqu'à la fin et exécuter le programme il devrait fonctionner. 

            m_objMontre = new Montre(9, 15, 42);
            txtAffichageMontre.Text = m_objMontre.TempsCourant;
        }

        //============================================================================
        // Evénement associé au tick de l'horloge. À chaque tick, on avance d'une seconde.
        private void btnAvancer_Click(object sender, System.EventArgs e)
        {
            m_objMontre.AvancerUneSeconde();
            txtAffichageMontre.Text = m_objMontre.TempsCourant;
        }

        //============================================================================
        private void btnDemarrerArreterHorloge_Click(object sender, System.EventArgs e)
        {
            tmrHorloge.Enabled = !tmrHorloge.Enabled;
        }

        //============================================================================
        private void btnInitialiserMontre_Click(object sender, System.EventArgs e)
        {
            m_objMontre = new Montre(23, 59, 55);
            txtAffichageMontre.Text = m_objMontre.TempsCourant;
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
