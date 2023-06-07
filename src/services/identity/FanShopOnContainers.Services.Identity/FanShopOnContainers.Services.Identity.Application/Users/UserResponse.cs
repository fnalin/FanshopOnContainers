using FanShopOnContainers.Services.Identity.Application.Common;

namespace FanShopOnContainers.Services.Identity.Application.Users;

public record UserResponse(string Id, string Email, string? AccessToken = null) : IResponse;
