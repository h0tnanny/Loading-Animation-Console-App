/*
 * Development platform - .NET Core 6
 */

//Simple example use animation spinner
string[] methods = { "Connect to Server", "User authorization", "Uploading user data" };

foreach (var entry in methods)
{
    ConsoleSpinner consoleSpinner = new(entry, "[", "]", 500, ConsoleSpinner.PositionSpinner.Left);
    Task.Run(() => consoleSpinner.Turn());
    Thread.Sleep(new Random().Next(1000,3500));
    consoleSpinner.Stop("OK", ConsoleColor.Green);
}