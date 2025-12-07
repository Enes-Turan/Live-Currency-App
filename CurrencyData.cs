namespace LiveCurrencyApp.Models
{
    public class CurrencyData
    {
        public string Base_code { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
