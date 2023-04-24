using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    abstract class Train
    {
        public int Id;
        public string trainName {get;set;}
        public string source { get;set;}
        public string destination { get;set;}
        public int capacity;
    }
    class Passenger:Train
    {
        public int passengerId;
        public string Name { get;set;}
        public string Address { get;set;}
        public double phone { get; set; }
    internal class Reservation
    {
    }
}
