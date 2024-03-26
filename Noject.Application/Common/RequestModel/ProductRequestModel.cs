using System.ComponentModel.DataAnnotations;

namespace Noject.Application.Common.RequestModel
{
    public class ProductRequestModel
    {
        public int ProductId { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}