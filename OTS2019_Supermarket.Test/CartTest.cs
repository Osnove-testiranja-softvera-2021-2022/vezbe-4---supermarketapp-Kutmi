using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OTS_Supermarket.Models;

namespace OTS_Supermarket.Test
{
    [TestFixture]
    public class CartTest
    {
        [Test]
        public void AddOneToCart_OKInput_Success()
        {
            //1. Pravimo objekte za nase elemente 
            Cart cart = new Cart();
            Keyboard keyboard = new Keyboard();
            //Act
            cart.AddOneToCart(keyboard);
            //Assert
            Assert.AreEqual(1, cart.size);

        }
        //3. Testiramo popunjenost, tj uslov zdt od 10 itema..
        [Test]
        public void AddOneToCart_SizeGreaterThan10_Success()
        {
            Cart cart = new Cart();

            Keyboard keyboard1 = new Keyboard();
            Keyboard keyboard2 = new Keyboard();
            Keyboard keyboard3 = new Keyboard();
            Keyboard keyboard4 = new Keyboard();
            Keyboard keyboard5 = new Keyboard();
            Keyboard keyboard6 = new Keyboard();
            Keyboard keyboard7 = new Keyboard();
            Keyboard keyboard8 = new Keyboard();
            Keyboard keyboard9 = new Keyboard();
            Keyboard keyboard10 = new Keyboard();

            cart.AddOneToCart(keyboard1);
            cart.AddOneToCart(keyboard2);
            cart.AddOneToCart(keyboard3);
            cart.AddOneToCart(keyboard4);
            cart.AddOneToCart(keyboard5);
            cart.AddOneToCart(keyboard6);
            cart.AddOneToCart(keyboard7);
            cart.AddOneToCart(keyboard8);
            cart.AddOneToCart(keyboard9);
            cart.AddOneToCart(keyboard10);

            //Testiramo 10. ekstra item, ocekujemo gresku
            //Ali nemamo poruku koju program izbacuje, moramo ju napisati
            Monitor monitor = new Monitor();
            //cart.AddOneToCart(monitor); <- ide u poruku, ovo je metoda koja inicra poruku.
            //<exception> hvatamo SVE exceptione
            Exception ex = Assert.Throws<Exception>(() => cart.AddOneToCart(monitor));
            //Proveri da li se ispisala bas excepcija koju mi zelimo..
            Assert.That(ex.Message, Is.EqualTo("Number of items in cart must be 10 or less!"));
        }

        //AddMultiple, pitamo se prvo sta je input, sta je output
        //Za domaci deleteAll, Print, Calculate; Brisanje , printovanje , 1 2 slucaja, kalkulacije imacemo vise slucajeva zvog restrikcija
        [Test]
        public void AddMultipleToCart_OKInput_Success()
        {
            //Objekti
            Cart cart = new Cart();
            Keyboard keyboard = new Keyboard();
         
            List<Item> keyboards = new List<Item>();

            keyboards.Add(keyboard);
            keyboards.Add(keyboard);
            keyboards.Add(keyboard);
            cart.AddMultipleToCart(keyboards);

            Assert.AreEqual(3, cart.size);
        }

        [Test]
        public void AddMultipleToCart_GreaterThan10 //VISE SLUCAJEVA??
        {
            //
        }
    }
}
