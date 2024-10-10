using Crowdy.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Crowdy.Tools
{
    public class AdminOnlyAttribute : TypeFilterAttribute
    {
        public AdminOnlyAttribute() : base(typeof(AdminOnlyFilter))
        {
        }
    }

    public class AdminOnlyFilter : IAuthorizationFilter
    {
        private readonly AuthService _authService;

        public AdminOnlyFilter(AuthService authService, ITempDataDictionaryFactory tempDataDictionaryFactory)
        {
            _authService = authService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_authService.IsGrantedAccess())
            {
                context.Result = new RedirectToRouteResult(new { action = "Index", Controller = "Home", area = "" });
            }
        }
    }
}
