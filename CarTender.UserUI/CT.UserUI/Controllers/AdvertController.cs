﻿using Business.Abstract;
using Business.Concrete;
using Common.Concrete;
using Entity.DTO.Advert;
using Entity.DTO.Auth;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CT.UserUI.Controllers
{
    public class AdvertController : Controller
    {
        private readonly IApiManager _apiManager;
        private readonly IDictionary<string, string> _routes;

        public AdvertController()
        {
            _apiManager = new ApiManager(new BaseAPIService());
            _routes = new ApiRoutes().GetApiRoutes("Advert");
        }

        // Advert List GET
        public async Task<ActionResult> Index()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiManager.Get<ListAdvertDTO>(tokenDTO, _routes["ListAdvert"]);
            //if (result != null)
            //{
            //    //todo: sayfaya veriler basılacak
            //    return View();
            //}
              if(true)
                return View();

            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Advert Details
        public async Task<ActionResult> Details()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiManager.Get<ListAdvertDTO>(tokenDTO, _routes["Details"]);
            //if (result != null)
            //{
            //    //todo: sayfaya veriler basılacak
            //    return View();
            //}
            if (true)
                return View();
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        // Advert Create GET
        public ActionResult Create()
        {
            return View();
        }

        // Advert Create POST
        //[HttpPost]
        //public async Task<ActionResult> Create(AddAdvertDTO dto)
        //{
        //    //var result = await _apiManager.Post(_routes["Create"], dto);
        //    //if (result != null)
        //    //{
        //    //    //todo: sayfaya veriler basılacak
        //    //    return RedirectToAction("Index");
        //    //}
        //    //else
        //    //{
        //    //    //ErrorViewModel model = new ErrorViewModel()
        //    //    //{
        //    //    //    Header = "Bid",
        //    //    //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //    //    //    StatusCode = 500
        //    //    //};
        //    //    //return View("~/Views/Shared/Error.cshtml", model);
        //    //    return View("~/Views/Shared/Error.cshtml");

        //    //}
        //}

        // Advert Edit GET
        public async Task<ActionResult> Edit()
        {
            //todo : User'a göre tokenDto oluşturulacak
            TokenDTO tokenDTO = new TokenDTO()
            {
                Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
                ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
                ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
                ExpireTime = DateTime.Now.AddHours(1)
            };
            //var result = await _apiManager.Get<BidInformationDTO>(tokenDTO, _routes["UpdateGet"]);
            //if (result != null)
            //{
            //    //todo: sayfaya veriler basılacak
            //    return View();
            //}
            if (true)
                return View();
            else
            {
                //ErrorViewModel model = new ErrorViewModel()
                //{
                //    Header = "Bid",
                //    Message = "İhaleyle ilgili bilgiler bulunamadı",
                //    StatusCode = 500
                //};
                //return View("~/Views/Shared/Error.cshtml", model);
                return View("~/Views/Shared/Error.cshtml");

            }
        }

        // Advert Edit POST
        //[HttpPost]
        //public async Task<ActionResult> Edit(int id, EditAdvertDTO dto)
        ////{
        ////    var result = await _apiManager.Post(_routes["Update"], dto);
        ////    if (result != null)
        ////    {
        ////        //todo: sayfaya veriler basılacak
        ////        return RedirectToAction("Index");
        ////    }
        ////    else
        ////    {
        ////        //ErrorViewModel model = new ErrorViewModel()
        ////        //{
        ////        //    Header = "Bid",
        ////        //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        ////        //    StatusCode = 500
        ////        //};
        ////        //return View("~/Views/Shared/Error.cshtml", model);
        ////        return View("~/Views/Shared/Error.cshtml");

        ////    }
        //}

        // Advert Delete GET
        //public async Task<ActionResult> Delete()
        //{
        //    //todo : User'a göre tokenDto oluşturulacak
        //    TokenDTO tokenDTO = new TokenDTO()
        //    {
        //        Token = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9" +
        //         ".eyJuYmYiOjE2NjU4MzQ2NDAsImV4cCI6MTY3MTAxODY0MCwiaXNzIjoiaHVmZmxlcHVmZkBodWZmbGVwdWZmLmNvbSIsImF1ZCI6Imh1ZmZsZXB1ZmZAaHVmZmxlcHVmZi5jb20ifQ" +
        //         ".YqA_0sJDNSXLJzPN8U7bsrzDtfnEEkrwHHT66xx7uix9r270wXo_vZpJsXTZ8WWjdmTmrqhN_4JEdQ41xcisgw",
        //        ExpireTime = DateTime.Now.AddHours(1)
        //    };
        //    var result = await _apiManager.Get<EditAdvertDTO>(tokenDTO, _routes["DeleteGet"]);
        //    if (result != null)
        //    {
        //        //todo: sayfaya veriler basılacak
        //        return View();
        //    }
        //    else
        //    {
        //        //ErrorViewModel model = new ErrorViewModel()
        //        //{
        //        //    Header = "Bid",
        //        //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //        //    StatusCode = 500
        //        //};
        //        //return View("~/Views/Shared/Error.cshtml", model);
        //        return View("~/Views/Shared/Error.cshtml");
        //    }
        //}

        // Advert Delete POST
        //[HttpPost]
        //public async Task<ActionResult> Delete(EditAdvertDTO dto)
        //{
        //    //var result = await _apiManager.Post(_routes["Delete"], dto);
        //    //if (result != null)
        //    //{
        //    //    //todo: sayfaya veriler basılacak
        //    //    return RedirectToAction("Index");
        //    //}
        //    //else
        //    //{
        //    //    //ErrorViewModel model = new ErrorViewModel()
        //    //    //{
        //    //    //    Header = "Bid",
        //    //    //    Message = "İhaleyle ilgili bilgiler bulunamadı",
        //    //    //    StatusCode = 500
        //    //    //};
        //    //    //return View("~/Views/Shared/Error.cshtml", model);
        //    //    return View("~/Views/Shared/Error.cshtml");
        //    //}
        //}
    }
}
