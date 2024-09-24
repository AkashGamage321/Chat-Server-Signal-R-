using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ConnectionModel
    {
        [Key]
        public int ConnectionId { get;set ;}
        [ForeignKey("User")]
        public int UserId { get;set; }
        public UserModel User {get;set; }
        public bool IsConnected { get;set; }
    }
}