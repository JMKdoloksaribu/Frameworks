using frameworks.data.Interface.Repositories;
using frameworks.service.Interface.Services;
using frameworks.service.Services;
using frameworks_model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworks_data.repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDbService _dbService;

        public MahasiswaRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa model)
        {
            await _dbService.ModifyData("insert into mahasiswa " +
                "(id, nama, alamat, usia, jurusan_id)" +
                "values" +
                "(@Id, @Nama, @Alamat, @Usia, @JurusanId)", model);
            return true;
        }

        public async Task<List<Mahasiswa>> Get()
        {
            var result = await _dbService.GetData<Mahasiswa>("select * from mahasiswa", new {});
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            await _dbService.ModifyData("delete from mahasiswa " +
                "where id = @Id" ,new { id } );
            return true;
        }
    }
}
