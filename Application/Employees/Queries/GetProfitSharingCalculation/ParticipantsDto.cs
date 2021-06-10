using Newtonsoft.Json;
using Shared.Extensions;

namespace Application.Employees.Queries.NewFolder
{
    public class ParticipantsDto
    {
        public ParticipantsDto(string registration, string nome, decimal profitSharingResult)
        {
            this.Registration = registration;
            this.Name = nome;
            PsResult = profitSharingResult;
        }

        [JsonProperty("matricula")]
        public string Registration { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }
   
        [JsonIgnore]
        public decimal PsResult { get; }

        [JsonProperty("valor_da_participacao")]
        public string ProfitSharingValue => PsResult.ToStringCurrencyFormat();
    }
}
