using Abp.Application.Services.Dto;

namespace JenkinsTryOut.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

