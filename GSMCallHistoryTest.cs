namespace PhoneComponents
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void testt()
        {
            Console.WriteLine("***************************Call History Test******************************");

            GSM samsung = new GSM("Galaxy S7", "Samsung", 1200, "Pesho"
                   , new Battery(BatteryType.Li_Ion, 16, 8), new Display(5, 87000000));
            

            samsung.AddCall(new Call("12.05.2016", "18:25", "0883765983", 183));
            samsung.AddCall(new Call("18.11.2016", "09:25", "0872712383", 455));
            samsung.AddCall(new Call("11.09.2016", "18:25", "0881289124", 15));
            samsung.AddCall(new Call("15.08.2016", "05:25", "0881244424", 567));
            samsung.AddCall(new Call("11.09.2016", "03:25", "0881546466", 456));
            samsung.AddCall(new Call("11.09.2016", "02:25", "0856262626", 766));
            samsung.AddCall(new Call("11.09.2016", "01:25", "0867896868", 116));
            samsung.AddCall(new Call("11.09.2016", "23:25", "0881324123", 690));
            samsung.AddCall(new Call("11.09.2016", "13:25", "0881234234", 235));
            
            for (int i = 0; i < samsung.CallHistory.Count; i++)
            {
                Console.WriteLine(samsung.CallHistory[i]);
            }

            Console.WriteLine("Calls price : ${0:F2}",samsung.GetTotalCallPrice(0.37m));

            Call longestCall = samsung.CallHistory[0];
            foreach (var call in samsung.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            samsung.DeleteCall(longestCall);
            Console.WriteLine("Calls Price without longest: ${0:f2}", samsung.GetTotalCallPrice(0.37m));

            samsung.ClearHistory();
            Console.WriteLine("Call history cleared!");
            Console.WriteLine();
        }
    }
}
