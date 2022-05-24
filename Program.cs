using System;
using System.Collections;
using System.Collections.Generic;


class Point
{
	public int x;
	public int y;

    public override bool Equals(object obj)
    {
		var point = obj as Point;
		if (point == null) return false;
        return point.x >= x && point.y >= y;
    }
    public override string ToString()
    {
        return string.Format("{0}, {1}", x,y);
    }
    //static public Point operator +(Point p1, Point p2)
    //{
    //    return new Point() { x = p1.x + p2.x, y = p1.y + p2.y };
    //}
}
class ListArr<T> : IEnumerable<T>
{
	public List<T> array = new List<T>();

    public IEnumerator<T> GetEnumerator()
    {
        return new ListEnumerator<T>(array);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
class ListEnumerator<T> : IEnumerator<T>
{
    public List<T> array;
    int t = -1;
    T currentItem;
    public ListEnumerator(List<T> aray)
    {
        array = aray;
    }
    public T Current { get
        {
            return currentItem;
        }
    }

    object IEnumerator.Current
    {
        get { return Current; }
    }
    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        if (array.Count <= t + 1) return false;
        currentItem = array[++t];
        return true;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
class Program
{
	static void Main(string[] args)
	{
        ListArr<Point> arrp = new ListArr<Point>();
        arrp.array.Add(new Point() { x = 1, y = 2 });
        arrp.array.Add(new Point() { x = 2, y = 2 });
        arrp.array.Add(new Point() { x = 4, y = 2 });
        foreach (var el in arrp)
        {
            Console.WriteLine(el);
        }
        Console.WriteLine(arrp.array[0] + arrp.array[1]);
	}
}