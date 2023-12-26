using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;


Console.WriteLine("Welcome");


MySqlConnection con=new MySqlConnection();
con.ConnectionString="server=192.168.10.150;port=3306;user=dac19;password=welcome;database=dac19";
//string query="select * from product";//1


//string query="select count(*)  from product";//2

string query="insert into product values(@one,@two)" ;



MySqlCommand command=new MySqlCommand(query,con);

try{
    con.Open();


    //MySqlDataReader reader=command.ExecuteReader();//1


   //  int n=int.Parse(command.ExecuteScalar().ToString());//2

//while (reader.Read())//1
//{
// int PRODID=int.Parse(reader["PRODID"].ToString());
// string DESCRIP=reader["DESCRIP"].ToString();
// Console.WriteLine(PRODID+" "+DESCRIP);


// int CNT=int.Parse(reader["PRODID"].ToString());
// string DESCRIP=reader["DESCRIP"].ToString();
//  Console.WriteLine(PRODID+" "+DESCRIP);
//  }//1

 //Console.WriteLine(n);//2

  int one;
  String two;
  Console.WriteLine("enter PROID");

one=int.Parse(Console.ReadLine());
   


  Console.WriteLine("enter DESCRIP");

two=(Console.ReadLine());
command.Parameters.AddWithValue("@one",one);
command.Parameters.AddWithValue("@two",two);
int reader=command.ExecuteNonQuery();
}



catch(Exception e){
       Console.WriteLine(e.Message);
}
finally{

con.Close();

}