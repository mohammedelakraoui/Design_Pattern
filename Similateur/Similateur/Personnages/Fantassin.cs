using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
    class Fantassin : Personnages
    {

        public Fantassin(string unNom)
            : base(unNom)
        {
            ComportementCombat = new ComportementApiedAvecHache();
            ComportementEmettreUnSon = new ComportementCrier();
        }

        public override string Afficher()
        {
            return "Fantassin " + Nom;
        }


        public override string SeDeplacer()
        {
            return "Je marche à pied";
        }
    }
}
