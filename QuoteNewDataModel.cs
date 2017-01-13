using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Converted
{
    class QuoteNewDataModel
    {
        [JsonProperty("cid")]
        public string cid { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("up")]
        public double up { get; set; }
        [JsonProperty("amount")]
        public double amount { get; set; }
        [JsonProperty("qty")]
        public int qty { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("selected")]
        public Dictionary<string, selected> list { get; set; }
        public DateTime created { get; set; }
        [JsonProperty("disabled")]
        public bool disabled { get; set; }
    }
}
