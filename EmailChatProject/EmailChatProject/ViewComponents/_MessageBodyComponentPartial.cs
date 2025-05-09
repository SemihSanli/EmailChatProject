using EmailChatProject.Context;
using EmailChatProject.Entities;
using EmailChatProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace EmailChatProject.ViewComponents
{
    public class _MessageBodyComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly EmailContext _emailContext;

        public _MessageBodyComponentPartial(UserManager<AppUser> userManager, EmailContext emailContext)
        {
            _userManager = userManager;
            _emailContext = emailContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var receiverCount = _emailContext.Messages.Count(x => x.ReceiverEmail == user.Email && x.IsRead == true);
            var senderCount = _emailContext.Messages.Count(x => x.SenderEmail == user.Email && x.IsRead==true);
            var model = new MessageCountViewModel
            {
                ReceiveMessage = receiverCount,
                SendMessage = senderCount,
            };
            return View(model);
           

           
        }
    }
    
}
