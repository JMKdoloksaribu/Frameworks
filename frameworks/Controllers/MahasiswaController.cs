using frameworks.service.Interface.Services;
using frameworks.service.Services;
using frameworks_model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace frameworks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;
        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<Mahasiswa>> Get()
        {
            var result = await mahasiswaService.Get();
            return result;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await mahasiswaService.Delete(id);
            return Ok(result);
        }
    }
}
