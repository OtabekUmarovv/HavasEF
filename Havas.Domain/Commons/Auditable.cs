using Havas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havas.Domain.Commons
{
    public abstract class Auditable
    {
        Guid Id { get; set; }
        ItemState State { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }

        public void Create()
        {
            CreatedAt = DateTime.Now;
            State = ItemState.Created;
        }
        public void Update()
        {
            UpdatedAt = DateTime.Now;
            State = ItemState.Updated;
        }

        public void Delete()
        {
            UpdatedAt = DateTime.Now;
            State = ItemState.Deleted;
        }


    }
}
