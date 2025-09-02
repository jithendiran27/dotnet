namespace Company
{
    public class Product {
        public int id;
        public string name;

        // public Product() {
        //     this.name = string.Empty;
        //     this.id = 0;
        // }

        public Product (string name, int id) {
            this.id = id;
            this.name = name;
        }

        public string getName() {
            return this.name;
        }

        public int getId() {
            return this.id;
        }
    }
}