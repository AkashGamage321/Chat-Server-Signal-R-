using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ChatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Chat/Index
        public IActionResult Index()
        {
            // Optional: Fetch any necessary data, e.g., list of users or chat rooms
            var chatRooms = _context.ChatRooms.ToList();
            return View(chatRooms);
        }

        // GET: /Chat/Room/{id}
        public async Task<IActionResult> Room(int id)
        {
            var chatRoom = await _context.ChatRooms.FindAsync(id);

            if (chatRoom == null)
            {
                return NotFound();
            }

            // Optional: Retrieve the current user's information
            var currentUserId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

            // Pass chat room and user information to the view
            ViewBag.ChatRoom = chatRoom;
            ViewBag.CurrentUserId = currentUserId;

            return View();
        }
    }
}