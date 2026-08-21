# VB.NET Programming

## First Practical – Variables and Data Types

Welcome to our **VB.NET Programming** learning journey.

In this class, we started learning programming using **VB.NET Windows Forms Application**. Since this was the students' first time learning programming, we started with the basics and focused on understanding the concepts rather than writing complicated programs.

This practical introduced students to **variables and data types**, which are some of the most important building blocks in programming.

---

## About the Practical

**Programming Language:** VB.NET
**Application Type:** Windows Forms Application
**Level:** Beginner
**Topic:** Variables and Data Types

### What we covered

During this first practical, students were introduced to:

* What programming means
* Introduction to VB.NET
* Windows Forms Application
* Variables
* Data types
* Declaring variables
* Assigning values to variables
* Using variables in a program
* Displaying information using `MessageBox`

---

## What is VB.NET?

VB.NET, also known as **Visual Basic .NET**, is a programming language from Microsoft.

It allows us to create different types of applications. In our lessons, we are using **Windows Forms** to create simple desktop applications.

Windows Forms makes it easier for beginners to understand programming because we can create a visual interface using controls such as:

* Buttons
* Labels
* TextBoxes
* ComboBoxes
* CheckBoxes

We can then write VB.NET code that controls what happens when the user interacts with these controls.

---

# Our First Topic: Variables

One of the first things we learned was the meaning of a **variable**.

A variable is simply a place where a program can store information.

For example, if we want our program to remember a student's name, we can create a variable:

```vb
Dim studentName As String
```

We can then give the variable a value:

```vb
studentName = "John"
```

The variable `studentName` now contains the name **John**.

---

## Declaring a Variable

In VB.NET, we commonly use `Dim` when creating a variable.

The basic structure is:

```vb
Dim variableName As DataType
```

For example:

```vb
Dim age As Integer
```

Here:

* `Dim` tells VB.NET that we are declaring a variable.
* `age` is the variable name.
* `Integer` is the data type.

We can also declare the variable and give it a value at the same time:

```vb
Dim age As Integer = 20
```

---

# Data Types

After learning about variables, we looked at **data types**.

A data type tells the program what kind of information a variable will contain.

Some of the basic data types we used in our first practical were:

| Data Type | What it stores     | Example  |
| --------- | ------------------ | -------- |
| `String`  | Text               | `"John"` |
| `Integer` | Whole numbers      | `20`     |
| `Double`  | Decimal numbers    | `75.5`   |
| `Boolean` | True or False      | `True`   |
| `Char`    | A single character | `"A"`    |

---

## 1. String

A `String` is used to store text.

Example:

```vb
Dim studentName As String = "John"
```

We can also store other types of text:

```vb
Dim course As String = "Programming"
Dim school As String = "ABC College"
```

When writing text in VB.NET, we normally place it inside quotation marks.

---

## 2. Integer

An `Integer` is used for whole numbers.

Example:

```vb
Dim age As Integer = 20
```

Other examples:

```vb
Dim students As Integer = 30
Dim marks As Integer = 80
```

---

## 3. Double

A `Double` is used when we need to store numbers that can contain decimal values.

Example:

```vb
Dim average As Double = 75.5
```

Another example:

```vb
Dim height As Double = 1.75
```

---

## 4. Boolean

A `Boolean` can contain only two values:

```vb
True
False
```

Example:

```vb
Dim isStudent As Boolean = True
```

Another example:

```vb
Dim passed As Boolean = False
```

We will use Boolean values more as we learn about conditions and decision-making.

---

# Our First Practical

For our first practical, students created a simple Windows Forms application and declared different variables.

For example:

```vb
Dim studentName As String = "John"
Dim age As Integer = 20
Dim marks As Double = 75.5
Dim isStudent As Boolean = True
```

The idea was simple: **create variables, give them values, and use those values in the program.**

---

## Displaying the Variables

We used `MessageBox.Show()` to display information.

For example:

```vb
MessageBox.Show(studentName)
```

We also learned that we can combine text and variables.

```vb
MessageBox.Show("Student Name: " & studentName)
```

We can display several pieces of information together:

```vb
MessageBox.Show("Student Name: " & studentName & vbCrLf &
                "Age: " & age & vbCrLf &
                "Marks: " & marks)
```

`vbCrLf` is used to move the next information to a new line.

---

# Practical Exercise

Students were asked to create their own variables using information about themselves.

For example:

```vb
Dim studentName As String = "Brian"
Dim age As Integer = 18
Dim marks As Double = 82.5
Dim isStudent As Boolean = True
```

Then they displayed the information using a button.

Example button code:

```vb
Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

    Dim studentName As String = "Brian"
    Dim age As Integer = 18
    Dim marks As Double = 82.5
    Dim isStudent As Boolean = True

    MessageBox.Show("Student Name: " & studentName & vbCrLf &
                    "Age: " & age & vbCrLf &
                    "Marks: " & marks & vbCrLf &
                    "Is Student: " & isStudent)

End Sub
```

---

# What I Wanted Students to Understand

The main goal of this practical was not for students to memorize the code.

I wanted them to understand the idea behind it.

For example:

```vb
Dim age As Integer = 18
```

The student should be able to explain:

> "I have created a variable called `age`, and I have told VB.NET that it will store an integer. I have then given it the value 18."

That understanding is more important than simply copying the code.

---

# What We Learned

By the end of our first practical, students had been introduced to:

* VB.NET
* Windows Forms Applications
* Variables
* `Dim`
* Variable names
* Data types
* `String`
* `Integer`
* `Double`
* `Boolean`
* Assigning values
* `MessageBox.Show()`
* Button click events
* Basic VB.NET syntax

---

# Beginner Exercise

Try creating a small program containing information about yourself.

Create variables for:

1. Your name
2. Your age
3. Your course
4. Your marks
5. Whether you are a student

Example:

```vb
Dim name As String = "Your Name"
Dim age As Integer = 20
Dim course As String = "VB.NET"
Dim marks As Double = 85.5
Dim isStudent As Boolean = True
```

Then create a button that displays the information.

---

# Important Reminder for Beginners

When learning programming, it is normal to make mistakes.

A missing quotation mark, spelling mistake, or incorrect data type can cause an error. **Do not be afraid of errors.**

Read the error message, look at the line where the problem occurred, and try to understand what went wrong.

The goal of these practicals is to learn by **writing code, making mistakes, fixing them, and trying again.**

---

## What's Next?

Now that we understand variables and data types, we can start making our programs more interactive.

Our next practical can introduce:

* TextBoxes
* Getting information from the user
* Converting input into numbers
* Arithmetic operators
* Calculations
* Displaying results
* Simple student marks calculations

---

## Final Note

This was only the beginning.

We started with very simple concepts because every good programmer needs a strong foundation. As we continue with VB.NET, these basic concepts will be used again and again when building larger applications.

**Learn the concept first, then learn the code.**

Happy coding! 🚀
