using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult UserLogin(Login login)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var numberOfRecordsCreated = databaseService.UserLogin(login);

                return Ok(numberOfRecordsCreated);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public IActionResult GetLoginUser(int loginid)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var listOfUsers = databaseService.GetLoginUser(loginid);

                return Ok(listOfUsers);

            }
            catch (Exception exception)
            {

                throw exception;
            }

        }
        [HttpPut]
        public IActionResult UpdateLoginUser(Login login)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedLoginUser = databaseService.UpdateLoginUser(login);
                return Ok(updatedLoginUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete]
        public IActionResult DeleteLoginUser(int loginid)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var deletedUser = databaseService.DeleteLoginUser(loginid);
                return Ok(deletedUser);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
