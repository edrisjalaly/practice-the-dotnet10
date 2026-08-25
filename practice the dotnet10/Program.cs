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


//oop.classDeclaration();


// feild : access modifier optiional modifier type feildName;
//access modifier: public, private, protected, internal, protected internal, private protected
//optional access modifier: static, readonly, const, required
//feils are write as camel case e.x someFeild
// add _ before the private feilds e.x _someFeild
// 

//oop.FeildsDemo();


// properties : access modifier optiional modifier type property Name
//access modifier: public, private, protected, internal, protected internal
// optional access modifier: virtual, abstract, override, sealed, static, required, new

// access modifier: get  {return feild}
// access modifier: set { feild = value; }
// by default properties are public
// init only setter : set the objest properties only during the object initialization


//oop.PerpertiesDemo();

// methods : parameterized method declaration
// access modifier optional modifier returnType methodName (type parameterName, type parameterName, ...) { method body } : return [value of returnType]
// access modifier: public, private, protected, internal, protected internal


// parameterless method declaration
// access modifier optional modifier returnType methodName () { method body } : return [value of returnType]
// access modifier: public, private, protected, internal, protected internal

// void method declaration
// access modifier optional modifier void methodName () { method body }
// iass (infrastructure as a service)
// paas (platform as a service)
// saas (software as a service)
// 


//oop.MethodsDemo("my config");

// constructor : access modifier optional modifier ClassName (constructor Name) { constructor body }
// constructor overloading : multiple constructors with different parameters
// constructor1() constructor2(type parameterName) constructor3(type parameterName, type parameterName) { constructor body }
// constructor overloading :: 1:(number of paramethers) 2:(type of paramethers) 3:(order of parmethers)

// diffrenet of constructor vs object initializer 
// 1 : contructor call first and initializer after that
// 2 : intializer not enforce the setting values by default
// 3 : can overload contrcutor cant overload initializer
// 4 : can incluse extra logic within contructor

oop.ConstrucorDemo();