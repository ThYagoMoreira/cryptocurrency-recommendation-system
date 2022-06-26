using System.Text.Json;

namespace External.CryptoData.BitcoinFees
{
    public class RecommendedTransactionFees : BaseClient
    {
        private string url = "https://bitcoinfees.earn.com/api/v1/fees/recommended";
        private int FastestFee { get; set; }
        private int HalfHourFee { get; set; }
        private int HourFee { get; set; }

        public async Task<RecommendedTransactionFees?> GetRecommendedTransactionFees() =>        
            JsonSerializer.Deserialize<RecommendedTransactionFees>(await this.GetContent(url));        
    }
}