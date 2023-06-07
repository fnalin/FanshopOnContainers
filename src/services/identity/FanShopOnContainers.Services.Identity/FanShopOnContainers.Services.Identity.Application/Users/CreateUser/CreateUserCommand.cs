using MediatR;

namespace FanShopOnContainers.Services.Identity.Application.Users.CreateUser;

public record CreateUserCommand(string Email, string Password, string PasswordConfirmed) : IRequest<UserResponse>;