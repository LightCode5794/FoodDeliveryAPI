using FoodDelivery.Application.Features.Users.Commands.CreateUser;
using FoodDelivery.Application.Features.Users.Queries.GetAllUsers;
using FoodDelivery.Shared;
using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.WebAPI.Controllers
{
    public class UsersController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;   
        }



        /* [HttpGet]
        [Route("paged")]
        public async Task<ActionResult<PaginatedResult<GetPlayersWithPaginationDto>>> GetPlayersWithPagination([FromQuery] GetPlayersWithPaginationQuery query)
        {
            var validator = new GetPlayersWithPaginationValidator();

            // Call Validate or ValidateAsync and pass the object which needs to be validated
            var result = validator.Validate(query);

            if (result.IsValid)
            {
                return await _mediator.Send(query);
            }

            var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
            return BadRequest(errorMessages); 
        } */
        [HttpGet]
        public async Task<ActionResult<Result<List<UserDto>>>> Get()
        {
            return await _mediator.Send(new GetAllUsersQuery());
        }


        [HttpPost]
        public async Task<ActionResult<Result<int>>> Create(CreateUserCommand command)
        {
            return await _mediator.Send(command);
        }

       /* [HttpPut("{id}")]
        public async Task<ActionResult<Result<int>>> Update(int id, UpdateUserCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            return await _mediator.Send(command); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<int>>> Delete(int id)
        {
            return await _mediator.Send(new DeleteUserCommand(id)); 
        }*/
    }
}
