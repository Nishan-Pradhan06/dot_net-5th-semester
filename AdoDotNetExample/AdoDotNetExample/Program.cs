using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace AdoDotNetExample
{
    public class Program
    {
        private const String conString = "Data Source=localhost;Database=BcaV;Integrated Security=SSPI;TrustServerCertificate=true";
        // "Server=localhost;Initial Catalog=BcaV;Integrated Security =True";Trust_Server_Certificate=True;
        // "Data Source= localhost;Database=BcaV;User Id=sa;Password=12345;
        private static SqlConnection conn = new SqlConnection(conString);
        //conn.ConnectionString = conString;
        private static SqlCommand cmd = new SqlCommand("", conn);
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Select an option:\n1. Insert \n2. Update");
                Console.WriteLine("3. Delete \n4. List\n5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (Insert())
                            Console.WriteLine("Insertion Successful.");
                        else
                            Console.WriteLine("Insertion failed.");
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4: Show(); break;
                    case 5: return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
        public static bool Insert()
        {
            string? userName, userPassword, userId;
            Console.WriteLine("Enter your Name:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your UserId:");
            userPassword = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            userId = Console.ReadLine();
            cmd.CommandText = "insert into UserList(UserId,UserName,loginId,loginPassword,isActive)" + "values((Select max(userId)+1 from UserList),@userName,@userId, @userPassword  ,1)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);

            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count == 1;
        }
        public static bool Update()
        {
            return true;
        }
        public static bool Delete()
        {
            return true;
        }
        public static void Show()
        {
            cmd.CommandText = "select userName,loginPassword from UserList";

            try
            {
                conn.Open();
                // do your database stuff
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("List of Users:");
                while (reader.Read())
                {
                    Console.WriteLine(Convert.ToString(reader["loginPassword"]));
                }
                reader.Close();
                conn.Close();
            }
            catch
            {
                Console.WriteLine("Database Error.");
            }
        }
    }
}