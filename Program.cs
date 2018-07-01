using System;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBusinessLogic _cus = new CustomerBusinessLogic();
            Console.WriteLine(_cus.GetCustomerName(1));
        }
    }

    class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;
        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetDataAccessObject();
        }
        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
    class DataAccessFactory
    {
        public static ICustomerDataAccess GetDataAccessObject()
        {
            return new CustomerDataAcces();
        }
    }
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
    class CustomerDataAcces:ICustomerDataAccess
    {
        public CustomerDataAcces()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Data need to be returned!";
        }
    }
}
