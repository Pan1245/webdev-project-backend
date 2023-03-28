using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using FirebaseAdmin;
using Firebase.Auth;

namespace houseofgriffin_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private const string API_KEY = "AIzaSyDNHYBSm4YOFiKBs6kxdKba_I9klxrazTM";
        FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            try
            {
                FirebaseAuthLink firebaseAuthLink = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(request.email, request.password);

                return Ok(firebaseAuthLink.FirebaseToken);

            }
            catch (FirebaseAuthException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ResetPassword"), Authorize(Roles = "oa, ea, ep")]
        public async Task<ActionResult<String>> ResetPassword(string email)
        {
            await firebaseAuthProvider.SendPasswordResetEmailAsync(email);
            return Ok("Sucess");
        }


    }
}