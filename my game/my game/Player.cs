using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Player

{
     private float _movementSpeed;

    public Vector2 Position;
    public Vector2 Size;

    public Player(Vector2 position, Vector2 size)
    {
        Position = position;
        Size = size;
    }

    public void Draw()
    {
    }
    public void Move(Vector2,   step)
    { 
       Position += step;
    }
}