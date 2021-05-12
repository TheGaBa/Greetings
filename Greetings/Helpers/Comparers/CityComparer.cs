using Greetings.Models;
using System.Collections.Generic;

namespace Greetings.Helpers.Comparers
{
    internal class CityComparer : IEqualityComparer<CityModel>
    {
        public bool Equals(CityModel obj1, CityModel obj2) => obj1.ID == obj2.ID;

        public int GetHashCode(CityModel obj) => obj.ID;
    }
}