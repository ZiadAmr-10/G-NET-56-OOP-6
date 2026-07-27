namespace Assignment06
{
    internal static class ServiceCinema
    {
        public static void Receipt(this Ticket ticket) 
        {
            Console.WriteLine($"====================Receipt=====================\nMovie Name: {ticket.MovieName}\nType: {ticket.GetType().Name}\nPrice:{ticket.Price}\nFinal Price: {ticket.CalculateFinalPrice()}\nStatus:{(ticket.isBooked ? "Booked" : "NotBooked")}\n==================================================");
              
        }
        public static decimal TotalRevenue(this Ticket[] ticket) 
        {
            decimal total = 0;
            foreach (var T in ticket)
            {
                if (T != null)
                    total += T.CalculateFinalPrice();
            }
            return total;
        }
    }
}
