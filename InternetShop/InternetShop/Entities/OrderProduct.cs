﻿namespace Entities
{
    public class OrderProduct: BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
