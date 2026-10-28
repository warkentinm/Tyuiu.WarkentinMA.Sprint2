using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.WarkentinMA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (m == 1 && n == 1)
            {
                return "Некорректные данные: m и n не должны характеризовать 1 января";
            }

            int prevDay, prevMonth;

            if (n > 1)
            {
                
                prevDay = n - 1;
                prevMonth = m;
            }
            else
            {
                
                prevMonth = m - 1;

                
                switch (prevMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        prevDay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevDay = 30;
                        break;
                    case 2:
                        
                        prevDay = 28;
                        break;
                    default:
                        
                        prevMonth = 12;
                        prevDay = 31;
                        break;
                }
            }

            return $"{prevDay}.{prevMonth}";
        }
    }
}
