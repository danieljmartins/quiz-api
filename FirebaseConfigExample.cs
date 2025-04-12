/*
using System.Data.Common;
using Google.Cloud.Firestore;

namespace QuizApi
{
    public static class FirebaseConfig
    {
        private static FirestoreDb _firestoreDb;

        public static FirestoreDb GetFirestoreDb () {
            if ( _firestoreDb == null )
            {
                try
                {
                    // path to the firebase key
                    string path = "YOUR_PATH_HERE";
                    Environment.SetEnvironmentVariable ( "GOOGLE_APPLICATION_CREDENTIALS", path );

                    // create the firebase database
                    _firestoreDb = FirestoreDb.Create ( "YOUR_DB_NAME_HERE" );
                }
                catch ( Exception ex ) 
                {
                    throw new Exception ( "Erro ao se conectar com o banco de dados: ", ex );
                }
            }
            return _firestoreDb;
        }
    }
}
*/
