using Crowdy.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Crowdy.Tools
{
    public class ConnectedOnlyAttribute : TypeFilterAttribute
    {
        public ConnectedOnlyAttribute() : base(typeof(ConnectedOnlyFilter))
        {
        }
    }

    public class ConnectedOnlyFilter : IAuthorizationFilter
    {
        private readonly AuthService _authService;

        public ConnectedOnlyFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_authService.IsConnected())
            {
                context.Result = new RedirectToRouteResult(new { action = "Index", Controller = "Home", area = "" });
            }
        }
    }
}
