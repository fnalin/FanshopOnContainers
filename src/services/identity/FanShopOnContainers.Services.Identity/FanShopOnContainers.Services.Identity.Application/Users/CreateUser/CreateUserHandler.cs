using MediatR;

namespace FanShopOnContainers.Services.Identity.Application.Users.CreateUser;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserResponse>
{
    private readonly IUserRepository _repository;

    public CreateUserHandler(IUserRepository repository) => _repository = repository;

    public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var data = await Task.Run(()=> new UserResponse(Guid.NewGuid().ToString(), request.Email));

        return data;
    }
}