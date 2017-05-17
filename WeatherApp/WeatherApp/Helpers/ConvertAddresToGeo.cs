using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace WeatherApp.Helpers
{
    public static class ConvertAddresToGeo
    {
        static readonly Geocoder GeoCoder = new Geocoder();

        public static async Task<Position> GetPosition(string address)
        {
            var approxLocations = await GeoCoder.GetPositionsForAddressAsync(address);
            return approxLocations.FirstOrDefault();
        }

        public static async Task<string> GetLocation(double lat, double lon)
        {
            var pos = new Position(lat, lon);
            var approxLocations = await GeoCoder.GetAddressesForPositionAsync(pos);
            var enumerable = approxLocations as string[] ?? approxLocations.ToArray();
            foreach (var address in enumerable)
            {
                Debug.WriteLine(address);
            }
            return enumerable.FirstOrDefault();
        }
    }
}
