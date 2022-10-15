using FluentValidation;
using NORTHWND.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWND.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Geçilemez!!");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori Boş Geçilemez!!");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat Bilgisi Boş Geçilemez!!");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim Adedi Boş Geçilemez!!");

            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Ürün Fiyatı Sıfırdan Küçük Olamaz");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Stock Miktarı Sıfırdan Küçük Olamaz!!");
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2).WithMessage("Unit Price Değeri 10 Değerinden Büyük Olmalı!!");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün Adı A ile başlamalı!!");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
