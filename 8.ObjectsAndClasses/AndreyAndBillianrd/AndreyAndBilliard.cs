using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.BookLibralyModification
{

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> boughtProductAndQuantity { get; set; }
        public decimal Bill { get; set; }
    }

    class StartUp
    {

        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsStock = new Dictionary<string, decimal>();
            List<Customer> customersList = new List<Customer>();

            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string currentProduct = input[0];
                decimal currentPrice = decimal.Parse(input[1]);

                if (!productsStock.ContainsKey(currentProduct))
                {
                    productsStock.Add(currentProduct, 0.0M);
                }

                productsStock[currentProduct] = currentPrice;
            }

            string secondInput = Console.ReadLine();
            while (secondInput != "end of clients")
            {
                string[] command = secondInput.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];
                string product = command[1];
                int quantity = int.Parse(command[2]);

                if (productsStock.ContainsKey(product))
                {
                    bool customerIsPresent = false;
                    Customer customer = new Customer();

                    customer.Name = name;
                    customer.boughtProductAndQuantity = new Dictionary<string, int>();
                    customer.boughtProductAndQuantity.Add(product, quantity);
                    customer.Bill = productsStock[product] * quantity;

                    foreach (var writtenCustomer in customersList)
                    {
                        if (writtenCustomer.Name == customer.Name)
                        {
                            customerIsPresent = true;

                            if (writtenCustomer.boughtProductAndQuantity.ContainsKey(product))
                            {
                                writtenCustomer.boughtProductAndQuantity[product] += quantity;
                            }

                            else
                            {
                                writtenCustomer.boughtProductAndQuantity.Add(product, quantity);
                            }
                            writtenCustomer.Bill += productsStock[product] * quantity;
                        }
                    }

                    if (!customerIsPresent)
                    {
                        customersList.Add(customer);
                    }
                }

                secondInput = Console.ReadLine();
            }
            decimal totalBill = 0.0M;

            foreach (var customer in customersList.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var pair in customer.boughtProductAndQuantity)
                {
                    string custProduct = pair.Key;
                    int quantity = pair.Value;
                    Console.WriteLine($"-- {custProduct} - {quantity}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}