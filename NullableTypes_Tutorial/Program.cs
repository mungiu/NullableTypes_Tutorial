using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //allows null to be assigned
            Nullable<DateTime> date = null;
            //same as above but shorter
            DateTime? date1 = null;

            Console.WriteLine($".GetValueOrDefault() " +    //compiles
                $"{date.GetValueOrDefault()}");
            Console.WriteLine($".HasValue {date.HasValue}");//compiles
            //Console.WriteLine($".Value {date.Value}\n");  //compile error use ".GetValueOrDefault"

            DateTime? newDate = new DateTime(2017, 12, 25);
            //DateTime newDate2 = newDate;    //doesn't work (what is newDate is null)
            DateTime newDate2 = newDate.GetValueOrDefault();
            DateTime? newDate3 = newDate2;  //NOTE: compatibility

            //////////////////// NULL COLESCING OPERATOR "??" /////////////////////
            DateTime? date3 = null;
            DateTime date4;

            //if (date3 != null)
            //    date4 = date3.GetValueOrDefault();
            //else
            //    date3 = DateTime.Today;

            //// ? - THE CONDITIONAL OPERATOR
            //date4 = (date3 != null) ? date.GetValueOrDefault()
                //: DateTime.Today;

            //?? - the NULL COLESCING OPERATOR. 
            // returns the left-hand operand if the operand is not null; 
            // otherwise it returns the right hand operand.
            date4 = date3 ?? DateTime.Today;

            Console.WriteLine(date4);
        }
    }
}
