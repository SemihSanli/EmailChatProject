using EmailChatProject.Context;
using EmailChatProject.Entities;
using EmailChatProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace EmailChatProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _emailContext;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(EmailContext emailContext, UserManager<AppUser> userManager)
        {
            _emailContext = emailContext;
            _userManager = userManager;
        }

        


        public async Task<IActionResult> Index(string search)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userEmail = user.Email;
            ViewBag.email = userEmail;
            ViewBag.namesurname = user.Name + " " + user.Surname;
            ViewBag.SearchTerm = search;
            var messages = _emailContext.Messages
                .Where(x => x.ReceiverEmail == userEmail && x.IsRead == true);

            if (!string.IsNullOrEmpty(search))
            {
                messages = messages.Where(x => x.Subject.ToLower().Contains(search.ToLower()));
            }

            return View(messages.ToList());
        }
        [HttpGet]
        public IActionResult NewMessage()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewMessage(Message message)
        {
           
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string senderEmail = values.Email;
            string senderName=values.Name;

            message.SenderEmail = senderEmail;
            message.SenderName = senderName;
            message.IsRead = true;
            message.SendDate = DateTime.Now;
            _emailContext.Messages.Add(message);
            _emailContext.SaveChanges();
            ViewBag.Success = "Gönderim işlemi başarılı!";
            return View("~/Views/Message/NewMessage.cshtml");
        }
        public async Task<IActionResult> SendBox(string search)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string userEmail = user.Email;
            ViewBag.email = userEmail;
            ViewBag.namesurname = user.Name + " " + user.Surname;
            ViewBag.SearchTerm = search;
            var sentEmails = _emailContext.Messages
                .Where(x => x.SenderEmail == userEmail && x.IsRead == true);
            if (!string.IsNullOrEmpty(search))
            {
                string term = search.ToLower();
                sentEmails = sentEmails.Where(x =>
                    x.Subject.ToLower().Contains(term) ||
                    x.ReceiverEmail.ToLower().Contains(term) ||
                    x.MessageDetail.ToLower().Contains(term)
                );
            }
            return View(sentEmails.ToList());
        }
        public async Task<IActionResult> MessageDetail(int id)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.senderimage = values.ProfileImageURL;
            var value = _emailContext.Messages.FirstOrDefault(x => x.MessageID == id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> ChangeMessageStatus(List<int> messageID)
        {
            foreach (var id in messageID)
            {
                var value = await _emailContext.Messages.FindAsync(id);
                if (value != null)
                {
                    value.IsRead = false;
                   
                }
            }
            await _emailContext.SaveChangesAsync();
            return RedirectToAction("TrashBox");
        }

        public IActionResult TrashBox()
        {
            var deletedValues = _emailContext.Messages.Where(x =>x.IsRead==false).ToList();
            return View(deletedValues);
        }
        public async Task<IActionResult> MessageCount()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.RecipientEmailAddressCount = _emailContext.Messages
                         .Where(x => x.ReceiverEmail == values.Email)
                         .Count();

            ViewBag.SenderEmailAddressCount = _emailContext.Messages
                                     .Where(x => x.SenderEmail == values.Email)
                                     .Count();
            return View();
        }

        

    }
}
