using ConsoleDialogLib;
using ConsoleIOLib;
using ArrayUtilsLib;

namespace Lab6
{
    public class Program
    {
        private static readonly string[] sources = new string[3]{
            "Эта строка have 2 ids.",
            "Эта string имеет только один идентификатор.",
            "Эта строка не имеет идентификаторов."
        };

        public static void Main() => ConsoleDialog.ShowDialog(MainDialog());

        public static ConsoleDialog MainDialog() =>
            new(
                Messages.MainMenuWelcome,
                options: new() {
                    new(
                        Messages.MainMenuOptionTask1,
                        (dialog) => ConsoleDialog.ShowDialog(Task1Dialog())
                    ),
                    new(
                        Messages.MainMenuOptionTask2,
                        (dialog) => ConsoleDialog.ShowDialog(Task2Dialog())
                    )
                }
            );

        private static ConsoleDialog Task1Dialog() =>
            new(
                Messages.Task1MenuWelcome,
                options: new() {
                    new(
                        Messages.Task1MenuOptionInput,
                        (dialog) => Task1Process(),
                        pauseAfterExecuted: true
                    ),
                    new(
                        Messages.Task1MenuOptionRandom,
                        (dialog) => Task1Process(true),
                        pauseAfterExecuted: true
                    )
                }
            );

        private static ConsoleDialog Task2Dialog() =>
            new(
                Messages.Task2MenuWelcome,
                options: new() {
                    new(
                        Messages.Task2MenuOptionInput,
                        (dialog) => Task2Process(),
                        pauseAfterExecuted: true
                    ),
                    new(
                        Messages.Task2MenuOptionRandom,
                        (dialog) => ConsoleDialog.ShowDialog(Task2ChoiceDialog())
                    )
                }
            );

        private static ConsoleDialog Task2ChoiceDialog()
        {
            var dialog = new ConsoleDialog(Messages.Task2ChoiceMenuWelcome);
            foreach (var source in sources)
                dialog.AddOption(new ConsoleDialogOption(
                    source,
                    (_) => Task2Process(source),
                    clearAfterExecuted: false,
                    pauseAfterExecuted: true,
                    exitAfterExecuted: true
                ));
            return dialog;
        }

        private static void Task1Process(bool random = false)
        {
            int[] array = random ? ArrayUtils.CreateRandomArray(20, 100) : ArrayUtils.CreateArray<int>();
            ArrayUtils.PrettyPrintArray(array, Messages.Task1ProcessOutputArray);
            if (array.Length == 0)
            {
                ConsoleIO.WriteLine(Messages.Task1ProcessEmptyArray);
            }
            else
            {
                var (minIndex, maxIndex, sum) = Tasks.TaskCalcSum(array);
                ConsoleIO.WriteLine(string.Format(
                    Messages.Task1ProcessOutputSum,
                    array[minIndex],
                    array[maxIndex],
                    sum
                ));
            }
        }

        private static void Task2Process(string? source = null)
        {
            var shortestIdentifier = Tasks.TaskFindMinIdentifier(
                source ?? ConsoleIO.InputRaw(Messages.Task2ProcessInput)
            );
            ConsoleIO.WriteLine(shortestIdentifier == null
                ? Messages.Task2ProcessOutputEmpty
                : string.Format(Messages.Task2ProcessOutput, shortestIdentifier)
            );
        }
    }
}
