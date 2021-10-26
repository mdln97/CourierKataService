using Delivery.Logic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Logic.Services
{
    public class DeliveryService : IDeliveryService
    {
        public int CalculateDeliveryCosts(IEnumerable<IParcel> parcels)
        {
            return parcels.Sum(x => x.ParcelCost);
        }

        public int CalculateSpeedyDeliveryCosts(IEnumerable<IParcel> parcels)
        {
            return parcels.Sum(x => x.ParcelCost) * 2;
        }
    }
}
