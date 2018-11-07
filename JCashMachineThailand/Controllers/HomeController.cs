using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JCashMachineThailand.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace JCashMachineThailand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Content creation by View";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Content creation by View";

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact( ModelContactEmail model)
        {
            if (ModelState.IsValid)
            {
                //apply email sending process
                var body = "<p>Email From: {0} ({1}, {2})</p><p>Message:</p><p>{3}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(ConfigurationManager.AppSettings["ContactEmailTo"]));
                message.CC.Add(new MailAddress(ConfigurationManager.AppSettings["ContactEmailCc"]));
                message.Subject = model.Subject;
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.PhoneNumber, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    try { 
                        await smtp.SendMailAsync(message);
                        TempData["submitResult"] = "Your message has been sent.";//sent successfully message
                    }
                    catch(Exception e)
                    {
                        TempData["submitResult"] = "Oops!, Something went wrong. Please calling us to get assistance";
                        TempData["emailContent"] = message.Body;
                        logWritter(e.Message);//still error for file open
                    }
                    return RedirectToAction(nameof(ContactSent));
                }
            }
            return View(model);
        }

        private void logWritter(string msg)
        {
            string path = AppContext.BaseDirectory + "Log\\";
            
            string file = DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
            string filePath = path + file;
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);//create Log folder
                //write email error log
                System.IO.File.AppendAllText(filePath, msg);
                System.IO.File.AppendAllText(filePath, Environment.NewLine +TempData["emailContent"].ToString());
            }
            catch (Exception e)
            {
                TempData["logFail"] = e.Message + " [" + msg +"]";
            }
        }

        public ActionResult ContactSent()
        {
            ViewBag.ContactResult = TempData["submitResult"];
            ViewBag.logFail = TempData["logFail"];//if can't write log to file when Error of Email sending
            return View();
        }
    }
}