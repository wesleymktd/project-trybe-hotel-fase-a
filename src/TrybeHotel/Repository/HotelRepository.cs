using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class HotelRepository : IHotelRepository
    {
        protected readonly ITrybeHotelContext _context;
        public HotelRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 4. Desenvolva o endpoint GET /hotel
        public IEnumerable<HotelDto> GetHotels()
        {
            var hotelsDto = _context.Hotels
                .Select(hotel => new HotelDto 
                {
                    hotelId = hotel.HotelId,
                    name = hotel.Name,
                    address = hotel.Address,
                    cityId = hotel.CityId,
                    cityName = hotel.City.Name,
                });

            return hotelsDto;
        }
        
        // 5. Desenvolva o endpoint POST /hotel
        public HotelDto AddHotel(Hotel hotel)
        {
            var city = _context.Cities.FirstOrDefault(c => c.CityId == hotel.CityId);

            var hotelAdd = new Hotel
            {
                Name = hotel.Name,
                Address = hotel.Address,
                CityId = city.CityId
            };

            _context.Hotels.Add(hotelAdd);
            _context.SaveChanges();

            return new HotelDto
            {
                hotelId = hotelAdd.HotelId,
                name = hotelAdd.Name,
                address = hotelAdd.Address,
                cityId = city.CityId,
                cityName = city.Name
            };

        }
    }
}