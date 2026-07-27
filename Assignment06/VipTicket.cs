namespace Assignment06
{
    internal class VipTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFees { get; set; }
        public VipTicket(string movieName, decimal price, bool Loungeaccess, decimal Fees) : base(movieName, price)
        {
            LoungeAccess = Loungeaccess;
            ServiceFees = Fees;
        }

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax + ServiceFees;
        }
        public override string Print()
        {
            return base.Print()+ $"|Lounge:{(LoungeAccess ? "Yes" : "No")}, Service Fees: {ServiceFees}|FinalPrice{CalculateFinalPrice()}";
        }
    }
}
