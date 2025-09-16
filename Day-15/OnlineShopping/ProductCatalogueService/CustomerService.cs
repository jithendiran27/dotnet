namespace ProductCatalogueService;

using ProductCatalogueEntity;
using ProductCatalogueRepo;

public class CustomerService: ICustomerService {

    private readonly CustomerRepo _customerRepo;

    public CustomerService(CustomerRepo customerRepo) {
        _customerRepo = customerRepo;
    }

    public void registerNewCustomer(Customer customer) {
        _customerRepo.registerNewCustomer(customer);
    }

    public bool isExistingCustomer(Customer customer) {
        return _customerRepo.isExistingCustomer(customer);
    }
}