namespace Assignment06
{
    internal class IMaxTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMaxTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
        }
        public decimal PriceAfter3D => Is3D ? PriceAfterTax + 30 : Price;

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax + (Is3D ? 30 : 0);
        }
        public override string Print()
        {
            return base.Print()+ $"|3D:{(Is3D ? $"Yes + (30) Price :{PriceAfter3D}" : "No")}|FinalPrice:{CalculateFinalPrice()}";
        }
    }
}
