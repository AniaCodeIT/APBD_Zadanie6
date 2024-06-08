using APBD_Zadanie_6.DTOs;

namespace APBD_Zadanie_6.Interfaces
{
    public interface IHospitalRepository
    {
        public string AddDoctorAsync(DoctorDTO doctor);

        public string AddPrescriptionAsync(PrescriptionRequestDTO request);
    }
}
