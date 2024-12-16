using System.ComponentModel.DataAnnotations.Schema;

namespace CMSMVCCodeFirstEFDemo.Models
{
    public class Order
    {
        public int OrderId {  get; set; }
        public string? ProductName { get; set; }
        public DateTime? OrderDate { get; set; }
        public int CustId { get; set; }
        public decimal? CustAmount { get; set; }

        //Navigation property - one order - one customer
        [ForeignKey("CustId")]
        public Customer? customer { get; set; }
    }
}
