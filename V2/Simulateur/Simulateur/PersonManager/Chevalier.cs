using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
using System.Drawing;
using System.Windows.Forms;
namespace Simulateur.ManagerPerson
{
    class Chevalier : Personnages
    {
        public Chevalier(string unNom)
            : base(unNom)
        {
           // ComportementCombat = new ComportementAcheval();
            //ComportementEmettreUnSon = new ComportementCrier();
        }
        public Boolean SeDeplacer(PictureBox[,] Espace, int LigneCadeu, int ColonneCadeu, string Order, Boolean EnPositionDeReceptionDesOrdres, string NomPersonne, Image img)
        {
          return  base.SeDeplacer(Espace, LigneCadeu, ColonneCadeu, Order, EnPositionDeReceptionDesOrdres, NomPersonne, img);
        }
        private int Position = 0;
        public int PositionChevalier { get { return this.Position; } set { Position = value; } }
   
        public override string Afficher()
        {
            return "Chevalier " + Nom;
        }

    /*    public override string SeDeplacer()
        {
            return "Je trotte, je galope";
        }*/
    }
}
