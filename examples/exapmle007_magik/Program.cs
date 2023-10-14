Console.Clear();    //очищение консоли
// Console.SetCursorPosition(10, 4);   //для рисования
// Console.WriteLine("+");  // чем рисуем


int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30, xc = 80, yc = 30;  // сколько точек

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; //определяем первую точку
int count = 10;  //определяем коунт, что бы делить пополам

whele(count < 10000)
{
    int what = new Random().Next(0, 3); //
    if(what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya) / 2;
    }
     if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb) / 2;
    }
     if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc) / 2;
    }    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count ++;   //увеличиваем на 1 каждый цикл
}




