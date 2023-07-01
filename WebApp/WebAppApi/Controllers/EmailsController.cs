using App.Core.Business;
using App.Core.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private MailBusiness _mailBusiness;
        public EmailsController()
        {
            _mailBusiness = new MailBusiness();   
        }

        [HttpGet]
        public IActionResult Get()
        {
            var emails = new List<Mail>();

            emails.Add(new Mail()
            {
                MailId = 1,
                Asunto = "Demo",
                Contenido = "Preuba"
            });

            return Ok(emails);
        }

        [HttpGet("{emailId}:int")]
        public Mail GetMail(int emailId)
        {
            var email = new Mail()
            {
                MailId = emailId,
                Asunto = $"Demo {emailId}",
                Contenido = $"Preuba {emailId}"
            };

            return email;
        }

        [HttpPost]
        public IActionResult Post(Mail mail)
        {
            if (mail is null)
            {
                return BadRequest();
            }
            var demoAsunto = mail.Asunto;
            return new OkResult();
        }

        [EnableCors]
        [HttpPost("Search")]
        public IActionResult Search([FromBody]MailFilter filter)
        {
            if (filter is null || !filter.IsValid)
            {
                return BadRequest();
            }
            var mails = _mailBusiness.Search(filter);

            return Ok(mails);
        }
    }
}
