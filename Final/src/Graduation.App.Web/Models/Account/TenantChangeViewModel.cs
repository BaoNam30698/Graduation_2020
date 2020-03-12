using Abp.AutoMapper;
using Graduation.App.Sessions.Dto;

namespace Graduation.App.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}