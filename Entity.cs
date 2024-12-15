class Entity
{

    // -- Static Field -- //
    private static List<Entity> entities = new List<Entity>();

    public static void DrawAll()
    {
        foreach(var entity in entities)
        {
            entity.Draw();
        }
    }

    public static void UpdateAll()
    {
        foreach(var entity in entities)
        {
            entity.Update();
        }
    }


    // -- Object Field -- //
    public char sprite;
    public Vector2i position;
    public int level
    {
        get;
        protected set;
    }

    public ConsoleColor color
    {
        private set;
        get;
    }

    public Entity(char sprite = '#', Vector2i? position = null, ConsoleColor color = ConsoleColor.Gray)
    {
        this.sprite = sprite;
        this.position = position ?? new Vector2i(0, 0);
        this.color = color;
        this.level = 1;
        entities.Add(this);
    }

    ~Entity()
    {
        entities.Remove(this);
    }

    public void Draw()
    {
        Console.ForegroundColor = color;
        
        Console.SetCursorPosition(position.x, position.y);
        Console.Write(sprite);
    }

    public virtual void Update()
    {

    }
}