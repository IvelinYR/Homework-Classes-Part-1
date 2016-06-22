namespace PhoneComponents
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class GSM
    {

        private static GSM iphone4s = new GSM("Apple", "Iphone 4S", 1200, "John",
            new Battery(BatteryType.Li_Ion,18,6),new Display(5,12000000));
      
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string make, string model, decimal price, string owner, Battery battery, Display display)
        {
            CallHistory = new List<Call>();
            this.Manufacturer = make;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Model should begin whit capital letter");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (!char.IsUpper(value[0]) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer should begin whit capital letter");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Owner name should begin whit capital letter");
                }
                this.owner = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static GSM IPhone4S
        {
            get { return iphone4s; }
        }

        public List<Call> CallHistory { get;  set; }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void RemuveCall(int index)
        {
            CallHistory.RemoveAt(index);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        public decimal GetTotalCallPrice(decimal pricePerMinute)
        {
            decimal allCallInSecond = (decimal)(this.CallHistory.Select(x=>x.Duration).Sum());
            return pricePerMinute * (allCallInSecond / 60m);
        }

        public override string ToString()
        {
            var allInformation = new StringBuilder();

            allInformation.AppendFormat("Manufacturer: {0}\n", this.manufacturer);

            allInformation.AppendFormat("Model: {0}\n", this.model);

            allInformation.AppendFormat("Price: {0:C2}\n", this.price);

            allInformation.AppendFormat("Owner: {0}\n", this.Owner);

            allInformation.AppendFormat("Battery: {0}\n", this.battery);

            allInformation.AppendFormat("Display: {0}\n", this.display);

            return allInformation.ToString();
        }

    }
}
