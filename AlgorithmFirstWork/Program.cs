using System;

namespace AlgorithmFirstWork
{
    class Program
    {

        static DateTime before;
        public static DateTime after;
        static void Main(string[] args)
        {
            IFileWorker worker = new FileWorker();

            ISorter sorter = new BubbleSorter();

            Validator validator = new Validator();

            int[] data;

            string getFileName;
            string saveFileName;


            
            while (true)
            {
                Console.WriteLine("Введите название файла, откуда необходимо взять массив");
                getFileName = validator.CheckFileName(Console.ReadLine());
                if (validator.IsFileExist(getFileName))
                {
                    Console.WriteLine("Выберите способ сортировки");
                    Console.WriteLine("1 - Сортировка пузырьком");
                    Console.WriteLine("2 - Сортировка вставками");
                    Console.WriteLine("3 - Сортировка выбором");
                    Console.WriteLine("4 - Сортировка слиянием");
                    Console.WriteLine("5 - Быстрая сортировка");
                    Console.WriteLine("6 - Пирамидальная сортировка");
                    Console.WriteLine("7 - Сортировка бинарным деревом");
                    string choose = Console.ReadLine(); 
                    bool flag = true;
                        switch (choose)
                        {
                            case "1":
                                {  
                                    sorter = new BubbleSorter();
                                    break;
                                }
                            case "2":
                                {
                                    sorter = new InsertSorter();
                                    break;
                                }
                            case "3":
                                {
                                    sorter = new SelectionSorter();
                                    break;
                                }
                            case "4":
                                { 
                                    sorter = new MergeSorter();
                                    break;
                                }
                            case "5":
                                {
                                sorter = new QuickSorter();
                                break;
                                }
                            case "6":
                            {
                                sorter = new HeapSorter();
                                break;
                            }
                        case "7":
                            {
                                sorter = new TreeSorter();
                                break;
                            }
                        default:
                                {
                                    Console.WriteLine("Неверная команда!");  
                                    flag = false;
                                    break;
                                }
                        }
                    
                    if (flag)
                    {
                        var unsorted = worker.GetData(getFileName);
                        if (unsorted == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Данные в файле не корректны!");
                        }
                        else
                        {
                            Console.WriteLine("Введите название файла, куда необходимо сохранить массив");
                            saveFileName = validator.CheckFileName(Console.ReadLine());
                            before = DateTime.UtcNow;
                            data = sorter.Sort(unsorted);
                            Program.after = DateTime.UtcNow;

                            worker.SaveData(data, saveFileName);
                            Console.Clear();
                            Console.WriteLine("Выполнено!");
                            Console.WriteLine("На выполнение алгоритма потрачено " + (after - before).TotalMilliseconds + " миллисекунд");
                        }
                    }
                   
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Файл не найден!");
                }
            
                
            }
        }
    }
}
