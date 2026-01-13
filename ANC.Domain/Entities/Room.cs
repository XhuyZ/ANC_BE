using ANC.Domain.Bases;
using System;
using System.Collections.Generic;

namespace ANC.Domain.Entities
{
	public class Room : BaseEntity
	{
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual ICollection<Device> Devices { get; set; }
	}
}
