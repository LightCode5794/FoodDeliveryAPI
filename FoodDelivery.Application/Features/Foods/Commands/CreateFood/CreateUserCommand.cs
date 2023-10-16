using AutoMapper;
using FoodDelivery.Application.Common.Mappings;
using FoodDelivery.Application.Interfaces.Repositories;
using FoodDelivery.Domain.Entities;
using FoodDelivery.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Foods.Commands.CreateFood
{
    public record CreateUserCommand : IRequest<Result<int>>, IMapFrom<User>
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required string Phone_number { get; set; }
        public required string Address { get; set; } = string.Empty;

    }
    internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<int>> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                Name = command.Name,
                Password = command.Password,
                Phone_number = command.Phone_number,
                Address = command.Address,
                Role = new Role() { Name = "USER"},
            };

            await _unitOfWork.Repository<User>().AddAsync(user);
            user.AddDomainEvent(new UserCreatedEvent(user));

            await _unitOfWork.Save(cancellationToken);

            return await Result<int>.SuccessAsync(user.Id, "Player Created.");
        }

    }
}
