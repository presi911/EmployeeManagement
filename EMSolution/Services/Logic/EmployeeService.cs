using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Services.DbServices;
using Services.Entities.Entry;
using Services.Entities.Out;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logic
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DBServicioContext _context;
        private readonly MapperConfiguration _mapperConfiguration;
        private readonly IMapper _mapper;

        public EmployeeService(DBServicioContext context, MapperConfiguration mapperConfiguration, IMapper mapper)
        {
            _context = context;
            _mapperConfiguration = mapperConfiguration;
            _mapper = mapper;

        }

        public IQueryable<Employee> ConsultarAsQueryable(Expression<Func<Employee, bool>> condicion)
        {
            try
            {
                return _context.Employees.Where(condicion);
            }
            catch (ArgumentNullException e)
            {
                throw;
            }
            catch (FormatException e)
            {
                throw;
            }
            catch (DbException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<IEnumerable<SEmployee>> ConsultarAsync()
        {

            var consulta = await _context.Employees.ProjectTo<SEmployee>(_mapperConfiguration).ToListAsync();
            return consulta;
        }

        public async Task<IEnumerable<SEmployee>> ConsultarAsyncByID(int id)
        {

            var employee = await _context.Employees.FindAsync(id);

            if (employee != null)
            {
                var employeeTable = _mapper.Map<SEmployee>(employee);

                return (IEnumerable<SEmployee>)employeeTable;

            }
            else
            {
                return null;
            }

        }

        public async Task<bool> CrearAsync(EEmployee dato)
        {
            try
            {

                var employeeBD = _mapper.Map<Employee>(dato);

                await _context.Employees.AddAsync(employeeBD);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (ArgumentNullException e)
            {
                 throw;
            }
            catch (InvalidOperationException e)
            {
               throw;
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw;
            }
            catch (DbUpdateException e)
            {
                throw;
            }
            catch (DbException e)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }

}
