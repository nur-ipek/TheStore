
namespace TheStore.Core.Models
{
    public class OrderDetail
    {
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
