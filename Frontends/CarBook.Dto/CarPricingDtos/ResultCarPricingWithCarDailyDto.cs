﻿namespace CarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingWithCarDailyDto
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public string PricingName { get; set; }
        public decimal PricingAmount { get; set; }
    }
}
