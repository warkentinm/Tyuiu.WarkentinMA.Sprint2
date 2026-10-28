using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.WarkentinMA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)

        {
            bool res = true;
            if (x <= 0 && x >= 1)
            {
                if (y >= 0 && y <= 1)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                
            }
            else
            {
                if (x >= 0.3 && x <= 1)
                {
                    if (y >= 0.3 && y <= 1)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            if (x > 1 || x < -1)
            {
                if (y  > 1 || y < -1)
                {
                    res = false;
                }
            }
            if (x > 0 && x < 0.3)
            {
                if (y < 0.3)
                {
                    res = false;
                }
            }
            return res;
            
        }
    }
}
