using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Player : Entity
{
    // -- Singleton -- //
    private static Player? instance;

    private Vector2i direction = new Vector2i(0, 0);

    private Player(Vector2i? position = null, ConsoleColor color = ConsoleColor.Green)
    : base('☺', position, color)
    {
        
    }

    public static Player GetInstance(Vector2i? position = null, ConsoleColor color = ConsoleColor.Green)
    {
        if (instance == null)
        {
            instance = new Player(position, color);
        }
        return instance;
    }

    /// <summary>
    /// Called every game loop.
    /// </summary>
    public override void Update()
    {
        var key = Console.ReadKey(true);
        KeyAction(key);
        position += direction;
    }

    private void KeyAction(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.UpArrow: direction = new Vector2i(0, -1); break;
            case ConsoleKey.RightArrow: direction = new Vector2i(1, 0); break;
            case ConsoleKey.DownArrow: direction = new Vector2i(0, 1); break;
            case ConsoleKey.LeftArrow: direction = new Vector2i(-1, 0); break;
        }
    }

    public void LevelUp()
    {
        this.level++;
    }

    public void LevelUp(int levelIncrease)
    {
        this.level += levelIncrease;
    }
}