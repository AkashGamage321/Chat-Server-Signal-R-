using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ChatRoomUserModel
    {
        [Key]
        public int ChatRoomUserId { get;set;}
        [ForeignKey("User")]
        public int UserId { get;set ;}
        public UserModel User { get;set;}
        public DateTime JoinedDate {get;set; }
    }
}