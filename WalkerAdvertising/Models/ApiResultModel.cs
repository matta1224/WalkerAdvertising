using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WalkerAdvertising.Models
{
    /// <summary>
    /// All API  results will be returned with this structure, allowing for  more complex result parsing
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResultModel<T>
    {
        /// <summary>
        /// The status ccode can be passed around seperate from the HttpResult.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
        public bool IsSuccessStatusCode => ((int)HttpStatusCode >= 200) && ((int)HttpStatusCode <= 299);

    }
}
