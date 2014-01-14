using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.ManagerPerson;
using Simulateur.Obeservateur;
using System.Windows.Forms;
using Simulateur.Singleton;
using System.Threading;
using System.Drawing;
namespace Simulateur.Decorateur
{
   public class Decoration:Personnages
    {
       public void  GameOver() { 
       
       
       }
       private override int RandomIntPosition(int ligneCad, int ColCad)
       {
        return  base.RandomIntPosition(ligneCad,ColCad);
       }
        private Color CreateRandomColor()
        {
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

            return randomColor;
        }
        public void ChangeColor(FlowLayoutPanel panel) {

            foreach (PictureBox pic in panel.Controls)
            {
                pic.BackColor = CreateRandomColor();
            
            }
        }
    }
}
