namespace ProductCatalogueRepo;

using ProductCatalogueEntity;

public interface ICustomerRepo {

    List<Customer> getCustomers();

    void registerNewCustomer(Customer customer);

    bool isExistingCustomer(Customer customer);
}