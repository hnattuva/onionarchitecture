using System;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IPositionRepository
    {
        Position GetPosition();
    }
}
