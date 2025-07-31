namespace AlpaStock.Core.DTOs.Response.Auth
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string UserName { get; set; }
        public bool isSuspended { get; set; }
        public string ActiveSubcriptionName { get; set; }
        public DateTime ActiveSubcriptionEndDate { get; set; }
        public string FreeSubcriptionName { get; set; }
        public DateTime FreeSubcriptionEndDate { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool isSubActive { get; set; }
        public DateTime Created { get; set; }
        public List<string> AccessibleModule { get; set; }
    }
}
