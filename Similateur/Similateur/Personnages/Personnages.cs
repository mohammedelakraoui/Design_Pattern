using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
   abstract class Personnages
    {
       public string Nom { get; set; }
        public ComportementCombat ComportementCombat { get; set; }
        public ComportementEmettreUnSon ComportementEmettreUnSon { get; set; }

        //-----------------------------------------------------------------------------
        protected Personnages(string sonNom)
        {
            Nom = sonNom;
            ComportementCombat = null;
            ComportementEmettreUnSon = null;
        }

        //-----------------------------------------------------------------------------
        public virtual string Afficher()
        {
            return Nom;
        }

        //-----------------------------------------------------------------------------
        public virtual string SeDeplacer()
        {
            return "Je me déplace...";
        }

        //-----------------------------------------------------------------------------
        public string EmettreUnSon()
        {
            if (ComportementEmettreUnSon != null)
                return ComportementEmettreUnSon.EmmettreSon();
            return "Je suis muet";
        }

        //-----------------------------------------------------------------------------
        public string Combattre()
        {
            if (ComportementCombat != null)
                return ComportementCombat.Combattre();
            return "Je ne combat pas"; 
        }


    }

    }

