namespace Catalogue
{
    public class Product : IProduct
    {
        private List<int> products = new List<int> {1, 2, 3};

        public void addNewProduct(int id) {
            products.Add(id);
        }

        public void getAllProducts () {
            Console.WriteLine(string.Join(System.Environment.NewLine, products));
        }
    }
}