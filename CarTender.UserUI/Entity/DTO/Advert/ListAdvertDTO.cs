﻿using System.ComponentModel;

namespace Entity.DTO.Advert
{
    public class ListAdvertDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("İlan Başlığı")]
        public string Title { get; set; }

        [DisplayName("İlan Açıklaması")]
        public string Info { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        [DisplayName("Ön Değerlendirme Fiyatı")]
        public decimal PrePrice { get; set; }

        [DisplayName("Marka")]
        public string CarBrand { get; set; }

        [DisplayName("Model")]
        public string CarModel { get; set; }
    }
}
