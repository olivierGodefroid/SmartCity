using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class UserService
    {
        public async Task<IEnumerable<Model.User>> GetTypeInfrastructure()
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri(Constante.AddressApi + "/api/Users"));
            Model.User[] returnedData = JsonConvert.DeserializeObject<Model.User[]>(json);
            return returnedData;
        }
    }
}
