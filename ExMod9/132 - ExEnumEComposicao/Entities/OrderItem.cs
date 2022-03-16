using System.Globalization;

namespace _132___ExEnumEComposicao.Entities {
    class OrderItem {
        public Products Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Products product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal() {
            return Price * Quantity;
        }
        
        public override string ToString() {
            return $"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: ${Subtotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
        
    }
}
