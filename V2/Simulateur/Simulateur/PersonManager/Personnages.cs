using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
using System.Threading;
using System.Windows.Forms;
using Simulateur.Singleton;
using Simulateur.Obeservateur;
using System.Drawing;
using Simulateur.Composite;
namespace Simulateur.ManagerPerson
{
    abstract class Personnages:Obeservateur.Observer
    {
        
        public string Nom { get; set; }
       public ComportementCombat ComportementCombat { get; set; }
       public ComportementEmettreUnSon ComportementEmettreUnSon { get; set; }
        private Archer PlayerArcher = null;
        private Chevalier PlayerChevalier = null;
        private Fantassin PlayerFantassin = null;
        private Decoder deco = null;
        private PictureBox[,] Espace = null;
        private Cadeau cd = Cadeau.getInstance();
        private Observer observateur = null;
        private int LIGNE = 0;
        private int COLONNE = 0;
        //---------------------------------------------------
        public  void MiseAjour(PictureBox[,] espace, int ligne, int colonne, int NextRow, int NextCol, string Tag)
        {
            observateur = new Observer();
            observateur.MiseAJour_(espace, ligne, colonne, NextRow, NextCol, Tag);
        }
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
          public Boolean SeDeplacer(PictureBox[,] Espace, int LigneCadeu, int ColonneCadeu, string Order, Boolean EnPositionDeReceptionDesOrdres,string NomPersonne,Image img)
       {
        //   order = new ListeOrder();
           Boolean find = false;
           int LignePersonne = int.Parse(RandomIntPosition(0,0).ToString().Substring(0, 1));  //int.Parse(GetPosition(Espace, NomPersonne).Substring(0, 1));
           int ColonnePersonne = int.Parse(RandomIntPosition(0,0).ToString().Substring(1, 1));//int.Parse(GetPosition(Espace, NomPersonne).Substring(1, 1));
           int OldRow=int.Parse(GetPosition(Espace, NomPersonne).Substring(0, 1));
           int OldCol=int.Parse(GetPosition(Espace, NomPersonne).Substring(1, 1));
           Espace[LignePersonne, ColonnePersonne].Image = img;
           MiseAjour(Espace, OldRow, OldCol, LignePersonne, ColonnePersonne, NomPersonne);
         //MessageBox.Show(LignePersonne + ":" + ColonnePersonne);
           if (LigneCadeu == LignePersonne && ColonneCadeu == ColonnePersonne)
           {


               find = true;
               
           }
           return find;
         

       }
       
        //-----------------------------------------------------------------------------
     /*   public void SeDeplacer(PictureBox[,] Espace, int LigneCadeu, int ColonneCadeu, string Order, Boolean EnPositionDeReceptionDesOrdres,string NomPersonne,Image img)
        {
         //   order = new ListeOrder();
            int LignePersonne = int.Parse(GetPosition(Espace, NomPersonne).Substring(0, 1));
            int ColonnePersonne = int.Parse(GetPosition(Espace, NomPersonne).Substring(1, 1));

            if (LigneCadeu == LignePersonne && ColonneCadeu == ColonnePersonne)
            {

                MessageBox.Show(""+NomPersonne +":Felicitation...c'est a vous le pouvoir");
                return;

            }
            if (LigneCadeu == LignePersonne && ColonneCadeu > ColonnePersonne && EnPositionDeReceptionDesOrdres == false)
            {

                Espace[LignePersonne, ColonnePersonne + 1].Image = img;
                MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne + 1, NomPersonne);

                return;

            }
            if (LigneCadeu == LignePersonne && ColonneCadeu < ColonnePersonne && EnPositionDeReceptionDesOrdres == false)
            {

                Espace[LignePersonne, ColonnePersonne - 1].Image = img;
                MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne - 1, NomPersonne);
                return;

            }
            if (LigneCadeu > LignePersonne && ColonneCadeu == ColonnePersonne && EnPositionDeReceptionDesOrdres == false)
            {

                Espace[LignePersonne, ColonnePersonne + 1].Image = img;
                MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne + 1, NomPersonne);

                return;

            }
            if (LigneCadeu < LignePersonne && ColonneCadeu == ColonnePersonne && EnPositionDeReceptionDesOrdres == false)
            {

                Espace[LignePersonne, ColonnePersonne - 1].Image = img;
                MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne - 1, NomPersonne);

                return;

            }
            if (LigneCadeu > LignePersonne && ColonneCadeu > ColonnePersonne)
            {
                if (Order.ToUpper() == "H")
                {

                    Espace[LignePersonne, ColonnePersonne + 1].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne + 1, NomPersonne);
                    if (ColonnePersonne + 1 == ColonneCadeu )
                    {
                      //  MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible  est en face de mes yeux,situer horizentalement, dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }
                if (Order.ToUpper() == "V")
                {

                    Espace[LignePersonne + 1, ColonnePersonne].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne + 1, ColonnePersonne, NomPersonne);
                    if (LignePersonne + 1 == LigneCadeu)
                    {
                  //      MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est  en face de mes yeux,situer verticalement, dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }

            }

            if (LigneCadeu < LignePersonne && ColonneCadeu > ColonnePersonne)
            {
                if (Order.ToUpper() == "H")
                {

                    Espace[LignePersonne, ColonnePersonne + 1].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne + 1, NomPersonne);
                    if (ColonnePersonne + 1 == ColonneCadeu)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est en face de mes yeux,situer horizentalement dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }
                if (Order.ToUpper() == "V")
                {

                    Espace[LignePersonne - 1, ColonnePersonne].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne - 1, ColonnePersonne, NomPersonne);
                    if (LignePersonne - 1 == LigneCadeu)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est  en face de mes yeux,situer verticalement, dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }

            }
            if (LigneCadeu < LignePersonne && ColonneCadeu < ColonnePersonne)
            {
                if (Order.ToUpper() == "H")
                {

                    Espace[LignePersonne, ColonnePersonne - 1].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne - 1, NomPersonne);
                    if (ColonnePersonne == ColonneCadeu - 1)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est en face de mes yeux,situer horizentalement dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }
                if (Order.ToUpper() == "V")
                {

                    Espace[LignePersonne - 1, ColonnePersonne].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne - 1, ColonnePersonne, NomPersonne);
                    if (LignePersonne - 1 == LigneCadeu)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est  en face de mes yeux,situer verticalement, dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }

            }
            if (LigneCadeu > LignePersonne && ColonneCadeu < ColonnePersonne)
            {
                if (Order.ToUpper() == "H")
                {


                    Espace[LignePersonne, ColonnePersonne - 1].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne, ColonnePersonne - 1, NomPersonne);
                    if (ColonnePersonne - 1 == ColonneCadeu)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est en face de mes yeux,situer horizentalement dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }
                if (Order.ToUpper() == "V")
                {

                    Espace[LignePersonne + 1, ColonnePersonne].Image = img;
                    MiseAjour(Espace, LignePersonne, ColonnePersonne, LignePersonne + 1, ColonnePersonne, NomPersonne);
                    if (LignePersonne + 1 == LigneCadeu)
                    {
                        MessageBox.Show("C'est "+NomPersonne+" N1, a votre  order Monsieur, la cible est  en face de mes yeux,situer verticalement, dans l'attente  des nouvelles orders ..");
                        EnPositionDeReceptionDesOrdres = true;
                    }
                    return;
                }

            }

        }
        */
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
        //-----------------------------------------------------------------------------
        public int RandomIntPosition(int ligneCad,int ColCad)
        {
            Random r = new Random();
            int Pos=  r.Next(10, 99);
           while(int.Parse(ligneCad+""+ColCad)==Pos){
           Pos= r.Next(10, 99);
           }
            
            return Pos;
        }
        public void PointDeVie() { }
        //-----------------------------------------------------------------------------
        public string GetPosition(PictureBox[,] espace,string Tag)
        {
            string Result = null;
            for (int lig = 0; lig < 10; lig++)
            {

                for (int col = 0; col < 14; col++)
                {
                    if (espace[lig, col].Tag == Tag)
                    {

                        Result = lig + "" + col;

                    }
                }


            }

            return Result;
        }
        //-----------------------------------------------------------------------------

    }
}

