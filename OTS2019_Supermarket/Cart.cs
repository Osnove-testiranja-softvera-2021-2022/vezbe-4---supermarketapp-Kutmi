using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket
{
    public class Cart
    {
        //AddOneToCart
        //input: neki item
        //output: none

        //2. Sada smo se vratili iz test klase i resavamo problem Kart i liste..

        public List<Item> items;
        public int size;
        public double amount;

        public Cart()
        {
            items = new List<Item>();
            amount = 0;
            size = 0;
        }
        //Nakon konstruktora , krece prazna metoda.. Krenemo test , ne radi.. 
        //Resavamo dodavanjem size i itema.. Test OK
        public void AddOneToCart(Item item)
        {
            if(size >= 10)
            {
                throw new Exception("Number of items in cart must be 10 or less!");
            }
            items.Add(item);
            size++;
            amount += item.Price;
            //Pokrenuli smo test SizeGreaterThan10 , Failed..
            //resavamo sada tako sto napisemo if sa porukom (pre svega)
            //Fali nam isto i cena korpe , moramo i to kreirati kao parametar , refaktorisemo!
            
            //Mozemo prositi test metode sa proverom cene proizvoda ,
            //ako zelimo , ili prosledjenje praznog itema da li radi metoda
        }
        public void AddMultipleToCart(List<Item> itemsList)
        {
            if(size >= 10)
            {
                throw new Exception("Number of items in cart must be 10 or less!");
            }
            items.AddRange(itemsList);
            size += itemsList.Count;
            //amount += itemsList.Count * itemsList??.Price;
        }
    }
}
