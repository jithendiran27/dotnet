namespace ProductCatalogueService;

using ProductCatalogueEntity;

public interface ICustomerService {

    void registerNewCustomer(Customer customer);

    bool isExistingCustomer(Customer customer);
}