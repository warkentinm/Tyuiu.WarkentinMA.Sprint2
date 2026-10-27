using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.WarkentinMA.Sprint2.Task3.V7.Lib
{
    public class DataService : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            double y;
            y = 0;
            if (x > 1)
            {

                y = x * Math.Pow(Math.Pow(x, 2) + 1 / (x - 1), x);

            }

            if (x == 0)
            {
                y = (x - Math.Cos(x) + 10) / (x - Math.Sin(x) + 12);



            }

            if ((x > -11) && (x < 2) && x != 0)
            {

                y = Math.Pow((7 + (1 / Math.Pow(x, 2))), 2);

            }

            if (x < -11)
            {

                y = Math.Pow(x, 4) - (3 / x);

            }
            return Math.Round(y, 3);
        }
    }

}
