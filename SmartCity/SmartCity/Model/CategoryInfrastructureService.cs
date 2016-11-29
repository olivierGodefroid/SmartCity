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
    public class CategoryInfrastructureService
    {
        public async Task<IEnumerable<Model.CategoryInfrastructure>> GetCategoryInfrastructure()
        {
            var wc = new HttpClient();
            var json = await wc.GetStringAsync(new Uri( Constante.AddressApi + "/api/CategoryInfrastructures"));
            Model.CategoryInfrastructure[] returnedData = JsonConvert.DeserializeObject<Model.CategoryInfrastructure[]>(json);
            return returnedData;

        }
    }
}
