namespace Collections
{
    internal class Program
    {
        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }

        private class ListTask
        {
            private readonly List<string> _listOfStrings = new List<string>()
            {
                 "Sasha", "Oleg", "Sergey", "Dmitry"
            };
            public void TaskLoop()
            {
                var exit = "-exit";
                Console.WriteLine("Чтобы остановить программу, введите " + exit);

                while (true)
                {
                    Console.WriteLine("Введите имя: ");
                    var input1 = Console.ReadLine();

                    if (input1 == exit) { break; }

                    _listOfStrings.Add(input1);
                    Console.WriteLine(new string('*', 20));

                    foreach (var list in _listOfStrings)
                    {
                        Console.WriteLine(list);
                    }

                    Console.WriteLine("Введите еще одно имя: ");

                    var input2 = Console.ReadLine();
                    if (input1 == exit) { break; }

                    _listOfStrings.Insert(_listOfStrings.Count / 2, input2);
                    Console.WriteLine(new string('*', 20));

                    foreach (var list in _listOfStrings)
                    {
                        Console.WriteLine(list);
                    }
                }
            }
        }

        private class DictionaryTask
        {
            private readonly Dictionary<string, int> _studetsMap = new Dictionary<string, int>();


            public void TaskLoop()

            {
                var exit = "-exit";
                Console.WriteLine("Чтобы остановить программу, введите " + exit);

                while (true)
                {
                    Console.WriteLine("Введите имя студента: ");
                    var studentName = Console.ReadLine();
                    if (studentName == exit) { break; }

                    Console.WriteLine("Введите оценку студента не менее 2 и не более 5: ");
                    var number = Console.ReadLine();
                    if (number == exit) { break; }

                    if (int.TryParse(number, out int studentNumber) && studentNumber > 1 && studentNumber < 6)
                    {
                        _studetsMap.Add(studentName, studentNumber);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не правильную оцеку");
                    }

                    foreach (var dict in _studetsMap)
                    {
                        Console.WriteLine(dict.Key);
                    }
                    Console.WriteLine("Введите имя студента из списка");
                    var inputName = Console.ReadLine();

                    if (inputName == exit)
                    {
                        break;
                    }
                    if (_studetsMap.TryGetValue(inputName, out int mark))
                    {
                        Console.WriteLine($"Оценка: {mark}");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Студента с таким именем нет");
                    }
                }

            }
        }

        private class LinkedListTask
        {
            public void TaskLoop()
            {

                LinkedList<string> people = new LinkedList<string>();
                
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите элемент ");

                    var input = Console.ReadLine();

                    people.AddLast(input);
                }
                Console.WriteLine(new String('*', 15));
               
                var currentNode = people.First;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Next;
                }

                Console.WriteLine(new String('*', 15));

               
                currentNode = people.Last;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Previous;
                }

            }

            static void Main(string[] args)
            {
                Console.WriteLine("Выберете Номер задания 1, 2, 3");
                int.TryParse(Console.ReadLine(), out int task);

                switch (task)
                {
                    case 1:
                        CheckTaskFirst();
                        break;
                    case 2:
                        CheckTaskSecond();
                        break;
                    case 3:
                        CheckTaskThird();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод данных");
                        break;

                }
            }           
        }
    }

}