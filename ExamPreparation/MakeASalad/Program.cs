using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetable = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var calories = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<string> queueOfVegetables = new Queue<string>(vegetable);
            Stack<int> stackOfCalories = new Stack<int>(calories);

            Queue<int> finishedSalad = new Queue<int>();

            int remainingCalories = 0;

            while (true)
            {
                if (queueOfVegetables.Count <= 0)
                {
                    break;
                }
                if (stackOfCalories.Count <= 0)
                {
                    break;
                }

                int currentCaloriest = stackOfCalories.Peek();
                remainingCalories = currentCaloriest;

                while (true)
                {
                    if (queueOfVegetables.Count <= 0)
                    {
                        break;
                    }
                    if (stackOfCalories.Count <= 0)
                    {
                        break;
                    }

                    string currentVegetable = queueOfVegetables.Peek();

                    if (currentVegetable == "tomato")
                    {
                        remainingCalories -= 80;

                        if (remainingCalories <= 0)
                        {
                            finishedSalad.Enqueue(currentCaloriest);
                            stackOfCalories.Pop();
                            break;
                        }
                        queueOfVegetables.Dequeue();

                    }
                    else if (currentVegetable == "carrot")
                    {
                        remainingCalories -= 136;

                        if (remainingCalories <= 0)
                        {
                            finishedSalad.Enqueue(currentCaloriest);
                            stackOfCalories.Pop();
                            break;
                        }
                        queueOfVegetables.Dequeue();

                    }
                    else if (currentVegetable == "lettuce")
                    {
                        remainingCalories -= 109;

                        if (remainingCalories <= 0)
                        {
                            finishedSalad.Enqueue(currentCaloriest);
                            stackOfCalories.Pop();
                            break;
                        }
                        else
                            queueOfVegetables.Dequeue();

                    }
                    else if (currentVegetable == "potato")
                    {
                        remainingCalories -= 215;

                        if (remainingCalories <= 0)
                        {
                            finishedSalad.Enqueue(currentCaloriest);
                            stackOfCalories.Pop();
                            break;
                        else
                        {
                                queueOfVegetables.Dequeue();
                            }
                        }
                    }

                    Console.WriteLine(string.Join(" ", finishedSalad));

                    if (queueOfVegetables.Count > 0)
                    {
                        Console.WriteLine(string.Join(" ", queueOfVegetables));
                    }
                    else if (stackOfCalories.Count > 0)
                    {
                        Console.WriteLine(string.Join(" ", stackOfCalories));
                    }
                }
            }
        }
    }
}

