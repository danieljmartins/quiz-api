using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using QuizApi.Models;

namespace QuizApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly FirestoreDb _db;        

        public UserController ()
        {
            _db = FirebaseConfig.GetFirestoreDb ();
        }

        [HttpGet ( "consult" )]
        public async Task<IActionResult> GetUser () 
        {
            CollectionReference usersRef = _db.Collection("users");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            var users = snapshot.Documents.Select(doc => new
            {
                Id = doc.Id,
                Nome = doc.GetValue<string>("nome"),
                Pontos = doc.GetValue<int>("pontos"),
            });

            return Ok (users);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser ( [FromBody] UserModel user ) 
        {            
            try
            {
                CollectionReference usersRef = _db.Collection ("users");
                await usersRef.AddAsync ( user );
                return Ok ( new { msg = "Usuário criado" } );
            }
            catch ( Exception ex ) 
            {
                Console.WriteLine ( "Erro ao criar o usuário: ", ex );
                return StatusCode ( 500, new { error = "Erro ao criar usuário", details = ex.Message } );
            }
        }
    }
}
