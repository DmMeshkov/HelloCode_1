Console.Clear();
//Console.SetCursorPosition(10,8);
//Console.WriteLine("+");

int xa = 15, ya = 1,
    xb = 1, yb = 15,
    xc = 30, yc= 18;

Console.SetCursorPosition(xa, ya); 
Console.WriteLine("0");

Console.SetCursorPosition(xb, yb); 
Console.WriteLine("0");

Console.SetCursorPosition(xc, yc); 
Console.WriteLine("0");

int x = xa, y = xb;
int count = 0;

while (count<400)
{
    int what = new Random().Next(0, 3); //[0,3) 0,1,2
    if (what==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    } 
    if (what ==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
     if (what==2)
     {
        x=(x+xc)/2;
        y=(y+yc)/2;
     }

     Console.SetCursorPosition(x,y);
     Console.WriteLine("0");
     count++;

}