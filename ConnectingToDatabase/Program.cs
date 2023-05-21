using System.Data.SqlClient;

SqlConnection connection; // stores information about connection to database 

SqlCommand command; // store sql commands 

SqlDataReader reader; // reading data from database 


string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VolleyballDatabase;Integrated Security=True;Pooling=False";
connection = new SqlConnection(connectionString);

command = new SqlCommand("select * from players", connection);

connection.Open();

reader = command.ExecuteReader();

while (reader.Read())
{
    string result = reader.GetValue(2) + " " + reader.GetValue(3);
    Console.WriteLine(result);
}

connection.Close();