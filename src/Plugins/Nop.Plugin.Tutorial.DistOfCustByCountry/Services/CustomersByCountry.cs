﻿using System;
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
    public class CustomersByCountry : ICustomersByCountry
    {
        private readonly IAddressService _addressService;
        private readonly ICountryService _countryService;
        private readonly ICustomerService _customerService;

        public CustomersByCountry(IAddressService addressService,
            ICountryService countryService,
            ICustomerService customerService)
        {
            _addressService = addressService;
            _countryService = countryService;
            _customerService = customerService;
        }

        public async Task<List<CustomersDistribution>> GetCustomersDistributionByCountryAsync()
        {
            var allCustomers = await _customerService.GetAllCustomersAsync();
            var customers = allCustomers.Where(c => c.ShippingAddressId != null).ToList().Select(c => new
                {
                    _countryService.GetCountryByAddressAsync(_addressService.GetAddressByIdAsync(c.ShippingAddressId ?? 0)).Result.Name,
                    c.Username
                }).GroupBy(c => c.Name)
                .Select(cbc => new CustomersDistribution { Country = cbc.Key, NoOfCustomers = cbc.Count() }).ToList();
            return customers;


        }
    }
}