using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    public static class CommonRegularExpressionValidationPatterns
    {
        public const string Email_Address_RegEx_Pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        public const string SA_PhoneNumber_RegEx_Pattern = @"^(?:\+27|27|0)(6[0-9]|7[0-9]|8[1-9]|10|11|12|13|14|15|16|17|18|21|31|41|51|61)[0-9]{7}$";

        public const string SA_Postal_Code_RegEx_Pattern = @"^\d{4}$";

        public const string Strong_Password_RegEx_Pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
    }
}
