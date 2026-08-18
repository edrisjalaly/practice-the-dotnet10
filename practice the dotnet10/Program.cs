using Examples;
using practice_the_dotnet10;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hello, World!");

//ConsoleBasics.PrintPrimitiveSizes();
//ConsoleBasics.VariablesDemo();

//Console.WriteLine();
//UserInput.ReadUserAndPassword();


// Expression -> oprand operator operand -> value
//ConsoleBasics.Expression1();

// Expression -> operator oprand   or   oprand operator -> value
//ConsoleBasics.Expression2();

// Expression -> Expression operator Expression -> value
//ConsoleBasics.Expression3();


// ternary operator : check the first expression if it is true then return the second expression else return the third expression
// Expression ? Expression : Expression
//ConsoleBasics.TernaryOperatorDemo();


// if statement
//ConsoleBasics.IfStatement();

//switch statement
//ConsoleBasics.SwitchStatement();


// for statement 
// for(initialization; condition; increment/decrement)
//ConsoleBasics.ForStatement();

// while statement

//ConsoleBasics.WhileStatement();

// do while statement
//ConsoleBasics.DoWhileStatement();


// break statement
// any loop type can be broken using break statement
// any loop (test consition) { if (condition) { break; } }
//ConsoleBasics.BreakStatement();


// continue statement
// any loop type can be continued using continue statement
// any loop (test consition) { if (condition) { continue; } }
//ConsoleBasics.ContinueStatement();

/**
// class declaration
blueprint :: access modifier (class) ClassName { feilds contructor Properties methods }

access modifier: public, private, protected, internal, protected internal, private protected
optional: abstract, sealed, static, partial
class are write as pascal case

// instantiation of class
SomeClass someObject = new SomeClass(); Or SomeClass someObject = new(); c# 9.0 feature

access with . notation
SomeClass someObject = new SomeClass();
someObject.[Feild]
someObject.[Property]
someObject.[Method]


object initializer syntax

SomeClass someObject = new()
{
    [Feild] = value,
    [Property] = value,
};

**/


oop.classDeclaration();