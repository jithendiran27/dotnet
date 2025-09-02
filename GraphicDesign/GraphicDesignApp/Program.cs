using Design;
// using System.Collections;
using System.Collections.Generic;
// using System.Collection.Generic;

Line line = new Line();


List<Line> lines = new List<Line>();
Line l1 = new Line(new Point(50, 1), new Point(50,9), Color.Blue, 5 );
Line l2 = new Line(new Point(5, 50), new Point(70, 50), Color.Red, 15 );

    lines.Add(l1);
    lines.Add(l2);

    l1.draw();
