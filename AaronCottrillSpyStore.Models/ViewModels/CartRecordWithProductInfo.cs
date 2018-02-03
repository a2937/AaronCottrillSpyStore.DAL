using System;
using System.ComponentModel.DataAnnotations;
using AaronCottrillSpyStore.Models.Entities.Base;
using AaronCottrillSpyStore.Models.ViewModels.Base;

namespace AaronCottrillSpyStore.Models.ViewModels
{
    public class CartRecordWithProductInfo : ProductAndCategoryBase
    {
        [DataType(DataType.Date), Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
        public int? CustomerId { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency), Display(Name = "Line Total")]
        public decimal LineItemTotal { get; set; }
    }
}
