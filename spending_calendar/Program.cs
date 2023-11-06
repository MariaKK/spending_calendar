using System;

namespace spending_calendar{
    class Program{
        static void Main(string[] args){
            var Event1 = new Event(){
                id = Guid.NewGuid(),
                name = "Dog_Food",
                linkedPayment = new Payment(){
                    currency = "rub",
                    id = Guid.NewGuid(),
                    price = 10,
                    status = false
                },
                timestamp = DateTime.Now
            };
            Console.WriteLine($"Event is: {Event1.name}");
            Console.WriteLine("Hello World!");
        } 
    
    }
}