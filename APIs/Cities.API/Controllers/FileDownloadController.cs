using Microsoft.AspNetCore.Mvc;

namespace Cities.API.Controllers
{
    [ApiController]
    [Route("api/downloadfiles")]
    public class FileDownloadController: ControllerBase
    {
        [HttpGet("{fileId}")]
        public ActionResult DownloadFile(int fileId)
        {
           return NotFound();
        }
    }
}
