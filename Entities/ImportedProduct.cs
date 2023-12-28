using System.Globalization;

namespace Course.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double price)
        {
            price =  Price + CustomsFee;
            return price;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice(Price).ToString("F2", CultureInfo.InvariantCulture)
                + " (customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
