using Microsoft.EntityFrameworkCore;
using RentACarApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp.Tests.Mocks
{
    static class DatabaseMock
    {
        public static RentACarAppDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<RentACarAppDbContext>()
                    .UseInMemoryDatabase("RentACarAppInMemoryDb" + DateTime.Now.Ticks.ToString())
                    .Options;

                return new RentACarAppDbContext(dbContextOptions, false);
            }
        }
    }
}
