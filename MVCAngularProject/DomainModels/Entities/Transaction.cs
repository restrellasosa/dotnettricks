using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Entities
{
    public class Transaction
    {
        public Transaction()
        {
            CreatedDate = DateTime.Now;
        }
        [Key]
        public int TransactionId { get; set; }
        public string PayMentId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Status { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int CartId { get; set; }
        public virtual User User { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
