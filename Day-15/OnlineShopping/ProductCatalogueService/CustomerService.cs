namespace ProductCatalogueService;

using ProductCatalogueEntity;
using ProductCatalogueRepo;

public class CustomerService: ICustomerService {

    private readonly ICustomerRepo _customerRepo;

    public CustomerService(ICustomerRepo customerRepo) {
        _customerRepo = customerRepo;
    }

    public void registerNewCustomer(Customer customer) {
        _customerRepo.registerNewCustomer(customer);
    }

    public bool isExistingCustomer(Customer customer) {
        return _customerRepo.isExistingCustomer(customer);
    }
}