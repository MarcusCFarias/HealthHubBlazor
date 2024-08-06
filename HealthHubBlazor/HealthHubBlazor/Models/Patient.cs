namespace HealthHubBlazor.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Document { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Appointment> Meetings { get; set; } = new List<Appointment>();
    }
}
