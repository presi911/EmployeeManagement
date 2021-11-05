using Services.Entities.Out;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<SEmployee>> ConsultarAsync();
        Task<IEnumerable<SEmployee>> ConsultarAsyncByID(int id);
        Task<IEnumerable<SEmployee>> CrearAsync(int id);

    }
}
