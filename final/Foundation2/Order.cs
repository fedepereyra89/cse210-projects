namespace Foundation2
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;
        private double totalPrice;
        private string packingLabel;

        public Order(List<Product> products, Customer customer)
        {
            this._products = products;
            this._customer = customer;
        }

        public double GetTotalPrice()
        {
            foreach (Product product in this._products)
            {
                totalPrice += product.GetTotalPrice();
            }
            switch (this._customer.IsInUSA())
            {
                case true:
                    totalPrice += 5;
                    break;

                case false:
                    totalPrice += 35;
                    break;
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            foreach (Product product in this._products)
            {
                packingLabel += $"Product Name: {product.GetName()}\nProduct ID: {product.GetProductId()}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Customer Name: {this._customer.GetName()}\nCustomer Address: {this._customer.GetAddress().GetAddressAsString()}";
        }
    }
}