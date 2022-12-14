using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Havas.Domain.Commons
{
    public class BaseResponse<T>
    {
        [JsonIgnore]
        public int Code { get; set; } = 200;
        public string Message { get; set; } = "Success";
        public T? Data { get; set; }
    }
}
