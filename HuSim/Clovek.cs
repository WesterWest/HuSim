using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuSim
{
    class Clovek
    {
        private int vek;
        private int iq;
        private enum pohlaviEnum {muz, zena}

        public Clovek(int prumerIQrodicu)
        {
            Random random = new Random();
            vek = 0;
            //pohlaviEnum pohlavi = ()random.Next(1) + 1;

            //vygeneruje iq +- 20 od prumeru IQ rodicu
            iq = random.Next(40) + prumerIQrodicu - 20;
            //pokud je IQ mimo limit, tak vygeneruje nahodne IQ
            if(iq > 160 || iq < 70)
            {
                iq = random.Next(90) + 70;
            }
        }
    }
}
