using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Response
    {
        public List<Hotels> Hotel_list = new List<Hotels>();
        public  Hotels hotel;
        public Error Status;

    }
}