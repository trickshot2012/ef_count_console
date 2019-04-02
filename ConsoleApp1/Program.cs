
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
				

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cart> carts = new List<Cart>();

            carts.Add(new Cart() { Id = 1, UserName = "Amit", ItemId = 121 });
            carts.Add(new Cart() { Id = 2, UserName = "Siva", ItemId = 122 });
            carts.Add(new Cart() { Id = 3, UserName = "Amit", ItemId = 123 });
            carts.Add(new Cart() { Id = 4, UserName = "Krishna", ItemId = 124 });

            var cnt = carts.Where(c => c.UserName == "Amit").Count();


            var cnt1 = carts.Count(c => c.UserName == "Amit");

            Console.WriteLine(cnt); //output: 2
            Console.WriteLine(cnt1); //output: 2
            Console.ReadKey();
        }
    }
    public class Cart
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ItemId { get; set; }
    }
}
