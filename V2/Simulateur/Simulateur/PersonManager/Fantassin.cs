using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
using System.Windows.Forms;
using System.Drawing;
namespace Simulateur.ManagerPerson
{
    class Fantassin : Personnages
    {

        public Fantassin(string unNom)
            : base(unNom)
        {

         // ComportementCombat = new ComportementApiedAvecHache();
        //  ComportementEmettreUnSon = new ComportementCrier();

        }
        public Boolean SeDeplacer(PictureBox[,] Espace, int LigneCadeu, int ColonneCadeu, string Order, Boolean EnPositionDeReceptionDesOrdres, string NomPersonne, Image img)
        {
            return base.SeDeplacer(Espace, LigneCadeu, ColonneCadeu, Order, EnPositionDeReceptionDesOrdres, NomPersonne, img);
        }
        private int Position = 0;
        public int PositionFantassin { get { return this.Position; } set { Position = value; } }
     
        public override string Afficher()
        {
            return "Fantassin " + Nom;
        }


     /*   public override string SeDeplacer()
        {
            return "Je marche à pied";
        }*/
    }
}
