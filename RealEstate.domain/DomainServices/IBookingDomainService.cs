using Realestate.Models;

namespace RealEstate.domain.DomainServices;

public interface IBookingDomainService
{
  bool IsBookingOverlapping(Booking booking);
}