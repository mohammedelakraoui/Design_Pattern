using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
using System.Windows.Forms;
using System.Drawing;
using Simulateur.Singleton;
using Simulateur.Obeservateur;
namespace Simulateur.ManagerPerson
{
    class Archer : Personnages
    {
        public Archer(string unNom)
            : base(unNom)
        {
         //   ComportementCombat = new ComportementAvecArc();
         //   ComportementEmettreUnSon = new ComportementParler();
        }
       
        private int Position = 0;
        public int PositionArcher { get { return this.Position; } set { Position = value; } }
      //  public override int RandomIntPosition() {
        //    base(RandomIntPosition);
      //  }
    
        public override string Afficher()
        {
            return "Archer " + Nom;
        }

        public Boolean SeDeplacer(PictureBox[,] Espace, int LigneCadeu, int ColonneCadeu, string Order, Boolean EnPositionDeReceptionDesOrdres, string NomPersonne, Image img)
        {
            return base.SeDeplacer(Espace, LigneCadeu, ColonneCadeu, Order, EnPositionDeReceptionDesOrdres, NomPersonne, img);
        }

       public void AnalyseSituation(PictureBox[,] Espace)
       {
           for (int lig = 0; lig < 10; lig++)
           {

               for (int col = 0; col < 14; col++)
               {

               }


           }
        
        }

        public void Excution() { 
        
        }

    }
}
