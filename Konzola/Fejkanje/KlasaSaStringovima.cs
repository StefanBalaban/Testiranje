using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.Fejkanje
{
    public class KlasaSaStringovima
    {
        private IKlasaSaBrojevima _klasaSaBrojevima;
        public KlasaSaStringovima(IKlasaSaBrojevima klasaSaBrojevima)
        {
            _klasaSaBrojevima = klasaSaBrojevima;
        }
        public string VratiDuploStringovano(int broj)
        {
            broj = _klasaSaBrojevima.DuplirajBroj(broj);
            return broj.ToString();
        }
    }
}
