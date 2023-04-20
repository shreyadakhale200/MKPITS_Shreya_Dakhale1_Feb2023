using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    abstract class movieInfo
    {
        public string movie_name;
        public string theater_name;
        public DateTime show_Time;
        public int seat_number;
        public double ticket_Price;
        public int number_ofTickets;
        public virtual double MovieTicket(string movie_name , double ticket_price, int number_ofTickets)
        {
            return ticket_price;
        }
    }

    class OnlineBooking : movieInfo
    {
        //public double discount = 20;

        public override double MovieTicket(string movie_name , double ticket_price, int number_ofTickets)
        {
            if(movie_name == "Forest Gump")
            {
                if(theater_name == "Inox")
                {
                    ticket_Price = 400;
                }
                else if(theater_name == "Tuli")
                {
                    ticket_Price = 250;
                }
                else
                ticket_Price = 300;
            }
            else if(movie_name == "Interstellar")
            {
                if (theater_name == "Inox")
                {
                    ticket_Price = 560;
                }
                else if (theater_name == "Tuli")
                {
                    ticket_Price = 510;
                }
                else
                    ticket_Price = 500;
            }
            else if(movie_name == "Rocket Boys")
            {
                if (theater_name == "Inox")
                {
                    ticket_Price = 210;
                }
                else if (theater_name == "Tuli")
                {
                    ticket_Price = 123;
                }
                else
                    ticket_Price = 200;
            }
            else if(movie_name == "Martian")
            {
                if (theater_name == "Inox")
                {
                    ticket_Price = 40;
                }
                else if (theater_name == "Tuli")
                {
                    ticket_Price = 20;
                }
                else
                    ticket_Price = 10;
            }
            ticket_Price = number_ofTickets * ticket_Price;
            return ticket_Price;
        }
    }

    class BoxOffice : movieInfo
    {
        public double booking_fees = 40;

        public override double MovieTicket(string movie_name , double ticket_price, int number_ofTickets)
        {
            ticket_Price = number_ofTickets + ticket_Price + booking_fees;
            return ticket_Price;
        }
    }

    internal class BookingTicket
    { 
       
    }
}
