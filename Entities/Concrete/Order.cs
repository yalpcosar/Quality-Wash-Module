using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order: BaseEntity
    {
        public string OrderNo { get; set; }
        public string ModelName { get; set; }
        public string FabricType { get; set; }
    }
}