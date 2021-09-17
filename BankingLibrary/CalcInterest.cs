using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest 
    {
        int ICalcInterest.Calculate(int principle, int RateOfInt, int years)
        {
            int SimpInt = (principle * years * RateOfInt) / 100;
            return SimpInt;
        }
    }

}
