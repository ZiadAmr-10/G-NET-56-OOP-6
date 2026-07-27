namespace Assignment06
{
    internal partial class Cinema
    {
        public Ticket[] Tickets => tickets;
        public void PrintAll()
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null)
                    Console.WriteLine(ticket.Print());  
                else
                    return;
            }
        }
        
    }
}
