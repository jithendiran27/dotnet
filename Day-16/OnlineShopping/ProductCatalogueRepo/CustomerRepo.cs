namespace ProductCatalogueRepo;

using ProductCatalogueEntity;

public class CustomerRepo: ICustomerRepo {

    public List<Customer> getCustomers() {
        return JSONCustomerManager.GetCustomersFromJson().ToList();
    }

    public void registerNewCustomer(Customer customer) {
        List<Customer> customers = getCustomers();
        customers.Add(customer);
        JSONCustomerManager.addCustomersInJson(customers);
    }

    public bool isExistingCustomer(Customer customer) {
        Customer foundCustomer = getCustomers().FirstOrDefault(checkCustomer => checkCustomer.emailId == customer.emailId);
        if (foundCustomer == null) {
            return false;
        } else if(foundCustomer.password == customer.password) {
            return true;
        }
        return false;
    }
}