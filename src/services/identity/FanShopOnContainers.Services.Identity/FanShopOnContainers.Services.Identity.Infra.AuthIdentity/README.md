[Criar e executar migração]
dotnet ef migrations add Initial -v -s ../FanShopOnContainers.Services.Identity.API --context IdentityDataContext
dotnet ef database update -v -s ../FanShopOnContainers.Services.Identity.API
