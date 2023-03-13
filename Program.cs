using System.Collections;
using data_strcucture_stack;

var stack = new Stackk<string>(5);

stack.AddFromTop("1");
stack.AddFromTop("2");
var removedTop = stack.RemoveFromTop();
var top = stack.GetFromTop();
Console.WriteLine(removedTop);
Console.WriteLine(top);

stack.AddFromTop("3");
stack.AddFromTop("4");
stack.AddFromTop("5");
var removedTop2 = stack.RemoveFromTop();
var top2 = stack.GetFromTop();
Console.WriteLine(removedTop2);
Console.WriteLine(top2);


stack.UpdateTop("6");
var top3 = stack.GetFromTop();
Console.WriteLine(top3);
