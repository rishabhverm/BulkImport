namespace Bulkimport.Bussiness
{
    public class Entity
    {
        public Guid RecordId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public DateOnly TransactionDate { get; set; }
        public int Status { get; set; }
        public int SourceSystem { get; set; }

    }
   

}
