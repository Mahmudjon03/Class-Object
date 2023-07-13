var theUser =new User();
theUser.Firstname="Umarjon";
theUser.Lastname="Bobozoda";
theUser.Username="Umarjon03";
theUser.Password="Umar123";
string a;
string b;

 System.Console.WriteLine("UserName");
        a=Console.ReadLine();
        System.Console.WriteLine("Password");
        b=Console.ReadLine();

theUser.logoit();
theUser.Login(a,b);
theUser.GetFullinfo();


