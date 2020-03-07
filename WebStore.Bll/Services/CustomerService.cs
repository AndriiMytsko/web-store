using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;
using WebStore.Dal.Entities;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.Bll.Services
{

    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(
            IMapper mapper,
            ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task CreateAsync(CustomerDto dto)
        {
            var entity = _mapper.Map<Customer>(dto);

            await _customerRepository.CreateAsync(entity);
        }

        public async Task<CustomerDto> GetAsync(int Id)
        {
            var entity = await _customerRepository.GetAsync(Id);
            var customer = _mapper.Map<CustomerDto>(entity);

            return customer;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllAsync()
        {
            var entities = await _customerRepository.GetAllAsync();
            var customers = _mapper.Map<IEnumerable<CustomerDto>>(entities);

            return customers;
        }

        public async Task UpdateAsync(CustomerDto dto)
        {
            var entity = await _customerRepository.GetAsync(dto.Id);
            entity.FirstName = dto.FirstName;
            entity.LastNAme = dto.LastName;
            entity.Phone = dto.Phone;

            await _customerRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _customerRepository.GetAsync(Id);
            if (entity == null)
            {
                return;
            }

            await _customerRepository.DeleteAsync(Id);
        }
    }
}