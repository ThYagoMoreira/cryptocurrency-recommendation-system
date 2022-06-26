using System.Text.Json;

namespace External.CryptoData.BitcoinFees
{
    public class TransactionFeesSummary : BaseClient
    {
        private string url = "https://bitcoinfees.earn.com/api/v1/fees/list";
        private int DayCount { get; set; }
        private int MemCount { get; set; }
        private int MinDelay { get; set; }
        private int MaxDelay { get; set; }
        private int MinMinutes { get; set; }
        private int MaxMinutes { get; set; }

        public async Task<IEnumerable<RecommendedTransactionFees>?> GetTransactionFeesSummary() =>
            JsonSerializer.Deserialize<IEnumerable<RecommendedTransactionFees>>(await this.GetContent(url));
    }
}