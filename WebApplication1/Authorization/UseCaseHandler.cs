using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using WebApplication1;
using WebApplication1.Services;

namespace MinimalExample.Authorization
{
    public class UseCaseHandler : AuthorizationHandler<UseCaseRequirement>
    {
        private readonly DashboardAuthorizationService _authorizationService;

        public UseCaseHandler(DashboardAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UseCaseRequirement requirement)
        {
            if (!context.User.Identity.IsAuthenticated)
                return Task.FromResult(0);

            if (_authorizationService.HasAccess(context.User, requirement.UseCaseName))
                context.Succeed(requirement);

            return Task.FromResult(0);

        }
    }
}