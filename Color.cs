using System;

public class Color
{
    // Instance variables for red, green, blue, and alpha values
    private int red, green, blue, alpha;

    // Constructor to initialize all four values
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = ClampValue(red);
        this.green = ClampValue(green);
        this.blue = ClampValue(blue);
        this.alpha = ClampValue(alpha);
    }

    // Constructor with default alpha = 255
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Method to ensure values stay within 0-255 range
    private int ClampValue(int value)
    {
        return Math.Max(0, Math.Min(255, value));
    }

    // Getter and Setter Methods
    public int GetRed() { return red; }
    public int GetGreen() { return green; }
    public int GetBlue() { return blue; }
    public int GetAlpha() { return alpha; }

    public void SetRed(int value) { red = ClampValue(value); }
    public void SetGreen(int value) { green = ClampValue(value); }
    public void SetBlue(int value) { blue = ClampValue(value); }
    public void SetAlpha(int value) { alpha = ClampValue(value); }

    // Method to calculate grayscale value
    public int GetGrayScale()
    {
        return (red + green + blue) / 3;
    }

    // Method to display color details
    public void DisplayColor()
    {
        Console.WriteLine($"Color - Red: {red}, Green: {green}, Blue: {blue}, Alpha: {alpha}, Grayscale: {GetGrayScale()}");
    }
}
