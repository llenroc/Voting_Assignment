﻿// <copyright file="LoginUserResponse.cs" company="UCOL 3rd Year Bachelor of Information and Communication Assignment">
// Copyright (c) UCOL 3rd Year Bachelor of Information and Communication Assignment. All rights reserved.
// </copyright>

namespace VotingFrontend.Models
{
    using Newtonsoft.Json;
    using VotingFrontend.DatabaseTables;

    /// <summary>
    /// Response Model for Login
    /// </summary>
    public class LoginUserResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "result")]
        public UserVoteTable Result { get; set; }

        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        [JsonProperty(PropertyName = "unAuthorizedRequest")]
        public bool UnAuthorizedRequest { get; set; }
    }
}
