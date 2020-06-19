using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GetJsonData.Models
{
    public class Product
    {
        public int userId { get; set; }
        public int id { get; set; }

        [JsonPropertyName("img")]
        public string title { get; set; }
        
        
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
