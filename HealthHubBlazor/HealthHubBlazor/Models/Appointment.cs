﻿namespace HealthHubBlazor.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime CreationDate { get; set; }

        public Doctor Doctor { get; set; } = null!;
        public Patient Patient { get; set; } = null!;
    }
}