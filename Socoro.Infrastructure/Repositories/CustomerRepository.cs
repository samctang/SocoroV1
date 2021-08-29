using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Socoro.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IRepositoryAsync<Customer> _repository;

        public CustomerRepository(IRepositoryAsync<Customer> repository)
        {
            _repository = repository;
        }

        public IQueryable<Customer> Customers => _repository.Entities;

        public async Task DeleteAsync(Customer customer)
        {
            await _repository.DeleteAsync(customer);
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            return await _repository.Entities.Where(p => p.Id == customerId).FirstOrDefaultAsync();
        }

        public async Task<List<Customer>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Customer customer)
        {
            await _repository.AddAsync(customer);
            return customer.Id;
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _repository.UpdateAsync(customer);
        }
        public async Task<List<Customer>> GetByCompanyIdAsync(int companyId)
        {
            return await _repository.Entities.Where(p => p.Company.Id == companyId).ToListAsync();
        }
    }
}