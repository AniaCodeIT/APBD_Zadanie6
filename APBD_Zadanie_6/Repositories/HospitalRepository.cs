using APBD_Zadanie_6.DTOs;
using APBD_Zadanie_6.Models;
using System.Data;

namespace APBD_Zadanie_6.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly Context _context;
        public HospitalRepository(Context context)
        {
            _context = context;
        }

        public string AddDoctorAsync(DoctorDTO doctor)
        {
            throw new NotImplementedException();
        }

        public async Task <string> AddPrescriptionAsync(PrescriptionRequestDTO request)
        {
            _context.Prescriptions.Add(request);
            await _context.SaveChangesAsync();
            return "success";
        }
    }
}
