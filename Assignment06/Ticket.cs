namespace Assignment06
{
    internal abstract class Ticket:IBookable,IPrintable
    {
        public string MovieName { get; set; }
        private decimal price;
        private static int Counter = 0;
        public int TicketId { get; }
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("Invalid Number");
            }
        }
        public decimal PriceAfterTax => Price * 1.14m;

        public bool isBooked = false;
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            Counter++;
            TicketId = Counter;
        }
        public bool Book()
        {
            if (isBooked == false)
            {
                isBooked = true;
                return true;
            }
            else
                return false;
        }
        public bool Cancel()
        {
            if (isBooked == true)
            {
                isBooked = false;
                return true;
            }
            else
                return false;
        }

        public abstract decimal CalculateFinalPrice();
        public virtual string Print()
        {
            return $"Ticket # {TicketId} |{GetType().Name}|{MovieName} | Price: {Price}|After Tax : {PriceAfterTax}|Booked:{(isBooked ? "Yes" : "No")}";
        }
    }
}
