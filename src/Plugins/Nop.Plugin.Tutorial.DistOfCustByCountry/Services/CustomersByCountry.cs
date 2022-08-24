using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LinqToDB.DataProvider;
using Nop.Core.Domain.Customers;
using Nop.Data;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Models;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Directory;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Services
{
    internal class CustomersByCountry : ICustomersByCountry
    {
        private readonly IAddressService _addressService;
        private readonly ICountryService _countryService;
        private readonly ICustomerService _customerService;
        private readonly IRepository<Customer> _dataProvider;

        public CustomersByCountry(IAddressService addressService, ICountryService countryService, ICustomerService customerService)
        {
            _addressService = addressService;
            _countryService = countryService;
            _customerService = customerService;
        }

        //async Task<List<CustomersDistribution>> ICustomersByCountry.GetCustomersDistributionByCountryAsync()
        //{
        //    //_dataProvider.Table.Where(x => x.Active).Select(x => x);
        //    //return await _customerService.GetAllCustomersAsync().Result
        //    //    .Where(c => c.ShippingAddressId != null)
        //    //    .Select(c => new
        //    //    {
        //    //        await(_countryService.GetCountryByAddressAsync( await _addressService.GetAddressById(c.ShippingAddressId ?? 0))).Name,
        //    //        c.Username
        //    //    })
        //    //    .GroupBy(c => c.Name)
        //    //    .Select(cbc => new CustomersDistribution { Country = cbc.Key, NoOfCustomers = cbc.Count() }).ToList();
        //}
        public Task<List<CustomersDistribution>> GetCustomersDistributionByCountryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
