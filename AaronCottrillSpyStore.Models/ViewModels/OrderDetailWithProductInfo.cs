using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AaronCottrillSpyStore.Models.Entities.Base;
using AaronCottrillSpyStore.Models.ViewModels.Base;

namespace AaronCottrillSpyStore.Models.ViewModels
{
    public class OrderDetailWithProductInfo : ProductAndCategoryBase
    {
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [DataType(DataType.Currency), Display(Name = "Total")]
        public decimal? LineItemTotal { get; set; }
    }
}