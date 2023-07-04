using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Papillon.Stades
{
    internal class Chrysalide : StadeLepidoptere
    {
        public Chrysalide()
        {

        }

        public override StadeLepidoptere SeMetamorphoser()
        {
            return new Papillon();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne me déplace pas !");
        }
    }
}
