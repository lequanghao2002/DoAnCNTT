﻿using FashionShop.Models.ViewModel;
using System.ComponentModel.DataAnnotations;


namespace FashionShop.Models.DTO.OrderDTO
{
    public class CreateOrderDTO
    {
        [Required(ErrorMessage = "Tên không được để trống")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int ProvinceID { get; set; }

        public int DistrictID { get; set; }

        public int WardID { get; set; }

        public string Address { get; set; }

        public string? Note { get; set; }
        public double DeliveryFee { get; set; }
        public string UserID { get; set; }

        public int? VoucherID { get; set; }

        public List<ShoppingCartViewModel>? shoppingCarts { get; set; }
    }
}
