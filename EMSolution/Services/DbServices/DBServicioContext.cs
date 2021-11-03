using DataAccess.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DbServices
{
    public class DBServicioContext : EMDbContext
    {
        public DBServicioContext(DbContextOptions<DBServicioContext> options) : base(options)
        {

        }
    }
}
