using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto: CountryCommonDto
    {
        public int Id { get; set; }
     
    }

}
