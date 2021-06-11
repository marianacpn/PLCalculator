using Newtonsoft.Json;
using Shared.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Application.Employees.Queries.GetProfitSharingCalculation
{
    public class ProfitSharingVm
    {
        public ProfitSharingVm(decimal availableValue, List<ParticipantsDto> participantes)
        {
            Participants = participantes;

            _totalEmployees = Participants.Count();
            _distributedTotal = Participants.Sum(e => e.PsResult);

            AvailableTotal = availableValue.ToStringCurrencyFormat();
            _totalBalance = availableValue - _distributedTotal;
        }

        [JsonPropertyName("participantes")]
        public IEnumerable<ParticipantsDto> Participants { get; set; }

        private int _totalEmployees;
        [JsonPropertyName("total_de_funcionarios")]
        public string TotalEmployees => _totalEmployees.ToString();

        private decimal _distributedTotal;
        [JsonPropertyName("total_distribuido")]
        public string DistributedTotal => _distributedTotal.ToStringCurrencyFormat();

        [JsonPropertyName("total_disponibilizado")]
        public string AvailableTotal { get; set; }

        private decimal _totalBalance;
        [JsonPropertyName("saldo_total_disponibilizado")]
        public string AvailableTotalBalance => _totalBalance.ToStringCurrencyFormat();

     
    }
}
