using Delivery.Logic.Interfaces;
using Delivery.Logic.Models;
using Delivery.Logic.Services;
using System;
using System.Collections.Generic;

namespace Delivery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IParcel> parcels = new List<IParcel>()
            {
                new Parcel(5, 6, 7, 1),
                new Parcel(5, 20, 7, 1),
                new Parcel(70, 6, 7, 1),
                new Parcel(100, 6, 7, 1),
            };
            IDeliveryService deliveryService = new DeliveryService();
            var orderSummary = deliveryService.GetOrderSummary(parcels);
            Console.WriteLine("Order summary:");
            Console.WriteLine("Parcels:");
            foreach(var el in orderSummary.Parcels)
            {
                Console.WriteLine($"Parcel Cost: {el.ParcelCost}");
            }
            Console.WriteLine($"Regular delivery cost: {orderSummary.RegularDelivery}");
            Console.WriteLine($"Speedy delivery cost: {orderSummary.SpeedyDelivery}");

        }
    }
}
