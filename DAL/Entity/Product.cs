namespace DesignPattern.CQRS.PresentationLayer.DAL.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public decimal ProductSalePrice { get; set; }
        public string ProductBarcode { get; set; }
        public int ProductKdv { get; set; }
        public string ProductCode { get; set; }
        public int ProductStock { get; set; }
        public int ProductMinStock { get; set; }
        public int ProductMaxStock { get; set; }
        public string ProductSizeType { get; set; }
        public decimal ProductSizeAmount { get; set; }
        public string ProductCategory { get; set; }
        public string ProductStorage { get; set; }
        public bool ProductStatus { get; set; }
    }
}
