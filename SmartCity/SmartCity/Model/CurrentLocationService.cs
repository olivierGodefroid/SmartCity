using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class CurrentLocationService
    {
        public async Task<IEnumerable<Model.CurrentLocation>> GetTypeInfrastructure()
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri(Constante.AddressApi + "/api/TypeInfrastructures"));
            Model.CurrentLocation[] returnedData = JsonConvert.DeserializeObject<Model.CurrentLocation[]>(json);
            return returnedData;
        }
    }
}
