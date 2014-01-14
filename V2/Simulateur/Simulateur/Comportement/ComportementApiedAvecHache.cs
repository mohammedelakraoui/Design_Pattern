﻿#region ---------------- ComportementApiedAvecHache.cs ----------------------
/*
    Namespaces      WpfAventure.Metier.Comportements
    Classes         ComportementApiedAvecHache
 
    Date            2013 10 10
    Modif           2013 10 10
                    
    Auteur          Vincent LE CERF 
    Copyright       METAGENIA, 1999 - 2013
    URL             http://www.metagenia.net
    Email           codesource@metagenia.net
*/
#endregion ------------------------------------------------
namespace Simulateur.Comportement
{
    class ComportementApiedAvecHache : ComportementCombat
    {
        //-----------------------------------------------------------------------------
        public override string Combattre()
        {
           return "A pied et une hache";
        } 
    }
}
