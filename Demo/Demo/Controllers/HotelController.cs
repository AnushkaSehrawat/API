using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo.Models;
namespace Demo.Controllers
{
    public class HotelController : ApiController
    {
      
        List<Hotels> Hotel_list = new List<Hotels>()
        {
            new Hotels
            {
                Name="ABC",
                Address="XYZ",
                NoOfRooms=2,
                AirportCode=3,
                HotelId=1,
            },
            new Hotels
            {
                Name="XYZ",
                Address="LMN",
                HotelId=3,
                NoOfRooms=3,
                AirportCode=23,


            }
        };

        public List<Hotels> GetHotels()
        {
            return Hotel_list;
        }

        public  Response  GetSpecificHotel(int id)
        {

            for (int i = 0; i < Hotel_list.Count; i++)
            {
                Hotels h = new Hotels();
                if (id == Convert.ToInt32(Hotel_list[h.HotelId]))
                {


                    return new Response()
                    {
                        hotel = Hotel_list[i],
                        Status =new Error()
                        {
                            Status=status.Success,
                        }
                        
                    };
                  

                }
                
            }
            
           
        }
      

    }
}
