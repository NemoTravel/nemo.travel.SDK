using System;
using System.Collections.Generic;

namespace SharedAssembly.Extensions
{
	public static class StackExtension
	{
		public static bool TryPeek<T>(this Stack<T> stack, out T value)
		{
			return ProcessStack(stack, s => s.Peek(), out value);
		}

		public static bool TryPop<T>(this Stack<T> stack, out T value)
		{
			return ProcessStack(stack, s => s.Pop(), out value);
		}


		private static bool ProcessStack<T>(Stack<T> stack, Func<Stack<T>, T> processor, out T value)
		{
			if (stack.Count == 0)
			{
				value = default;
				return false;
			}

			value = processor(stack);
			return true;
		}
	}
}