using Domain.Entities;
using Domain.Interface;

namespace Infrastruture.Data
{
    public class PositionRepository : IPositionRepository
    {
        //db call
        public Position GetPosition()
        {
            return new Position()
            {
                PositionId = 1,
                PositionName = "Senior"
            };
        }
    }
}
