using frameworks.data.Interface.Repositories;
using frameworks.service.Interface.Services;
using frameworks_model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworks.service.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa model)
        {
            var result = await mahasiswaRepository.Create(model);
            return result;
        }
        public async Task<List<Mahasiswa>> Get()
        {
            var result = await mahasiswaRepository.Get();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await mahasiswaRepository.Delete(id);
            return result;
        }
    }
}
