using Delivery.Logic.Enums;

namespace Delivery.Logic.Interfaces
{
    public interface IParcel
    {
        double Length { get; }

        double Width { get; }

        double Height { get; }

        double Weight { get; }

        ParcelSizeType ParcelSize { get; }

        double ParcelCost { get; }
    }
}
