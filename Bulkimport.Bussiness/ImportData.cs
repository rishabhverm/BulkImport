namespace Bulkimport.Bussiness
{
    public class ImportData
    {
        public Guid RecordId { get; set; }
        public string? CustomerName { get; set; } 
        public string? Email { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionDate { get; set; }
        public string? Status { get; set; }
        public string? SourceSystem { get; set; }

    }
   

}
