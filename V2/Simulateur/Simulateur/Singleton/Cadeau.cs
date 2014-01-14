using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulateur.Singleton
{

    public class Cadeau
    {
        // L’instance du singleton. Cette instance doit être privée et statique.
        private static Cadeau instance = null;
        // Pour éviter, lors de l’utilisation de multiple thread, que plusieurs singleton soit instanciés.
        private static readonly object myLock = new object();

        // La ressource ? partager.  
        private static  string Pos;
        // Des accesseurs pour cette ressources. 
        public static string Position { get { return Pos; } set { Pos = value; } }

        // Le constructeur d’un singleton est TOUJOURS privée. 

        // La méthode qui va nous permettre de récupérer l’unique instance de notre singleton.
        // La méthode doit être statique pour être appelé depuis le nom de la classe maClasse.getInstance();
        public static Cadeau getInstance()
        {
            //lock permet de s’assurer qu’un thread n’entre pas dans une section critique du code pendant qu’un autre thread s’y trouve.  
            //Si un autre thread tente d’entrer dans un code verrouillé, il attendra, bloquera, jusqu’à ce que l’objet soit libéré.
            lock (myLock)
            {
                // Si on demande une instance qui n’existe pas, alors on crée notre RessourceManager.
                if (instance == null)  instance = new Cadeau();

                // Dans tous les cas on retourne l’unique instance de notre RessourceManager.
                return instance;
            }
        }



        public int RandomIntPosition()
        {
            Random r = new Random();
            return r.Next(10, 99);

        }
        public   string  GetPositionCadeau(PictureBox[,] espace) {
           
            for (int lig = 0; lig < 10; lig++)
            {

                for (int col = 0; col < 15; col++)
                {
                    if (espace[lig, col].Enabled == false) {

                        Pos = lig + "" + col;
                        
                    }
                }


            }
            
            return Pos;
        }
    }
    }

