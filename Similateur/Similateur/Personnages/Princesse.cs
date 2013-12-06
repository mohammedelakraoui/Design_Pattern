using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulateur.Comportement;
namespace Simulateur.Personnages
{
     class Princesse:Personnages
    {
       public Princesse(string unNom)
            : base(unNom)
        {
            ComportementEmettreUnSon = new ComportementParlerPrincesse();
        }
    }
}
