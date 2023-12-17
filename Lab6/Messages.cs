namespace Lab6
{
    public class Messages
    {
        public const string MainMenuWelcome = "Выберите задание:";
        public const string MainMenuOptionTask1 = "Задание 1";
        public const string MainMenuOptionTask2 = "Задание 2";
        public const string MainMenuOptionExit = "Выход";
        public const string Task1MenuWelcome = "Задание 1:"
                + "\n1. Сформировать динамический одномерный массив, заполнить его случайными числами и вывести на печать."
                + "\n2. Найти сумму всех четных элементов, которые находятся между первым минимальным элементом и последним "
                + "максимальным элементом массива. Минимальных и максимальных элементов в массиве может быть несколько."
                + "\nВыберите опцию:";
        public const string Task1MenuOptionInput = "Создать массив вручную";
        public const string Task1MenuOptionRandom = "Создать массив cо случайными значениями";
        public const string Task2MenuWelcome = "Задание 2:"
                + "\n1. Ввести строку символов с клавиатуры. Строка состоит из слов, "
                + "разделенных пробелами (пробелов может быть несколько) и знаками препинания (, ;:). "
                + "В строке может быть несколько предложений, в конце каждого предложения стоит знак препинания (.!?)."
                + "\n2. Определить есть ли в строке идентификаторы, если есть, то напечатать самый короткий идентификатор."
                + "\nВыберите опцию:";
        public const string Task2MenuOptionInput = "Ввести строку вручную";
        public const string Task2MenuOptionRandom = "Выбрать строку из списка заготовленных строк";
        public const string Task2ChoiceMenuWelcome = "Выберите строку:";
        public const string TasksMenuOptionExit = "Назад";
        public const string Task1ProcessOutputArray = "Одномерный массив: ";
        public const string Task1ProcessEmptyArray = "Массив пустой, невозможно найти мин./макс. элементы.";
        public const string Task1ProcessOutputSum = 
                "Сумма всех четных элементов между первым мин. элементом "
                + "({0}) и последним макс. элементом ({1}): {2}";
        public const string Task2ProcessInput = "Введите строку символов: ";
        public const string Task2ProcessOutputEmpty = "В введенной строке нет идентификаторов.";
        public const string Task2ProcessOutput = "Самый короткий идентификатор в строке: {0}.";
    }
}