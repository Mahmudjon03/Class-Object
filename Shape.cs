public class Shape{
    public string ?Name;
    public string ?Color;
    public int PositionX;
    public int PositionY;

    public void GetPosition(){
        System.Console.WriteLine($"Position-x = {PositionX}");
        System.Console.WriteLine($"Position-y ={PositionY}");
    } 
    public void GetFullinfo(){
        System.Console.WriteLine($"Name={Name}");
        System.Console.WriteLine($"Color = {Color}");
        System.Console.WriteLine($"Position-x = {PositionX}");
        System.Console.WriteLine($"Position-y ={PositionY}");
    }
}
