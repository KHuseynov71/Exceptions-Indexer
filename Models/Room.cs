using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__Indexer.Models
{
    public class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        
        public Room()
        {
            Id++;
            Id = _id;
        }
        public  void ShowInfo()
        {
            Console.WriteLine("Room name: "+ Name+ "\nRoom price: "+Price+"\nRoom person capacity: "+ PersonCapacity+ "\nRoom is available: "+IsAvailable);
          
        }
        public override string ToString()
        {
            ShowInfo();
            return "";
        }
        public Room(string Name,float Price,int PersonCapacity)
        {
             
        }
    }
}
