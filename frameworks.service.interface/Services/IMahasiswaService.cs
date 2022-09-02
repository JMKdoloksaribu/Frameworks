using frameworks_model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworks.service.Interface.Services
{
    public interface IMahasiswaService
    {
            public Task<bool> Create(Mahasiswa model);
            public Task<List<Mahasiswa>> Get();
            public Task<bool> Delete(int id);
    }
}
