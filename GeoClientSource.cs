namespace AppSample
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class GeoClientSource
        {
            [JsonProperty("id")]
            public string ID { get; set; }

            [JsonProperty("houseNumber")]
            public string HouseNumber { get; set; }

            [JsonProperty("street")]
            public string Street { get; set; }

            [JsonProperty("borough")]
            public string Borough { get; set; }
        }
}
