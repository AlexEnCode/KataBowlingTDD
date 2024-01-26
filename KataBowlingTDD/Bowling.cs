using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace KataBowlingTDD
{
    public class Bowling
    {

        public int Tour { get; set; } = 10;
        public int Lancer { get; set; } = 2;
        public int Score{ get; set; }
        public int Bonus { get; set; }
        public int Quille { get; set; }

        public bool Jouer()
        {
            for (int i =1; i < Tour; i++)
            {
             
            }
            return true;
        }

        public void Round()
        {
            throw new NotImplementedException(); 

        }

        public void ScorePartie()
        { 
            throw new NotImplementedException(); 
        }
    }
}
