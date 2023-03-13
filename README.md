栈的特点
1、后进先出，只能对顶端进行操作，因此速度较快
2、每个栈都有极限数量

使用数组实现栈，各方法的时间复杂度：
AddFromTop(等价于Push):o(1)
RemoveFromTop(等价于Pop):o(1)
GetFromTop(等价于Peek):o(1)
UpdateTop:o(1)
IsEmpty:o(1)
IsFull:o(1)

与官方类实现方法基本一致，官方类属性多version,多size少topIndex（本质上是一个东西）