using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RectangleApp.Models;
using RectangleApp.Data;

namespace RectangleApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RectanglesController : ControllerBase
    {
        private readonly ILogger<RectanglesController> _logger;

        private readonly DBInteractor dbInteractor;

        public RectanglesController(ILogger<RectanglesController> logger)
        {
            _logger = logger;
            dbInteractor = new DBInteractor();
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Coordinate> coordinates)
        {
            var result = new HashSet<Rectangle>();

            foreach (var coordinate in coordinates)
            {
                var rectangles = dbInteractor.rectangles
                    .Where(rectangle => coordinate.x >= rectangle.x && coordinate.x <= rectangle.x + rectangle.width
                                        && coordinate.y >= rectangle.y && coordinate.y <= rectangle.y + rectangle.height)
                    .ToList();

                foreach (var rectangle in rectangles)
                {
                    result.Add(rectangle);
                }
            }

            return Ok(result);
        }
    }
}
