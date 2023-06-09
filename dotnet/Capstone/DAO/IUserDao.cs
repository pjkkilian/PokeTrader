﻿using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IUserDao
    {
        User GetUser(string username);
        User AddUser(string username, string password, string role, string email, string streetAddress, string city, string stateAbbreviation, string zipCode);
        List<PublicCollectionUser> GetPublicUsers();

        void ChangeUsersToPremium(string userName);
        void ToggleCollectionPrivacy(string userName);
        public List<string> GetUsernamesBySearch(string searchString);

        List<string> GetUsernamesOfMyActiveTrades(string username);
    }
}
