using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
namespace Simulateur.Observateur
{
    class InterfaceJeu
    {
        private static InterfaceJeu _instance;
        static readonly object instanceLock = new object();
        private string etat = "";
        private FlowLayoutPanel Espace = null;
        private static List<int> Delete = new List<int>();
       
        private InterfaceJeu() 
         {
 
          }

        public static InterfaceJeu getInstance() 
          {
        if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
        {
            lock (instanceLock)
            {
	        if (_instance == null)          //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                _instance = new InterfaceJeu();
            }
        }
 
        return _instance;
            }

        public static  string  Afficher() {
            return "Order Etat major,Initialisation d'envirenement tous le monde a sa place...";
        }
   
        public void update(FlowLayoutPanel Espace,PictureBox Objet) {
            Point p;
            foreach (int pos in Delete) { 
            
       // Espace.GetChildAtPoint(Poi
            
            }
        
        
        }
        
       
    }
}
