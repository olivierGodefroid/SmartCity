using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class LikeService
    {
        public async Task<IEnumerable<Model.Like>> GetTypeInfrastructure()
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri(Constante.AddressApi + "/api/TypeInfrastructures"));
            Model.Like[] returnedData = JsonConvert.DeserializeObject<Model.Like[]>(json);
            return returnedData;
        }
    }
}
