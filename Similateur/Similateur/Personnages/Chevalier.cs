using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
    class Chevalier : Personnages
    {
        public Chevalier(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementAcheval();
            ComportementEmettreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return "Chevalier " + Nom;
        }

        public override string SeDeplacer()
        {
            return "Je trotte, je galope";
        }
    }
}
