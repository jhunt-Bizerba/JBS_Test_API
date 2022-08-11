using System.Text;
using JBS_Test_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace JBS_Test_API.Controllers;

[ApiController]
[Route("production")]
public class PackageRecordController : Controller
{
    
    [HttpPost("thirdPartyBasetags")]
    public IActionResult ReceivePackageRecordExports([FromBody] List<PackageRecordDto> record)
    {
        IHeaderDictionary headers = this.HttpContext.Request.Headers;
        string authHeader = headers["Authorization"];
        if (!String.IsNullOrEmpty(authHeader))
        {
            string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

            int seperatorIndex = usernamePassword.IndexOf(':');
            User user = new User();
            user.Username = usernamePassword.Substring(0, seperatorIndex);
            user.Password = usernamePassword.Substring(seperatorIndex + 1);
        }

        return NoContent();
    }
}