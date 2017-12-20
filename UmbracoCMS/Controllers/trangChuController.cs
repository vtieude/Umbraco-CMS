using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
namespace UmbracoCMS.Controllers
{
    public class trangChuController : RenderMvcController
    {
        //Get: perSon
        public ActionResult TrangChu(RenderModel model)
        {
            if (Request.HttpMethod == "POST")
            {
                var email = Request("email");
                var contentService = Services.ContentService;
                var newperson = contentService.CreateContent(email,model.Content.Id, "person");
                newperson.SetValue("email",email);
                contentService.SaveAndPublishWithStatus(newperson);
                Console.WriteLine("muahahaah");
            }
             Console.WriteLine("muahahaah");
            return CurrentTemplate(model);
        }
    }
}