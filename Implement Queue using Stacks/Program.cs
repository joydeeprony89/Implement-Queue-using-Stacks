using System;
using System.Collections.Generic;

namespace Implement_Queue_using_Stacks
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class MyQueue
  {
    Stack<int> pushStk = null;
    Stack<int> popStk = null;


    public MyQueue()
    {
      pushStk = new Stack<int>();
      popStk = new Stack<int>();
    }

    public void Push(int x)
    {
      pushStk.Push(x);
    }

    public int Pop()
    {
      Peek();
      return popStk.Pop();
    }

    public int Peek()
    {
      if (popStk.Count == 0)
      {
        while (pushStk.Count > 0)
        {
          popStk.Push(pushStk.Pop());
        }
      }

      return popStk.Peek();
    }

    public bool Empty()
    {
      return pushStk.Count == 0 && popStk.Count == 0;
    }
  }

  /**
   * Your MyQueue object will be instantiated and called as such:
   * MyQueue obj = new MyQueue();
   * obj.Push(x);
   * int param_2 = obj.Pop();
   * int param_3 = obj.Peek();
   * bool param_4 = obj.Empty();
   */
}
