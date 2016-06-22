namespace PhoneComponents
{
    
    using System;

    public static class GsmTest
    {
        public static void test()
        {
            Console.WriteLine("********************************GSM Test********************************");

            GSM[] phoneArray = new GSM[]
            {
                new GSM("Iphone 6S", "Apple", 1400, "Pesho",
                    new Battery(BatteryType.Li_Ion,18,6),new Display(5,99000000)),
                new GSM("Galaxy S7", "Samsung", 1200, "Stoycho"
                    ,new Battery(BatteryType.Li_Ion,16,8),new Display(5,87000000)),
                new GSM("Galaxy Note 5", "Samsung", 950, "Kiro",
                    new Battery(BatteryType.Li_Ion,17,7),new Display(5,97000000))
            };

            foreach (var phone in phoneArray)
            {
                Console.WriteLine(phone);
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
