using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace desktopEample
{
    public partial class Form1 : Form
    {
        private List<UserList> userList = new List<UserList>();
        // private List<UserList> userList = [];

        private const string conString = "Data Source=localhost;Inital Catalog=BcaV;Integrated Security=SSPI;TrustServerCertificate=true";

        private static SqlConnection conn = new SqlConnection(conString);

        private static SqlCommand cmd = new SqlCommand("", conn);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            // DvgUserList.DataSource = ;

        }
        private void loadData()
        {
            cmd.CommandText = "Select * from UserList";
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserList user = new UserList();
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.UserName = Convert.ToString(reader["UserName"]);
                    user.LoginId = Convert.ToString(reader["LoginId"]);
                    user.LoginPassword = Convert.ToString(reader["LoginPassword"]);
                    user.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    userList.Add(user);

                }

            }
            catch { }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
               
        }
    }
}