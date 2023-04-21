using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingSystem
{
    abstract class MovieTicket
    {
        public string MovieName { get;set; }
        public string TheatreName { get;set; }
        public string ShowTime { get;set; }
        public float  Price { get;set; }
        public abstract string TicketPrice(int NoOfTickets, float Price);
        
    }

    class OnlineBooking : MovieTicket
    {
        private float discount = 0.1f;
        public override string TicketPrice(int NoOfTickets,float Price)
        {
            float Tp = NoOfTickets * Price;
            float discountAmount = Price * discount;
            Tp = Price - discountAmount;
            return Tp.ToString();
        }
    }

    class BoxOffice : MovieTicket
    {
        private int BookingFees = 20;
        public override string TicketPrice(int NoOfTickets, float Price )
        {
            float Tp =NoOfTickets * Price + BookingFees;
            return Tp.ToString();
        }
    }
    internal class MovieTicketBooking
    {
    }
}
