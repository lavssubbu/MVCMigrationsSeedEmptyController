using System.ComponentModel.DataAnnotations;

namespace CMSMVCCodeFirstEFDemo.Models
{
    public class Customer //Entity Class
    {
        [Key]
        public int custId { get; set; }
        public string? custName { get; set; }
        public string?  custLoc { get; set; }
        public DateTime dateofbirth { get; set; }

        //Navigation property - one customer - many orders
        public List<Order>? orders { get; set; }

    }
}
