using Microsoft.AspNetCore.Authorization;

namespace MinimalExample.Authorization
{
    public class UseCaseRequirement : IAuthorizationRequirement
    {
        public string UseCaseName { get; }

        public UseCaseRequirement(string useCaseName)
        {
            UseCaseName = useCaseName;
        }
    }
}