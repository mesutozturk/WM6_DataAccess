using System.Collections.Generic;
using Otel.Models.Entities;

namespace Otel.BLL.Repository
{
    public class RoomRepo : RepositoryBase<Room, int>
    {
        public override List<Room> GetAll()
        {
            return base.GetAll(x=>x.IsUseable);
        }
    }
}
