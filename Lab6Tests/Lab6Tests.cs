namespace Lab6Tests
{
    public class Lab6Test
    {
        [Fact]
        public void Test()
        {
            var consoleIO = new TestableConsoleIO();

            //* main menu -> task 1 menu
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input no elem array
            consoleIO.PushLine("0");
            //* task 1 option 1 test no elem input
            consoleIO.PushTest(TestTask1NoElementsInput);
            //* task 1 option 1 test no elem output
            consoleIO.PushTest(TestTask1NoElementsOutput);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input no elem between array
            consoleIO.PushLine("3", "1", "3", "5");
            //* task 1 option 1 test no elem between input
            consoleIO.PushTest(TestTask1NoElementsBetweenInput);
            //* task 1 option 1 test no elem between output
            consoleIO.PushTest(TestTask1NoElementsBetweenOutput);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input one elem array
            consoleIO.PushLine("1", "1");
            //* task 1 option 1 test one elem input
            consoleIO.PushTest(TestTask1OneElementInput);
            //* task 1 option 1 test one elem output
            consoleIO.PushTest(TestTask1OneElementOutput);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input normal array
            consoleIO.PushLine("4", "1", "3", "4", "5");
            //* task 1 option 1 test normal input
            consoleIO.PushTest(TestTask1NormalArrayInput);
            //* task 1 option 1 test normal output
            consoleIO.PushTest(TestTask1NormalArrayOutput);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 1 option 1 input min elem index greater than max elem index array
            consoleIO.PushLine("5", "1", "9", "4", "2", "0");
            //* task 1 option 1 test elem index greater than max elem index input
            consoleIO.PushTest(TestTask1MinGreaterThanMaxInput);
            //* task 1 option 1 test elem index greater than max elem index output
            consoleIO.PushTest(TestTask1MinGreaterThanMaxOutput);
            //* task 1 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 1 menu -> option 2 select -> option 2 enter -> option 2 pause
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Enter);
            //* task 1 menu -> option 3 select (back) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);

            //* main menu -> option 2 select (task 2 menu) -> option 2 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);

            //* task 2 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 option 1 input no id string
            consoleIO.PushLine("Нет айдишников, уклали :(");
            //* task 2 option 1 test no id output
            consoleIO.PushTest(TestTask2NoId);
            //* task 2 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 2 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 option 1 input one id string
            consoleIO.PushLine("В этой строке один _id.");
            //* task 2 option 1 test one id output
            consoleIO.PushTest(TestTask2OneId);
            //* task 2 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 2 menu -> option 1 enter
            consoleIO.PushKey(ConsoleKey.Enter);
            //* task 2 option 1 input second id shortest string
            consoleIO.PushLine("Тут аж three ids, LOL.");
            //* task 2 option 1 test second id shortest output
            consoleIO.PushTest(TestTask2SecondIdShortest);
            //* task 2 option 1 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 2 menu -> option 2 select -> option 2 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* task 2 choice menu -> option 2 select -> option 2 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* task 2 choice menu option 2 test output
            consoleIO.PushTest(TestTask2Chosen);
            //* task 2 choice menu option 2 pause
            consoleIO.PushKey(ConsoleKey.Enter);

            //* task 2 menu -> option 3 select (back) -> option 3 pause
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);
            //* main menu -> option 3 select (exit) -> option 3 enter
            consoleIO.PushKey(ConsoleKey.DownArrow, ConsoleKey.Enter);

            Program.MainDialog();
        }

        private static void TestTask1NoElementsInput(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Массив пуст";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1NoElementsOutput(string? output)
        {
            // arrange
            var exceptedOutput = "Массив пустой, невозможно найти мин./макс. элементы.";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1NoElementsBetweenInput(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Int32[3] { 1, 3, 5 }";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1NoElementsBetweenOutput(string? output)
        {
            // arrange
            var exceptedOutput =
                "Сумма всех четных элементов между первым мин. элементом (1) и последним макс. элементом (5): 0";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1OneElementInput(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Int32[1] { 1 }";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1OneElementOutput(string? output)
        {

            // arrange
            var exceptedOutput =
                "Сумма всех четных элементов между первым мин. элементом (1) и последним макс. элементом (1): 0";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1NormalArrayInput(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Int32[4] { 1, 3, 4, 5 }";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1NormalArrayOutput(string? output)
        {
            // arrange
            var exceptedOutput =
                "Сумма всех четных элементов между первым мин. элементом (1) и последним макс. элементом (5): 4";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1MinGreaterThanMaxInput(string? output)
        {
            // arrange
            var exceptedOutput = "Одномерный массив: Int32[5] { 1, 9, 4, 2, 0 }";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask1MinGreaterThanMaxOutput(string? output)
        {
            // arrange
            var exceptedOutput =
                "Сумма всех четных элементов между первым мин. элементом (0) и последним макс. элементом (9): 6";

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask2NoId(string? output)
        {
            // arrange
            var exceptedOutput = "В введенной строке нет идентификаторов."; // input "Нет айдишников, уклали :("

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask2OneId(string? output)
        {
            // arrange
            var exceptedOutput = "Самый короткий идентификатор в строке: _id"; // input "В этой строке один _id."

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask2SecondIdShortest(string? output)
        {
            // arrange
            var exceptedOutput = "Самый короткий идентификатор в строке: ids"; // input "Тут аж three ids, LOL."

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
        private static void TestTask2Chosen(string? output)
        {
            // arrange
            var exceptedOutput = "Самый короткий идентификатор в строке: string"; // t2cdmo2

            // act

            // assert
            Assert.Contains(exceptedOutput, output);
        }
    }
}