class Room
{
    public Vector2i size
    {
        private set;
        get;
    }

    private char[][] tileMap;

    public Room(int width, int height)
    {
        size = new Vector2i(width, height);

        tileMap = new char[width][];

        for (int x = 0; x < size.x; x++)
        {
            tileMap[x] = new char[height];
            for (int y = 0; y < size.y; y++)
            {
                tileMap[x][y] = ' ';
                if (x == 0 || x == size.x - 1 || y == 0 || y == size.y - 1)
                    tileMap[x][y] = '#';
            }
        }
    }

    public Room(Vector2i size) : this(size.x, size.y) {}

    public void Display()
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Gray;

        for (int x = 0; x < size.x; x++)
        {
            Console.WriteLine(tileMap[x]);
        }

    }
}