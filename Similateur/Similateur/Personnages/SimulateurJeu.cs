using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
    class SimulateurJeu
    {
        private readonly List<Personnages> PersonnageList;

        public SimulateurJeu()
        {
            PersonnageList = new List<Personnages>();
        }

        public void CreationPersonnages()
        {
            Chevalier Arnaud = new Chevalier("Arnaud le terrible");
            Fantassin Jacques = new Fantassin("Jacques a dit");
            Archer Thierry = new Archer("Thierry la fronde"); 
            PersonnageList.Add(Arnaud);
            PersonnageList.Add(Jacques);
            PersonnageList.Add(Thierry);
            
           Princesse Fiona = new Princesse("Fiona la belle");
           PersonnageList.Add(Fiona);
        }

        public string Affichetous()
        {
            var resultat = new StringBuilder("Personnages :\n");
            foreach (var personnage in PersonnageList)
            {
                resultat.AppendLine("- " + personnage.Afficher());
            }
            return resultat.ToString();
        }

        public string EmettreSontous()
        {
            var resultat = new StringBuilder("Emmettre un Son :\n");
            foreach (var personnage in PersonnageList)
            {
                resultat.AppendLine("- " + personnage.EmettreUnSon());
            }
            return resultat.ToString();
        }

        public string LancerCombat()
        {
            var resultat = new StringBuilder("Combat :\n");
            foreach (var personnage in PersonnageList)
            {
                resultat.AppendLine("- " + personnage.Combattre());
            }
            return resultat.ToString();
        }



        internal void ChangerComportement()
        {
            PersonnageList[0].ComportementCombat = new ComportementApiedAvecHache();
        }
    }
}
