using Domain.Master;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Interfaces
{
    public interface ApplicationDBContext
    {
        DbSet<Appsetting> Appsettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}
