﻿using CarTender.Core.Utilities;
using CT.Entities.Bid;
using CT.Entities.Car;
using CT.Entities.DTOs.Car;
using CT.Entities.DTOs.CarModification;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CT.API.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: CarController

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            //Todo : Dapper eklenecek
            List<ListCarDTO> carDTOs = new List<ListCarDTO>();
            for (int i = 0; i < 10; i++)
            {
                carDTOs.Add(new ListCarDTO()
                {
                    CarBrand = "Toyota",
                    CarModel = "Verso",
                    IsCorporate = false,
                    Status = "Beklemede",
                    CreatedBy = "Mert",
                    CreatedDate = System.DateTime.Now,
                    Price = 1000000
                });
            }
            var dataResult = new SuccessDataResult<List<ListCarDTO>>(carDTOs, "Data Eklendi", 200);

            return Ok(dataResult);
        }

        [HttpPost("Create")]
        public IActionResult Create(CreateCarDTO dto)
        {
            return Ok(new SuccessResult("Araba Ekleme Başarılı", 200));
        }

        [HttpPost("Update")]
        public IActionResult Update(UpdateCarDTO dto)
        {
            return Ok(new SuccessResult("Araba Güncelleme Başarılı", 200));
        }

        [HttpPost("Delete")]
        public IActionResult Delete(object carID)
        {
            return Ok(new SuccessResult("Araba Silme Başarılı", 200));
        }

        [HttpGet("GetByID")]
        public IActionResult GetByID(object carID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByPlate")]
        public IActionResult GetByPlate(string carPlate)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByBrand")]
        public IActionResult GetByBrand(object brandID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByModel")]
        public IActionResult GetByModel(object modelID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByAdvert")]
        public IActionResult GetByAdvert(object advertID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByBid")]
        public IActionResult GetByBid(object bidID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetByUser")]
        public IActionResult GetByUser(object userID)
        {
            //Todo : Dapper eklenecek
            ListCarDTO car = new ListCarDTO()
            {
                CarBrand = "Toyota",
                CarModel = "Verso",
                IsCorporate = false,
                Status = "Beklemede",
                CreatedBy = "Mert",
                CreatedDate = System.DateTime.Now,
                Price = 1000000
            };
            var dataResult = new SuccessDataResult<ListCarDTO>(car, "Data Eklendi", 200);
            return Ok(dataResult);
        }

        [HttpGet("GetModifications")]
        public IActionResult GetModifications(object carID)
        {
            return Ok(new SuccessResult("Modifiyeleri Listeleme Başarılı", 200));
        }

        //[HttpPost("AddModificationToCar")]
        //public IActionResult AddModificationToCar(object carID, CreateCarModificationDTO dto)
        //{
        //    return Ok(new SuccessResult("Arabaya Modifiye Ekleme Listeleme Başarılı", 200));
        //}

        //[HttpPost("DeleteModificationFromCar")]
        //public IActionResult DeleteModificationFromCar(object carID, object modificationID)
        //{
        //    return Ok(new SuccessResult("Modifiyeleri Listeleme Başarılı", 200));
        //}


        //[HttpGet("CarBuyerInformation")]
        //public IActionResult CarBuyerInformation(object dto)
        //{
        //    //Todo : Dapper eklenecek
        //    CarBuyerDTO data = new CarBuyerDTO();
        //    var dataResult = new SuccessDataResult<CarBuyerDTO>(data, "Data Eklendi",200);
        //    return Ok(dataResult);
        //}
    }
}
