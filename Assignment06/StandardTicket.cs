namespace Assignment06
{
    internal class StandardTicket:Ticket
    {
        public string  SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price,string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }
        public override string Print()
        {
            return base.Print()+$"|SeatNumber:{SeatNumber}|FinalPrice{CalculateFinalPrice()}";
        }

    }
}
