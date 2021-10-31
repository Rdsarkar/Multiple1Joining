using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple1Joining.DTOs
{
    public class ResponseDto
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public object Payload { get; set; }
    }
}
