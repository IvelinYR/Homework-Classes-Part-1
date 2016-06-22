namespace PhoneComponents
{
    using System;
    using System.Text;

    public class Battery
    {
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        public Battery(BatteryType type, int timeIdle, int timeTalk)
        {
            this.hoursIdle = timeIdle;
            this.hoursTalk = timeTalk;
            this.type = type;
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {

                this.type = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery Idle Time should be a positive number");
                }
                this.hoursTalk = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Battery Idle Time should be a positive number");
                }
                this.hoursIdle = value;
            }
        }


        public override string ToString()
        {
            var batteryInfo = new StringBuilder();

            batteryInfo.AppendFormat("Battery model: {0}", this.type);

            batteryInfo.AppendFormat(", Hours idle: {0}", this.hoursIdle);

            batteryInfo.AppendFormat(", Hours talk: {0}", this.hoursTalk);

            return batteryInfo.ToString();
        }

    }
}
