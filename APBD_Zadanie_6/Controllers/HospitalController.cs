using APBD_Zadanie_6.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controllers
{
    [ApiController]
    [Route("api/")]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository _hospitalRepository;
        [HttpPost]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorDTO doctors)
        {
            return Ok();

        }
        [HttpPost]
        public async Task<IActionResult> AddPrescription[FromBody];
    }
}
