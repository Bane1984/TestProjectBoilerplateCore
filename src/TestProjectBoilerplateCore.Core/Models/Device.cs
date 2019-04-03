using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace TestProjectBoilerplateCore.Models
{
    public class Device:Entity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int DeviceTypeId { get; set; }
        [ForeignKey("DeviceTypeId")]
        public DeviceType DeviceType { get; set; }

        public List<DeviceTypePropertie> DeviceTypeProperties { get; set; } = new List<DeviceTypePropertie>();
        public List<DevicePropertyValue> DevicePropertyValueses { get; set; } = new List<DevicePropertyValue>();
    }
}
