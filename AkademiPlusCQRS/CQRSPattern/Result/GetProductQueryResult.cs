namespace AkademiPlusCQRS.CQRSPattern.Result
{
    public class GetProductQueryResult //listelemek istediğimiz verileri getirecek (tümünü değil)
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
