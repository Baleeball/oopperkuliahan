using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        var test = new Room(10, 15);
        Player player = Player.GetInstance(new Vector2i(10, 4));

        Entity entity = new Entity('$', new Vector2i(3, 3), ConsoleColor.Yellow);

        Entity yea = new Entity('A', new Vector2i(5, 3), ConsoleColor.Blue);
        Entity yo = new Entity('A', new Vector2i(5, 10), ConsoleColor.Blue);

        Console.Clear();
        Console.CursorVisible = false;
        while (true)
        {
            test.Display();
            
            Entity.DrawAll();
            
            Entity.UpdateAll();
        }
    }
}
