// Console.WriteLine("=== try-catch: FormatException ===");

// try
// {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());
//     Console.WriteLine($"Вы ввели: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введено не число!");
// }

// Console.WriteLine("Программа продолжает работу как ни в чём не бывало");

// Console.WriteLine();
// Console.WriteLine("=== ex.Message ===");

// try
// {
//     int[] numbers = { 1, 2, 3 };
//     Console.WriteLine(numbers[10]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine($"Произошла ошибка: {ex.Message}");
// }

// Console.WriteLine();
// Console.WriteLine("=== Несколько catch ===");

// Console.Write("Введите делитель: ");
// try
// {
//     int divisor = int.Parse(Console.ReadLine());
//     int result = 100 / divisor;
//     Console.WriteLine($"Результат: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: это не число");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Ошибка: нельзя делить на ноль");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
// }


// Console.WriteLine();
// Console.WriteLine("=== finally ===");

// try
// {
//     Console.WriteLine("Пытаемся выполнить операцию...");
//     int[] numbers = { 1, 2, 3 };
//     Console.WriteLine(numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Этот блок выполнится в любом случае");
// }

// Console.WriteLine();
// Console.WriteLine("=== finally без ошибки ===");

// try
// {
//     Console.WriteLine("Операция без ошибок");
// }
// finally
// {
//     Console.WriteLine("И здесь finally тоже сработал");
// }


// Console.WriteLine();
// Console.WriteLine("=== throw ===");

// try
// {
//     double result = CalculateSquareRoot(-5);
//     Console.WriteLine(result);
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }

// double CalculateSquareRoot(double number)
// {
//     if (number < 0)
//     {
//         throw new ArgumentException("Число не может быть отрицательным");
//     }
//     return Math.Sqrt(number);
// }

// Console.WriteLine();
// Console.WriteLine("=== Собственное исключение ===");

// try
// {
//     Withdraw(1000, 1500);
// }
// catch (NegativeBalanceException ex)
// {
//     Console.WriteLine($"Операция отклонена: {ex.Message}");
// }

// Withdraw(1000, 400);

// void Withdraw(double balance, double amount)
// {
//     if (amount > balance)
//     {
//         throw new NegativeBalanceException($"Недостаточно средств: на счёте {balance}, а нужно снять {amount}");
//     }
//     Console.WriteLine($"Снято {amount}, остаток {balance - amount}");
// }

// class NegativeBalanceException : Exception
// {
//     public NegativeBalanceException(string message) : base(message)
//     {
//     }
// }

// Console.Write("Вы хотите воспользоваться калькулятором? ");
// bool Calculator = Console.ReadLine() == "Yes" ? true : false;
// do
// {
//     try
//     {
//         Console.Write("Вводите только целочисленные данные: \n");
//         double oneNumber = int.Parse(Console.ReadLine());
//         double twoNumber = int.Parse(Console.ReadLine());
//         Console.Write("Введите операцию над числами: \n");
//         string operationCalculator = Console.ReadLine();
//         switch (operationCalculator)
//         {
//             case "+":
//                 Console.WriteLine($"Operation {operationCalculator}: {oneNumber} + {twoNumber} = {oneNumber + twoNumber}");
//                 break;
//             case "-":
//                 Console.WriteLine($"Operation {operationCalculator}: {oneNumber} - {twoNumber} = {oneNumber - twoNumber}");
//                 break;
//             case "*":
//                 Console.WriteLine($"Operation {operationCalculator}: {oneNumber} * {twoNumber} = {oneNumber * twoNumber}");
//                 break;
//             case "/":
//                 Console.WriteLine($"Operation {operationCalculator}: {oneNumber} / {twoNumber} = {oneNumber / twoNumber}");
//                 break;
//             default:
//                 throw new UnknownOperationException($"{operationCalculator} такого действия нету");
//                 break;
//         }
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Ошибка: Вы ввели некорректные данные");
//     }
//     catch (DivideByZeroException)
//     {
//         Console.WriteLine("Error: На ноль делить нельзя");
//     }
//     finally
//     {
//         Console.WriteLine("------------------------");
//         Console.WriteLine();
//         Console.Write("Вы хотите воспользоваться калькулятором? ");
//         Calculator = Console.ReadLine() == "Yes" ? true : false;
//     }
// } while (Calculator);


// class UnknownOperationException : Exception
// {
//     public UnknownOperationException(string message) : base(message)
//     {
//     }
// }

//1
// int[] numbers = { 12, 25, 42, 53, 64 };
// Console.Write("Введите индекс элемента: ");

// try
// {
//     string input = Console.ReadLine();
//     int index = int.Parse(input);
//     Console.WriteLine($"Значение по индексу {index}: {numbers[index]}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введено не целое число.");
// }
// catch (IndexOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: индекс выходит за пределы массива.");
// }

//2
// Console.Write("Введите ваш возраст: ");

// try
// {
//     int age = int.Parse(Console.ReadLine());
//     CheckAge(age);
//     Console.WriteLine("Возраст успешно подтверждён!");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введено не числовое значение.");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }

// static void CheckAge(int age)
// {
//     if (age < 0 || age > 120)
//     {
//         throw new ArgumentException("Возраст должен находиться в диапазоне от 0 до 120 лет.");
//     }
// }

//3
// double balance = 5000.0;

// Console.WriteLine($"\nТекущий баланс: {balance} руб.");
// Console.WriteLine("1. Пополнить счёт");
// Console.WriteLine("2. Снять средства");
// Console.Write("Выберите действие (1-2): ");

// string choice = Console.ReadLine();

// Console.Write("Введите сумму: ");
// string input = Console.ReadLine();

// try
// {
//     if (!double.TryParse(input, out double amount))
//     {
//         throw new FormatException("Введено неверное число");
//     }

//     if (choice == "1")
//     {
//         Deposit(ref balance, amount);
//         Console.WriteLine("Счёт успешно пополнен");
//     }
//     else if (choice == "2")
//     {
//         Withdraw(ref balance, amount);
//         Console.WriteLine("Средства успешно списаны");
//     }
//     else
//     {
//         Console.WriteLine("Неизвестная операция");
//     }
// }
// catch (InvalidAmountException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// catch (InsufficientFundsException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// catch (FormatException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"Состояние счёта после операции: {balance} руб.");
// }


// void Deposit(ref double balance, double amount)
// {
//     if (amount <= 0)
//     {
//         throw new InvalidAmountException("Сумма пополнения должна быть больше нуля");
//     }
//     balance += amount;
// }

// void Withdraw(ref double balance, double amount)
// {
//     if (amount <= 0)
//     {
//         throw new InvalidAmountException("Сумма снятия должна быть больше нуля");
//     }
//     if (amount > balance)
//     {
//         throw new InsufficientFundsException("Недостаточно средств на счёте для выполнения операции");
//     }
//     balance -= amount;
// }



// class InsufficientFundsException : Exception
// {
//     public InsufficientFundsException(string message) : base(message) { }
// }

// class InvalidAmountException : Exception
// {
//     public InvalidAmountException(string message) : base(message) { }
// }