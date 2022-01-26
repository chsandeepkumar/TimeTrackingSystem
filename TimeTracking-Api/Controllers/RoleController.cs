using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        [HttpPost]
        public IActionResult CreateRole(Role role)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var numberOfRecordsCreated = databaseService.CreateRole(role);

                return Ok(numberOfRecordsCreated);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IActionResult GetRole(int Roleid)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var listOfRoles = databaseService.GetRole(Roleid);

                return Ok(listOfRoles);

            }
            catch (Exception exception)
            {

                throw exception;
            }

        }
        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedRoles = databaseService.UpdateRole(role);
                return Ok(updatedRoles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpDelete]
        public IActionResult DeleteRole(int roleid)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var deletedRoles = databaseService.DeleteRole(roleid);
                return Ok(deletedRoles);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
