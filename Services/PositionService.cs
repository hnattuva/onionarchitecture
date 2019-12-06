using Domain.Entities;
using Domain.Interface;
using Service.Interfaces;

namespace Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _repository;

        public PositionService(IPositionRepository repository)
        {
            this._repository = repository;
        }

        public Position GetPosition() => _repository.GetPosition();
    }
}