using System.Collections.Generic;

namespace Delivery.Logic.Interfaces
{
    public interface IDeliveryService
    {
        int CalculateParcelDeliveryCosts(IEnumerable<IParcel> parcels);
    }
}
