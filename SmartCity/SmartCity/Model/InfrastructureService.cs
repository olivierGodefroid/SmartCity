using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class InfrastructureService
    {
        public async Task<IEnumerable<Model.Infrastructure>> GetTypeInfrastructure()
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri(Constante.AddressApi + "/api/Infrastructures"));
            Model.Infrastructure[] returnedData = JsonConvert.DeserializeObject<Model.Infrastructure[]>(json);
            return returnedData;
        }
    }
}
