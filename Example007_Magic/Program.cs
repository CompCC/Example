Console.Clear();
//Console.SetCursorPosition(1, 10);
//Console.WriteLine("+");
int indentA = 1, strA = 20, indentB =30, strB = 1, indentC = 60, strC = 20;

Console.SetCursorPosition(indentA, strA);
Console.WriteLine("+");

Console.SetCursorPosition(indentB, strB);
Console.WriteLine("+");

Console.SetCursorPosition(indentC, strC);
Console.WriteLine("+");

int x = indentA;
int y = strA;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0,3);
    if(what == 0)
    {
        x = (x + indentA)/2;
        y = (y + strA)/2;
    }
    if(what == 1)
    {
        x = (x + indentB)/2;
        y = (y + strB)/2;
    }
    if(what == 2)
    {
        x = (x + indentC)/2;
        y = (y + strC)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
