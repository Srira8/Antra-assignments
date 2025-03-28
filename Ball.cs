using System;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    // Constructor to initialize ball size and color
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Pop method to set size to 0
    public void Pop()
    {
        size = 0;
        Console.WriteLine("The ball has been popped!");
    }

    // Throw method: Increments throwCount if ball is not popped
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
            Console.WriteLine("The ball has been thrown!");
        }
        else
        {
            Console.WriteLine("Cannot throw a popped ball!");
        }
    }

    // Method to get number of throws
    public int GetThrowCount()
    {
        return throwCount;
    }
}
