using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FilterUser
    {
        public const string userName = "userName";
        public const string firstName = "firstName";
        public const string lastName = "lastName";
        public const string email = "email";
        


        public static IEnumerable<string> GetFilter()
        {
            var positions = new List<string>();
            positions.Add(userName);
            positions.Add(firstName);
            positions.Add(lastName);
            positions.Add(email);
            positions.Sort();
            return positions;
        }

    }
}
