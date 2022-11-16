using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellingTicketOOP
{
    public class Staff
    {
        private const int PRICE = 5;
        private const double reduce = 0.1;
        private string[] movies = { "Black Adam", "Black Panther 2", "Detective Conan", "Doraemon", "Avengers: END GAME", "The way I love you" };

        public void PrintMovie()
        {
            Console.WriteLine("Choice your movies you want to watch: ");
            for (int i = 0; i < movies.Length; i++)
            {
                // Console.WriteLine(movies[i]);
                Console.WriteLine((i + 1) + ": " + movies[i]);
            }
        }
        public void PrintTicket(Ticket ticket)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("This is your tickets: ");
            Console.WriteLine("Movie name: " + ticket.Movie);
            Console.WriteLine("Number of tickets: " + ticket.Number);
            Console.WriteLine("Seats: " + ticket.Seats);
            // Console.WriteLine("Price: " + ticket.PRICE);
            // Console.WriteLine("Reduce: " + ticket.reduce);
            Console.WriteLine("---------------------");
        }

        public void PrintInvoice(Customer customer)
        {
            // calculate total payment based customer's ticket & vip
            double total = customer.MyTicket.Number * PRICE;
            if (customer.VIP == true)
            { total -= total * reduce; }

            Console.WriteLine("Total: " + total);
            Console.WriteLine();
            Console.WriteLine("------------------");
        }
        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovie();

                Customer customer = new Customer();
                int choice = customer.GetMovieChoice();
                int nTickets = customer.GetNumTicket();
                string seats = customer.GetSeats(nTickets);
                string movie = movies[choice];

                Ticket ticket = new Ticket(movie, seats, nTickets);

                PrintTicket(ticket);

                customer.MyTicket = ticket;
                customer.IsVIP();

                PrintInvoice(customer);

                selling = isContinue();
            }
        }
        private bool isContinue()
        {
            Console.Write("Continue (y/n): ");
            string isContinue = Console.ReadLine();
            return isContinue == "y";
        }
    }
}