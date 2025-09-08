namespace Design;

public enum Color {
    Red,
    Blue,
    Green,
    Yellow
}

public abstract class Shape {
    protected int thickness {get; set;}
    protected Color color {get; set;}
    public abstract void draw();
}