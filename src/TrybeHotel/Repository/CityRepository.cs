using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class CityRepository : ICityRepository
    {
        protected readonly ITrybeHotelContext _context;
        public CityRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 2. Desenvolva o endpoint GET /city
        public IEnumerable<CityDto> GetCities()
        {
            var allCities = (
                from city in _context.Cities
                select new CityDto
                {
                    cityId = city.CityId,
                    name = city.Name,
                }
            );

            return allCities;
        }

        // 3. Desenvolva o endpoint POST /city
        public CityDto AddCity(City city)
        {
            throw new NotImplementedException();
        }

    }
}