namespace Assignment06
{
    internal partial class Cinema
    {
        public string  Name { get; set; }
        public Projector projector { get; }
        private Ticket[] tickets = new Ticket[20];
        public Cinema(string name)
        {
            Name= name;
            projector = new Projector();
        }
        public void Add(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return;
                }
            }
            Console.WriteLine("Cinema is Full");
        }
        public void OpenCinema()
        {
            Console.WriteLine("==========Cinema Opened=========");
            projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema Closed==========");
            projector.Stop();
        }
    }
}
