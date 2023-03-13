namespace data_strcucture_stack;

public class Stackk<T>
{
    //后进先出，有最大数量
    private int TopIndex { get; set; }
    private int MaxIndex { get;}
    private T[] Data { get;}
    
    //constructor
    public Stackk(int capacity)
    {
        Data = new T[capacity];
        MaxIndex = capacity - 1;
        TopIndex = -1;
    }
    
    //Add: 从栈顶加入
    public void AddFromTop(T top)
    {
        if (IsFull()) throw new IndexOutOfRangeException("栈已满，将溢出");
        TopIndex++;
        Data[TopIndex] = top;
    }
    
    //Delete: 从栈顶取出
    public T RemoveFromTop()
    {
        if (IsEmpty()) throw new IndexOutOfRangeException("栈已空");
        var removedTop = Data[TopIndex];
        Data[TopIndex] = default(T);
        TopIndex--;
        return removedTop;
    }
    
    //Read：获取栈顶
    public T GetFromTop()
    {
        if (IsEmpty()) throw new InvalidOperationException("栈已空");
        return Data[TopIndex];
    }
    
    //Read：获取长度
    public int GetLength()
    {
        return TopIndex + 1;
    }
    
    //Read：是否为空
    public bool IsEmpty()
    {
        return TopIndex == -1;
    }
    //Read：是否为满
    public bool IsFull()
    {
        return TopIndex == MaxIndex;
    }

    //update: 更改栈顶的值
    public void UpdateTop(T topValue)
    {
        Data[TopIndex] = topValue;
    }
}