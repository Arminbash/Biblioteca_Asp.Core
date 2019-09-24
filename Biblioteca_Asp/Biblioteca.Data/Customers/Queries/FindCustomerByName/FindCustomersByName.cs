using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Biblioteca.Data.Customers.Queries.GetCustomersList;
using Biblioteca.Data.Interfaces;
using Entities;

namespace Biblioteca.Data.Customers.Queries.FindCustomerByName
{
    public class FindCustomersByName : IRequest<CustomersListViewModel>
    {
        public string Name { get; }

        public FindCustomersByName(string name)
        {
            Name = name;
        }

        public class Handler : IRequestHandler<FindCustomersByName, CustomersListViewModel>
        {
            private readonly IBibliotecaDbContext _context;

            public Handler(IBibliotecaDbContext context)
            {
                _context = context;
            }

            public async Task<CustomersListViewModel> Handle(FindCustomersByName request, CancellationToken cancellationToken)
            {
                return new CustomersListViewModel
                {
                    Customers = await _context.Set<Customer>()
                        .Where(c => c.CompanyName.Contains(request.Name))
                        //.Where(c => c.CompanyName.StartsWith(request.Name))
                        //.Where(c => c.CompanyName.Equals(request.Name))
                        .Select(c => new CustomerLookupModel()
                        {
                            Name = c.CompanyName,
                            Id = c.CustomerId
                        })
                        .ToListAsync(cancellationToken)
                };
            }
        }
    }
}
