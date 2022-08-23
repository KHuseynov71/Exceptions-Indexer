using System;
using Exceptions__Indexer.Models;

namespace Exceptions__Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception NotAvailableException = new Exception();
            //Exception NotFoundException = new Exception();
            Room Neapol = new Room("Xazar",20,300);
            Neapol.IsAvailable = true;
            Room Hilton = new Room("Absheron",50,1500);
            Hilton.Name = "Absheron";
            Hilton.PersonCapacity = 50;
            Hilton.Price = 1500;
            Hilton.IsAvailable = false;

            Hilton.ShowInfo();
            Neapol.ShowInfo();
            Hotel Absheron = new Hotel("Absheron");
            Absheron.Name = "Absheron";




        }

    }
}
