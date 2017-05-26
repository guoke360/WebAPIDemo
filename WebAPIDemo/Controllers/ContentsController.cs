using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class ContentsController : ApiController
    {
        public class StylessDM
        {
            public List<StylessDM> list { get; set; }
            public string Id { get; set; }
            public bool Index1 { get; set; }
            public bool us { get; set; }
            public bool news { get; set; }
            public bool resources { get; set; }
        }
        DataContext db = new DataContext();
        public StylessDM Get()
        {
            StylessDM asd = new StylessDM();
            IQueryable<StylessDM> list = from Styles in db.Styless
                       where Styles.Id == "1"
                       select new StylessDM
                       
                       {
                           Index1 = Styles.Index1,
                           us = Styles.us,
                           news = Styles.news,
                           resources = Styles.resources
                       };
            asd.list = list.ToList();
            return asd;

        }
        public void Put()//添加信息
        {
            Styless info = new Styless();
            info = db.Styless.Where(x => x.Id == "1").FirstOrDefault();
        }
        public StylessDM Get(string index, string us, string newss,string resources)//添加信息
        {
            StylessDM asd = new StylessDM();
            Styless info = new Styless();
            info = db.Styless.Where(x => x.Id == "1").FirstOrDefault();
            if (index == 1.ToString())
            {
                if (info.Index1 == false)
                {
                    info.Index1 = true;
                    asd.Index1 = true;
                }
            }
            if (us == 2.ToString())
            {
                if (info.us == false)
                {
                    info.us = true;
                    asd.us = true;
                }
                }
            if (newss == 3.ToString())
            {
                if (info.news == false)
                {
                    info.news = true;
                    asd.news = true;

                }
            }
            if (resources == 4.ToString())
            {
                if (info.resources == false)
                {
                    info.resources = true;
                    asd.resources = true;
                }
            }
            db.Styless.Attach(info);
            db.Entry<Styless>(info).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            IQueryable<StylessDM> list = from Styles in db.Styless
                                         where Styles.Id == "1"
                                         select new StylessDM

                                         {
                                             Index1 = Styles.Index1,
                                             us = Styles.us,
                                             news = Styles.news,
                                             resources = Styles.resources
                                         };
            asd.list = list.ToList();
            return asd;

        }

      
    }
}