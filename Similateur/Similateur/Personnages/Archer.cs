using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
    class Archer : Personnages
    {
        public Archer(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementAvecArc();
            ComportementEmettreUnSon = new ComportementParler();
        }

        public override string Afficher()
        {
            return "Archer " + Nom;
        }

        public override string SeDeplacer()
        {
            return "Je marche à pied";
        }
    }
}
