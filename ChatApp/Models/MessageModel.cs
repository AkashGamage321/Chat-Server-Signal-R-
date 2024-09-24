using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class MessageModel
    {
        [Key]
        public int MessageId { get;set; }
        [ForeignKey("Sender")]
        public int SenderId { get;set; }
        public UserModel Sender { get;set; }
        public string Content { get;set ;}
        public DateTime SentDate {get; set; }

    }
}