using Newtonsoft.Json;
using Shared.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Application.Employees.Queries.NewFolder
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

        private int _totalEmployees;
        [JsonProperty("total_de_funcionarios")]
        public string TotalEmployees => _totalEmployees.ToString();

        private decimal _distributedTotal;
        [JsonProperty("total_distribuido")]
        public string DistributedTotal => _distributedTotal.ToStringCurrencyFormat();

        [JsonProperty("total_disponibilizado")]
        public string AvailableTotal { get; set; }

        private decimal _totalBalance;
        [JsonProperty("saldo_total_disponibilizado")]
        public string AvailableTotalBalance => _totalBalance.ToStringCurrencyFormat();

        [JsonProperty("participantes")]
        public IEnumerable<ParticipantsDto> Participants { get; set; }
    }
}
