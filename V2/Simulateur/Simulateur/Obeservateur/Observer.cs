using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simulateur.ManagerPerson;
using System.Drawing;
using System.Resources;
using System.Reflection;
using Simulateur.Singleton;
namespace Simulateur.Obeservateur
{
     class Observer
    {
        ProgressShowDialog progressDialog = null;
    //    private Archer PlayerArcher = null;
    //    private Chevalier PlayerChevalier = null;
    //    private Fantassin PlayerFantassin = null;
    //    private Cadeau cd = null;
    //    private Observer Init = null;
    //    public Archer PlayerArcherDecore { get { return PlayerArcher; } set { PlayerArcher = value; } }
    //    public Chevalier PlayerChevalierDecore { get { return PlayerChevalier; } set { PlayerChevalier = value; } }
    //    public Fantassin PlayerFantassinDecore { get { return PlayerFantassin; } set { PlayerFantassin = value; } }

        private Archer    PlayerArcher = null;
        private Chevalier PlayerChevalier = null;
        private Fantassin PlayerFantassin = null;
        private Decoder   deco = null;
        private PictureBox[,] Espace = null;
        private Cadeau cd = null;
        private int LIGNE = 0;
        private int COLONNE = 0;
      

        public virtual void InitilisationHandl(PictureBox[,] EspaceJeu) { 
        
       
         /*  this.PlayerArcher = new Archer("");
           this.PlayerChevalier = new Chevalier("");
           this.PlayerFantassin = new Fantassin("");
           this.cd = new Cadeau();
       
            //------------------------------------------
           string PosRowCol = this.PlayerArcher.RandomIntPosition().ToString();
           
           int posRow =int.Parse(PosRowCol.ToString().Substring(0,1));
           int posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
           EspaceJeu[posRow, posColon].Image = Properties.Resources.archer;
            //--------------------------------------------------
           //------------------------------------------
           PosRowCol = this.PlayerChevalier.RandomIntPosition().ToString();
            posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
            posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
           EspaceJeu[posRow, posColon].Image = Properties.Resources.chevalier;
            //--------------------------------------------------
           //------------------------------------------
           PosRowCol = this.PlayerFantassin.RandomIntPosition().ToString();
           posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
           posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
           EspaceJeu[posRow, posColon].Image = Properties.Resources.fantassin;
            //--------------------------------------------------
           //------------------------------------------
           PosRowCol = this.cd.RandomIntPosition().ToString();
           posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
           posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
           EspaceJeu[posRow, posColon].Image = Properties.Resources.cadeau;*/
            //--------------------------------------------------
        }

 
        public void ChargerSimulation(PictureBox[,] EspaceJeu,string NameArcher, string NameChevalier, string NameFantassin)
        {
            this.progressDialog = new ProgressShowDialog();
            this.PlayerArcher = new Archer(NameArcher);
            this.PlayerChevalier = new Chevalier(NameChevalier);
            this.PlayerFantassin = new Fantassin(NameFantassin);
            this.cd = new Cadeau();

            //------------------------------------------
           string PosRowCol = this.cd.RandomIntPosition().ToString();

            int posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
            int posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
            EspaceJeu[posRow, posColon].Image = Properties.Resources.cadeau;
            EspaceJeu[posRow, posColon].Enabled = false;    
            this.progressDialog = new ProgressShowDialog();
            progressDialog.LabelTitle.Text = "Initialisation du cadeu.....";
            progressDialog.StartProgress(progressDialog);
            //------------------------------------------
             PosRowCol = this.PlayerArcher.RandomIntPosition(0,0).ToString();
             this.progressDialog = new ProgressShowDialog();
            progressDialog.LabelTitle.Text = "Initialisation d'Archer.....";
             posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
             posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
            EspaceJeu[posRow, posColon].Image = Properties.Resources.archer;
            EspaceJeu[posRow, posColon].Tag = "archer";  
            progressDialog.StartProgress(progressDialog);
          
            //--------------------------------------------------
            //------------------------------------------
            PosRowCol = this.PlayerChevalier.RandomIntPosition(0,0).ToString();
         
            posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
            posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
            EspaceJeu[posRow, posColon].Image = Properties.Resources.chevalier;
            EspaceJeu[posRow, posColon].Tag = "chevalier";  
            this.progressDialog = new ProgressShowDialog();
            progressDialog.LabelTitle.Text = "Initialisation du chevalier.....";
            progressDialog.StartProgress(progressDialog);
            //--------------------------------------------------
            //------------------------------------------
            PosRowCol = this.PlayerFantassin.RandomIntPosition(0,0).ToString();
         
            posRow = int.Parse(PosRowCol.ToString().Substring(0, 1));
            posColon = int.Parse(PosRowCol.ToString().Substring(1, 1));
            EspaceJeu[posRow, posColon].Image = Properties.Resources.fantassin;
            EspaceJeu[posRow, posColon].Tag="fantassin";  
            this.progressDialog = new ProgressShowDialog();
            progressDialog.LabelTitle.Text = "Initialisation du fantassin.....";
            progressDialog.StartProgress(progressDialog);
            //--------------------------------------------------
            
          
        }
       
       
        public PictureBox[,] DesignMyGame(FlowLayoutPanel My) 
        {
            PictureBox[,] Espace = new PictureBox[11, 15];
            int col = 0;
            int lig = 0;
            foreach (PictureBox pic in My.Controls) {

                Espace[lig, col] = pic;
                Espace[lig, col].Image = null;
               
                col++;
                if (col % 15 == 0) {
                
                    col = 0;
                    lig++;
                }
            
            }

            return Espace;
        
        
        }
        
        public void GetPosition() { 
        
        
        }
        public void MiseAJour_(PictureBox[,] espace, int ligne, int colonne, int NextRow, int NextCol, string Tag)
        {

            this.cd = new Cadeau();
            LIGNE = int.Parse(cd.GetPositionCadeau(espace).Substring(0, 1));
            COLONNE = int.Parse(cd.GetPositionCadeau(espace).Substring(1, 1));
            espace[ligne, colonne].Tag = "";
            espace[ligne, colonne].Image = null;
            espace[NextRow, NextCol].Tag = Tag;
           
        }
    }
}
