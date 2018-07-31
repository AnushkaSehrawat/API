using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Error
    {
        public status Status;
        public string message;
        public int ErrorCode;
    }

    public enum status
    {
        Success,
        Error,
        Warning

    }
}