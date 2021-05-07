using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoupGarou
{
    public class Jour
    {
        int auto; //ici en static et par défaut =0.
        int lesMorts;//Non c'est une liste de Joueurs
        bool lEtat; //Par défaut égal à 0
        int lid;
        
        public Jour()
        {
            //auto s'incrément de 1
            //lid prend la valeur de auto.
        }
    }
}
