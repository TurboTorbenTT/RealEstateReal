using System.Runtime.InteropServices.JavaScript;

namespace Realestate.Models;

public class Booking
{
  private IBookingDomainService _bookingDomainService;
  public Booking(DateTime startTime, DateTime endTime, RealEstatesE realEstatesE)
  {
    if (_bookingDomainService.IsOverlapping())
    {
      throw new ArgumentException();
    }
  }
}