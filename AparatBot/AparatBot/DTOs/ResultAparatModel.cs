using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatBot.DTOs
{
    public class ResultAparatModel<T> where T : class
    {
        public bool Success { get; set; }

        public string Error { get; set; }

        public T Value { get; set; }
    }

}
