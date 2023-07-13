public class User{
    public string Firstname;
    public string Lastname;

    public string Username;
    public string Password;
    public bool IsloggedOn;



    public void Login( string username, string password){
       
        if(username==Username&&password==Password){
            System.Console.WriteLine("User loggen successfully");
            IsloggedOn=true;
 }else{
    System.Console.WriteLine("You password or username  is incorrect");
    
 }
    }
public void logoit(){
IsloggedOn=false;
}
public void GetFullinfo(){
    if(IsloggedOn==true){
 System.Console.WriteLine($"{Firstname}  {Lastname} - True");
    }else{
        System.Console.WriteLine($"{Firstname}  {Lastname} - False");
    }
   }
}
