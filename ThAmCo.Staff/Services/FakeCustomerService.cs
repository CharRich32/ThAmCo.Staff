using ThAmCo.Staff.Models;

namespace ThAmCo.Staff.Services {
    public class FakeCustomerService : ICustomerService {

        // Make static to have data persist through requests to service, for delete faking method 
        private static readonly List<CustomerGetDto> _customers = new() {
            new CustomerGetDto { Id = 1, Name = "Charlie Richardson", EmailAddress = "charlie.r@gmail.com", PhoneNumber = "03463 567890", AddressLine1 = "123 Lindrick Street", City = "Middlesbrough", County = "Redcar", PostCode = "TS11 8HT", AvailableFunds = 153.20 },
            new CustomerGetDto { Id = 2, Name = "Jason Ankers", EmailAddress = "jason.a@example.com", PhoneNumber = "05673 678301", AddressLine1 = "456 Birch Road", City = "Middlesbrough", County = "Redcar", PostCode = "TS1 1AA", AvailableFunds = 18.24 },
            new CustomerGetDto { Id = 3, Name = "Michael Smith", EmailAddress = "mike.smith@example.net", PhoneNumber = "03456 789012", AddressLine1 = "789 Smith Road", City = "Leeds", County = "West Yorkshire", PostCode = "LS1 4PL", AvailableFunds = 1143.10 },
            new CustomerGetDto { Id = 4, Name = "Sarah Brown", EmailAddress = "sarah.b@example.org", PhoneNumber = "04567 890123", AddressLine1 = "1010 Brown Lane", City = "Southend", County = "Essex", PostCode = "CB2 3PP", AvailableFunds = 9234.12 },
            new CustomerGetDto { Id = 5, Name = "Emma Collins", EmailAddress = "emma.collins@example.co.uk", PhoneNumber = "05678 901234", AddressLine1 = "1212 Wilson Street", City = "Manchester", County = "Greater Manchester", PostCode = "M1 1AE", AvailableFunds = 56782.11 },
            new CustomerGetDto { Id = 6, Name = "James Thomas", EmailAddress = "james.t@example.com", PhoneNumber = "06678 901235", AddressLine1 = "1313 Taylor Road", City = "York", County = "North Yorkshire", PostCode = "YO1 8ZB", AvailableFunds = 91.33 },
            new CustomerGetDto { Id = 7, Name = "Heather Green", EmailAddress = "heather.g@example.net", PhoneNumber = "07789 012345", AddressLine1 = "1414 Green Lane", City = "Hull", County = "Yorkshire", PostCode = "L1 4LN", AvailableFunds = 15.01 },
            new CustomerGetDto { Id = 8, Name = "Ethan White", EmailAddress = "ethan.w@example.co.uk", PhoneNumber = "08890 123456", AddressLine1 = "1515 White Avenue", City = "Norwich", County = "Norfolk", PostCode = "NR1 3QT", AvailableFunds = 311.44 },
            new CustomerGetDto { Id = 9, Name = "Harry Hall", EmailAddress = "harry.h@example.com", PhoneNumber = "09401 234567", AddressLine1 = "1616 Hall Street", City = "London", County = "London", PostCode = "S1 2BJ", AvailableFunds = 0 },
            new CustomerGetDto { Id = 10, Name = "Mason Mount", EmailAddress = "mason.m@example.net", PhoneNumber = "01512 345678", AddressLine1 = "1717 Lee Boulevard", City = "Birmingham", County = "West Midlands", PostCode = "B1 1AA", AvailableFunds = -143.30 }
        };

        public async Task<List<CustomerGetDto>> GetCustomersAsync() {
            return await Task.FromResult(_customers);
        }

        public async Task<CustomerGetDto?> GetCustomerAsync(int id) {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(customer);
        }

        public async Task<bool> DeleteCustomerAsync(int id) {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) {
                // Customer not found
                return false;
            }

            // Anonymise instead of deleting to keep order link
            customer.Name = "Anonymous";
            customer.EmailAddress = "anonymous@example.com";
            customer.PhoneNumber = "00000 000000";
            customer.AddressLine1 = "N/A";
            customer.AddressLine2 = "N/A";
            customer.City = "N/A";
            customer.County = "N/A";
            customer.PostCode = "N/A";
            customer.AvailableFunds = 0;
            return true;
        }


        private void AnonymiseCustomerData(int id) {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null) {
                // Replace personal information with anonymous data
                customer.Name = "Anonymous";
                customer.EmailAddress = "anonymous@example.com";
                customer.PhoneNumber = "000-000-0000";
                customer.AddressLine1 = "N/A";
                customer.City = "N/A";
                customer.County = "N/A";
                customer.PostCode = "N/A";
                // Optionally reset or anonymize other fields as needed
                // customer.AvailableFunds = 0; // For example, if you want to reset the funds
            }
        }


    }
}
