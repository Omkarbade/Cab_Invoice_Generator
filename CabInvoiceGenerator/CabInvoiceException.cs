using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
         //Exception Class
        public class CabInvoiceException : Exception
        {
            public ExceptionType type;
            //ExcecptionType enum
            public enum ExceptionType
            {
                INVALID_DISTANCE,
                INVALID_TIME,
                NULL_RIDES,
                INVALID_RIDETYPES,
                INVALID_USER_ID
            }
            /// Initializes a new instance of the <see cref="CabInvoiceException"/> class.
 
            public CabInvoiceException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
}
