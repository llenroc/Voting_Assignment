﻿namespace votingFrontend.Models
{
    public class LoginResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string ElectoralId { get; set; }
        public bool VoteSaved { get; set; }
    }
}