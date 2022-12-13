namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results
{
    public class GetProductProducerQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductStorage { get; set; }
        public bool ProductStatus { get; set; }
    }
}
