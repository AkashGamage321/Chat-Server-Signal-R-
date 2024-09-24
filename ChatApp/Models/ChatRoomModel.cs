using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ChatRoomModel
    {
        [Key]
        public int ChatRoomId{ get;set; }
        public string Name { get;set;}
        public DateTime CreatedDate {get;set; }

    }
}