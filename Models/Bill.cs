namespace C_sharf_4_Ass_1.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserID { get; set; }
        public int Status { get; set; }
        public virtual IEnumerable<BillDetail> BillDetails { get; set; }
        public virtual User User { get; set; }
    }
}
