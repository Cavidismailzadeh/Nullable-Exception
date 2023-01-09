using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabe_Exception
{
    public class InvalidFactorialException : Exception
    {
        
        public InvalidFactorialException(string message) : base (message) { }
      
    
    }
}
