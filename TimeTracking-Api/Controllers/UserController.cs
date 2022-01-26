using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private string Roleid;

        [HttpPost]
        public IActionResult SaveUser(User user)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var  numberOfRecordsUpdated= databaseService.SaveUser(user);

                return Ok(numberOfRecordsUpdated);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var listOfUsers = databaseService.GetUser(id);

                return Ok(listOfUsers);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedUser = databaseService.UpdateUser(user);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedUser = databaseService.DeleteUser(id);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}

   

