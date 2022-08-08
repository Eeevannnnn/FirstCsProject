using System;
using System.Collections.Generic;

namespace A
{
  class Q{
    static bool Check(string str)
    {
      Stack<char> stack;
      foreach (var i in str)
      {
        switch (i)
        {
          case '(':case '[':case '{':
            stack.Push(i);
            break;
          case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
              return false;
            }
            break;
          case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
              return false;
            }
            break;
          case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
              return false;
            }
            break;
        }
      }
      return stack.Count == 0;
}
