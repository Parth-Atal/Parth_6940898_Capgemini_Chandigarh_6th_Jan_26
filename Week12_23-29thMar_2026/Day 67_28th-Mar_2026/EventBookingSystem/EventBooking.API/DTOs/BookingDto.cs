namespace EventBooking.API.DTOs
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int SeatsBooked { get; set; }
        public DateTime BookedAt { get; set; }
    }

    public class CreateBookingDto
    {
        public int EventId { get; set; }
        public int SeatsBooked { get; set; }
    }
}