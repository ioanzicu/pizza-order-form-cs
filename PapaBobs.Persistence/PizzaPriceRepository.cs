﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new PapaBobsDbEntities();
            var prices = db.PizzaPrices.First();

            var dto = convertToDTO(prices);
            return dto;
        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.ThinCrutsCost = pizzaPrice.ThinCrutsCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;
            dto.GreenPeppersCost = pizzaPrice.GreenPeppersCost;

            return dto;
        }
    }
}
