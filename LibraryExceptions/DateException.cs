using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExceptions
{
    public class DateException : BaseException
    {
        public DateException(string message, string parametr) : base(message, parametr)
        {

        }
    }
}
