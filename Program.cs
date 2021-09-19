using System;

namespace Problem1_CalCulate_Mobile_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            double tk = 0 ;
            DateTime date1 = new DateTime(2019, 8, 31, 08, 59, 13); // Start Time
            DateTime date2 = new DateTime(2019, 8, 31, 09, 00, 39); // End Time
            TimeSpan ts = date2 - date1;

            int twenty = Convert.ToInt32((ts.TotalSeconds / 20));
            if (ts.TotalSeconds % 20 != 0)
            {
                twenty += 1;
            }

            for (int i = 1; i <= twenty; i++)
            {
                date1 = date1.AddSeconds(21);
                if (date1.TimeOfDay > new TimeSpan(09, 00, 00) && date1.TimeOfDay < new TimeSpan(10, 59, 59))
                {
                    tk += 30; // For Peak Hour, 30 Paisa
                }
                else
                {
                    tk += 20; // For Off-peak Hour, 20 Paisa
                }
            }
            Console.WriteLine(tk/100+" taka"); // Output
        }
    }
}
