using Delivery.Logic.Interfaces;
using Delivery.Logic.Models;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Logic.Services
{
    public class DeliveryService : IDeliveryService
    {
        public double CalculateDeliveryCosts(IEnumerable<IParcel> parcels)
        {
            return parcels.Sum(x => x.ParcelCost);
        }

        public double CalculateSpeedyDeliveryCosts(IEnumerable<IParcel> parcels)
        {
            return parcels.Sum(x => x.ParcelCost) * 2;
        }

        public OrderSummary GetOrderSummary(IEnumerable<IParcel> parcels)
        {
            double speedyDeliveryCost = CalculateSpeedyDeliveryCosts(parcels);
            double deliveryCost = CalculateDeliveryCosts(parcels);

            return new OrderSummary(parcels, speedyDeliveryCost, deliveryCost);
        }
    }
}
