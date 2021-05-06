using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Joueur : Client
    {
        public bool estActif;
        public bool estMort;
        public string leLogin;
        public int leNbreVote;
        public Role leRole;

        public Joueur()
        {

        }
    }
}
