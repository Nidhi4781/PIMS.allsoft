namespace PIMS.allsoft.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string WarehouseLocation { get; set; }
        public DateTime Timestamp { get; set; }
        public string Reason { get; set; }
        public string UserResponsible { get; set; }

        public Product Product { get; set; }
    }
}
