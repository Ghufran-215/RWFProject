namespace RWFProject.Data.Models.Domain
{
    public class Registration
    {
        public string RegistrationId { get; set; }       // changed to string
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public string RegisteredBy { get; set; }
        public string RegistrationStatus { get; set; }
        public string Remarks { get; set; }
        public string RegistrationType { get; set; }

        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Department { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string NationalIdNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }


    }
}
