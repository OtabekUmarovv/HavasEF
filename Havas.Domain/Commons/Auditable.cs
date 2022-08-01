using Havas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Commons
{
    public abstract class Auditable
    {
        public Guid Id { get; set; }
        public ItemState State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void Create()
        {
            CreatedAt = DateTime.UtcNow;
            State = ItemState.Created;
        }
        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
            State = ItemState.Updated;
        }

        public void Delete()
        {
            UpdatedAt = DateTime.UtcNow;
            State = ItemState.Deleted;
        }


    }
}
