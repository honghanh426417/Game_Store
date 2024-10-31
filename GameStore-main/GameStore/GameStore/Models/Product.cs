using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace GameStore.Models
{
    public class Product
    {

		public int ProductId { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }

		public string? ImageGame { get; set; }

		[Required(ErrorMessage = "Developer is required.")]
		public string Developer { get; set; }

		[Required(ErrorMessage = "Publisher is required.")]
		public string Publisher { get; set; }

		[Required(ErrorMessage = "Release date is required.")]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		public string Categories { get; set; }

		public string Review { get; set; }

		[Required(ErrorMessage = "Price is required.")]
		[Column(TypeName = "decimal(18,4)")]
		[Range(0.01, 999999.99, ErrorMessage = "Price must be between 0.01 and 999999.99.")]
		public decimal Price { get; set; }

		public decimal DiscountPercentage { get; set; }
		public decimal DiscountedPrice => Price - (Price * DiscountPercentage / 100);
	}
}
