using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Remotion.Linq.Parsing.Structure.NodeTypeProviders;

namespace TestProjectBoilerplateCore.Models
{
    public class DeviceTypePropertie:Entity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int DeviceTypeId { get; set; }
        [ForeignKey("DeviceTypeId")]
        public DeviceType DeviceType { get; set; }

        public bool isRequired { get; set; }
    }
}
