using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.WarkentinMA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            var nextDate = (m, n) switch
            {
                (1, 31) => (g, 2, 1),
                (2, 28) => (g, 3, 1),
                (3, 31) => (g, 4, 1),
                (4, 30) => (g, 5, 1),
                (5, 31) => (g, 6, 1),
                (6, 30) => (g, 7, 1),
                (7, 31) => (g, 8, 1),
                (8, 31) => (g, 9, 1),
                (9, 30) => (g, 10, 1),
                (10, 31) => (g, 11, 1),
                (11, 30) => (g, 12, 1),
                (12, 31) => (g + 1, 1, 1),


                _ => (g, m, n + 1)
            };

            
            return $"{nextDate.Item3:D2}.{nextDate.Item2:D2}.{nextDate.Item1}";
        }
    }
}
