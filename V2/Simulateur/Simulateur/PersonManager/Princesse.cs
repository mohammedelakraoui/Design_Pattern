using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.ManagerPerson
{
     class Princesse:Personnages
    {
       public Princesse(string unNom)
            : base(unNom)
        {
            ComportementEmettreUnSon = new ComportementParlerPrincesse();
        }
       public int RandomIntPosition()
       {
           Random r = new Random();
           int pos = int.Parse(r.Next().ToString().Substring(0, 2));
           while (pos > 10)
           {
               pos = r.Next();

           }
           return pos;

       }

    }
}
