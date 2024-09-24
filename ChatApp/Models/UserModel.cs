using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
// dotnet ef database update 
namespace ChatApp.Models
{
    public class UserModel:IdentityUser
    {
        [Key]
        public int UserId { get;set; }
        public string Name { get;set; }
        public string Email {get;set; }
        public string PasswordHash { get;set; }
        
    }
}