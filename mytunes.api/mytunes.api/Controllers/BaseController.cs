using Microsoft.AspNetCore.Mvc;
using mytunes.Core;
using mytunes.Core.Enums;

namespace mytunes.api.Controllers
{
    public class BaseController:ControllerBase
    {
        public ActionResult GetResult<T>(ServiceResult<T> serviceResult)
        {
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok();
        }
    }
}