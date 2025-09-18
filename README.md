# PointCode

A C# project demonstrating Object-Oriented Programming (OOP) by implementing a **Point** class that can move in different directions.

## Description

This project defines a `Point` class with properties `(x, y)` and methods that allow moving the point across the coordinate plane.
The implementation follows OOP principles:

* **Encapsulation** – Protecting point data `(x, y)` with controlled access through methods.
* **Constructors** – Initializing points with given coordinates.
* **Methods** – Moving the point in different directions (right, left, up, down).
* **Override ToString()** – For readable representation of the point.

The project evolved as follows:

* Initially created and developed by **InvarGervi123**.
* Improved by my father, a senior developer with over 10 years of experience in a high-tech company, who optimized structure and readability.
* Later I made additional enhancements to improve performance and maintainability.

## Project Structure

```
JUSTWRITEONCS/    # Source code folder
JUSTWRITEONCS.sln # Visual Studio solution file
.gitattributes
.gitignore
```

## Usage Example

```csharp
Point p = new Point(0, 0);
p.MoveRight();
p.MoveUp();
Console.WriteLine(p); // Displays the new coordinates of the point
```

## Technologies

* Language: **C#**
* Environment: **.NET / Visual Studio**

## Contributors

* [InvarGervi123](https://github.com/InvarGervi123) – Initial development and improvements
* [DanatasG](https://github.com/DanatasG) – Additional improvements
