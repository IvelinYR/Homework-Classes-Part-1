namespace PhoneComponents
{
    using System;
    using System.Text;

    public class Call
    {
        private string data;
        private string time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string data, string time, string dialledPhoneNumber, int duration)
        {
            this.data = data;
            this.time = time;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.duration = duration;    
        }

        public string Data 
        {
            get
            {
                return this.data;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Data is not curect input");
                }
                this.data = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Data is not curect input");
                }
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dialled phone number is not curect input");
                }
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration 
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The minutes can not be negative number");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            var infoCall = new StringBuilder();

            infoCall.AppendFormat("Call Data - {0} \n",this.data);
            infoCall.AppendFormat("Call Time - {0} \n", this.time);
            infoCall.AppendFormat("Call DialledPhoneNumber - {0} \n", this.dialledPhoneNumber);
            infoCall.AppendFormat("Call Duration - {0} \n", this.duration);

            return infoCall.ToString();
        }
    }
}
