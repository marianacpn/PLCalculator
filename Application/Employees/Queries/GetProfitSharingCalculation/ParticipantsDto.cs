using Shared.Extensions;
using System.Text.Json.Serialization;

namespace Application.Employees.Queries.GetProfitSharingCalculation
{
    public class ParticipantsDto
    {
        public ParticipantsDto(string registration, string nome, decimal profitSharingResult)
        {
            Registration = registration;
            Name = nome;
            PsResult = profitSharingResult;
        }

        [JsonPropertyName("matricula")]
        public string Registration { get; set; }

        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonIgnore]
        public decimal PsResult { get; }

        [JsonPropertyName("valor_da_participacao")]
        public string ProfitSharingValue => PsResult.ToStringCurrencyFormat();
    }
}
