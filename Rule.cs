using System.Text.Json.Serialization;

namespace ASPNET
{
    public class Rule
    {

        public int Id { get; set; }
        [JsonPropertyName("Rule")]
        public string RuleText { get; set; }
        public string Description { get; set; }

    }
}
