using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Model
{
    public class TypeInfrastructureService
    {

        public async Task<IEnumerable<Model.TypeInfrastructure>> GetTypeInfrastructure(long idCategoryInfrastructure)
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri(Constante.AddressApi + "/api/TypeInfrastructures"));
            Model.TypeInfrastructure[] returnedData = JsonConvert.DeserializeObject<Model.TypeInfrastructure[]>(json);
            return returnedData;
        }
    }
}
