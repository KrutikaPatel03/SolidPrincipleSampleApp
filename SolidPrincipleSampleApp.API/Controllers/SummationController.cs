using Microsoft.AspNetCore.Mvc;
using SolidPrincipleSampleApp.API.Services;
using SolidPrincipleSampleApp.API.Services.Interfaces;

namespace SolidPrincipleSampleApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SummationController : ControllerBase
    {
        private readonly ILogger<SummationController> _logger;

        public SummationController(ILogger<SummationController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Prints the sum of specifed  range integers using Method1
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        [HttpGet("method1")]
        public ActionResult AddByMethod1(int min, int max)
        {
            try
            {
                if (min <= 0 || max <= 0)
                {
                    return BadRequest("Please enter positive integer geater than 0.");
                }
                if (max < min)
                {
                    return BadRequest("Max value should not be geater than min value.");
                }
                var arrNumbers = Enumerable.Range(min, max).ToArray();

                //Liskov Substitution Principle(LSP) - Here SummationMethod2 can beused interchangeably 
                // with SummationMethod1 via ISummationMethod interface

                ISummationMethod summationMethod1 = new SummationMethod1();
               
                //Below lines indicates usage of Dependency Injection
                SummationResultPrint summationResultPrint = new SummationResultPrint(summationMethod1);
                return Ok(summationResultPrint.Print(arrNumbers));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return BadRequest();
        }

        /// <summary>
        /// Prints the sum of specifed  range integers using Method1
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        [HttpGet("method2")]
        public ActionResult AddByMethod2(int min, int max)
        {
            try
            {
                if (min <= 0 || max <= 0)
                {
                    return BadRequest("Please enter positive integer geater than 0.");
                }
                if (max < min)
                {
                    return BadRequest("Max value should not be geater than min value.");
                }
                var arrNumbers = Enumerable.Range(min, max).ToArray();
                ISummationMethod summationMethod2 = new SummationMethod2();
               
                //Below lines indicates usage of Dependency Injection
                SummationResultPrint summationResultPrint = new SummationResultPrint(summationMethod2);
                return Ok(summationResultPrint.Print(arrNumbers));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }
            return BadRequest();
        }
    }
}
