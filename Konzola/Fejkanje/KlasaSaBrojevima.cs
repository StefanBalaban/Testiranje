using System;
using System.Collections.Generic;
using System.Text;

namespace Konzola.Fejkanje
{
    public interface IKlasaSaBrojevima
    {
        int DuplirajBroj(int broj);
    }
    public class KlasaSaBrojevima : IKlasaSaBrojevima
    {
        public int DuplirajBroj(int broj)
        {
            return 2 * broj;
        }
    }
}
