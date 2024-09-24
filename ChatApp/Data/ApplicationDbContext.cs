using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {

        }
        public DbSet<ChatRoomModel> ChatRooms {get;set;}
        public DbSet<ChatRoomUserModel>ChatRoomUsers { get;set;}
        public DbSet<ConnectionModel>Connections {get;set;}
        public DbSet<MessageModel>Messages {get;set;}
        public DbSet<UserModel>Users { get;set; }
    }
}