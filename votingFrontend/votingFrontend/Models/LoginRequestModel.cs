﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votingFrontend.Models
{
    public class LoginRequestModel
    {
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "dob")]
        public string Dob { get; set; }

        [JsonProperty(PropertyName = "electoralId")]
        public string ElectoralId { get; set; }
    }
}