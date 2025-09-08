namespace Design;

public class Line: Shape, IDisposable {
    public Point start {get; set;}
    public Point end {get; set;}

    public Line() {
        start = new Point();
        end = new Point();
    }

    public Line (Point start, Point end, Color color, int thickness) {
        this.start = start;
        this.end = end;
        this.color = color;
        this.thickness = thickness;
    }

    public override void draw() {
        Console.WriteLine($"Drawing a line from {start} to {end} with {thickness} thickness and {color} color.");
    }

    ~Line() {
        
    }

    public void Dispose() {
        GC.SuppressFinalize(this);
    }
}