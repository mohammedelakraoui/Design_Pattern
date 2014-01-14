#region ---------------- ComportementEmettreUnSon.cs ----------------------
/*
    Namespaces      WpfAventure.Metier.Comportementsr
    Classes         ComportementEmettreUnSon
 
    Date            2013 10 10
    Modif           2013 10 10
                    
    Auteur          Vincent LE CERF 
    Copyright       METAGENIA, 1999 - 2013
    URL             http://www.metagenia.net
    Email           codesource@metagenia.net
*/
#endregion --------------------------------------------------
using System.Media;
using WMPLib;
namespace Simulateur.Comportement
{
    abstract public class ComportementEmettreUnSon
    {
        public abstract string EmmettreSon();
        
    }
}
