using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoApiDadosDosEUA
{
    namespace QuickType
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class Temperatures
        {
            [JsonProperty("data")]
            public Datum[] Data { get; set; }

            [JsonProperty("source")]
            public Source[] Source { get; set; }
        }

        public partial class Datum
        {
            [JsonProperty("ID Nation")]
            public string IdNation { get; set; }

            [JsonProperty("Nation")]
            public string Nation { get; set; }

            [JsonProperty("ID Year")]
            public long IdYear { get; set; }

            [JsonProperty("Year")]
            public long Year { get; set; }

            [JsonProperty("Population")]
            public long Population { get; set; }

            [JsonProperty("Slug Nation")]
            public string SlugNation { get; set; }
        }

        public partial class Source
        {
            [JsonProperty("measures")]
            public string[] Measures { get; set; }

            [JsonProperty("annotations")]
            public Annotations Annotations { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("substitutions")]
            public object[] Substitutions { get; set; }
        }

        public partial class Annotations
        {
            [JsonProperty("source_name")]
            public string SourceName { get; set; }

            [JsonProperty("source_description")]
            public string SourceDescription { get; set; }

            [JsonProperty("dataset_name")]
            public string DatasetName { get; set; }

            [JsonProperty("dataset_link")]
            public Uri DatasetLink { get; set; }

            [JsonProperty("table_id")]
            public string TableId { get; set; }

            [JsonProperty("topic")]
            public string Topic { get; set; }

            [JsonProperty("subtopic")]
            public string Subtopic { get; set; }
        }
    }
}
