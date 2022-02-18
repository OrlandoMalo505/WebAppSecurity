using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace WebAppSecurity.Authorization
{
    public class HRManagerProbationRequirementHandler : AuthorizationHandler<HRManagerProbationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRManagerProbationRequirement requirement)
        {
            if(!context.User.HasClaim(x => x.Type == "EmploymentDate"))
            {
                return Task.CompletedTask;
            }

            var employmentDate = DateTime.Parse(context.User.FindFirst(x => x.Type == "EmploymentDate").Value);
            var period = DateTime.Now - employmentDate;

            if(period.Days > requirement.ProbationMonths * 30)
            
                context.Succeed(requirement);

                return Task.CompletedTask;
            
        }
    }
}
