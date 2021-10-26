using Delivery.Logic.Models;
using System.Collections.Generic;

namespace Delivery.Logic.Interfaces
{
    public interface IDeliveryService
    {
        double CalculateDeliveryCosts(IEnumerable<IParcel> parcels);

        double CalculateSpeedyDeliveryCosts(IEnumerable<IParcel> parcels);

        OrderSummary GetOrderSummary(IEnumerable<IParcel> parcels);
    }
}
