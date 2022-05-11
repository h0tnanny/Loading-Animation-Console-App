# Loading-Animation-Console-App
Loading animation for the console application. To display the operation status of the method.
This project is very easy to use, and each animation is flexibly customizable.

# ⭮ Spinner Animation

![Example use animation](https://github.com/h0tnanny/Loading-Animation-Console-App/blob/master/Resources/Example.gif?raw=true)

Example use animation

```C#
//...
ConsoleSpinner ConsoleSpinner = new ConsoleSpinner(entry, "[","]", 500, ConsoleSpinner.PositionSpinner.Left);
Task.Run(() => ConsoleSpinner.Turn());
// Method processing
ConsoleSpinner.Stop("OK", ConsoleColor.Green);
//...
```

# In development
✅ Spinner → [ - ] → [ \\ ] → [ | ] → [ / ]

🔜 Ellipsis → . → .. → ...

🔜 Progress bar → Item 3 of 10 | (30%) ■■■------------ |
