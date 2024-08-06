namespace HealthHubBlazor.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Document { get; set; } = null!;
        public string CRM { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null!;
        public ICollection<Appointment> Meetings { get; set; } = new List<Appointment>();
    }
}
