using Google.Cloud.Firestore;

namespace QuizApi.Models
{
    [FirestoreData]
    public class UserModel
    {
        [FirestoreProperty]
        public String nome { get; set; }

        [FirestoreProperty]
        public int pontos { get; set; }
    }
}
