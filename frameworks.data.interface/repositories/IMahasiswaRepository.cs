using frameworks_model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing.CompositionExtensions;

namespace frameworks.data.Interface.Repositories
{
    public interface IMahasiswaRepository
    {
        public Task<bool> Create(Mahasiswa model);
        public Task<List<Mahasiswa>> Get();
        public Task<bool> Delete(int id);
    }
}
