using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExceptions
{
    public class IdException : BaseException
    {
        public IdException(string message, string parametr) : base(message, parametr)
        {

        }
    }
}
