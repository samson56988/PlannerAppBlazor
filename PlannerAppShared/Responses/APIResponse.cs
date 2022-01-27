using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerAppShared.Responses
{
    public class APIResponse
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }
    }

    public class APIResponse<T> : APIResponse
    {
        public T Value { get; set; }   
    }
}
