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

//oop.ConstrucorDemo();




// Constructor chaining 
//oop.ConstructorChainingDemo();



// primart contructor
//oop.PrimaryConsrcutorDemo();



// Expression Bodied memebers
// class members such as : methods, poperties, constructor
// using shorter syntax when there is only a single experssion
//oop.ExpressionBodiesMembersDemo();


// Feild back property
// access modifier optional modifier type property name
//oop.FeildBackProprty();


//oop.RequiredDemo();



//oop.SaticModifierDemo();



// readonly us const modfiers overview
// readonly                                                 const modifier
// feild belongs to the object                              feild belongs to the class
// run-time constant assign on declaration on contructor    compilte-time constant assign on declaration
// can only by declared within a class                      can by declared within a class or method
// any data type                                            only primitive or string
// memory allocated at runtime                              no memory allocated at runtime value is embedded within IL code
// optionally static                                        always static




//oop.ReadonlVsConstDemo();



// abstraction : focusing on what it does not how it does it
// Encapsulation : hiding data and behavier, allowing access only through selected public methods
// inheritance : reusing shared data and behavior by creating new class based on existing ones
// (base class, parent class, super class) (child, derive, inherit, extend)

// polymorphism : the process of overriding the parent class method in an object


//  access modifiers overview
//  type (class, interface, struct, Enums)    { public, internal, file}
//  type memebers (feild, Properties, methods)  {public, protected internal, protected, internal, private protected, private}


// public project1  => project2  can access from 1 pro to another
// internal project1  => project2 cant acceess another projects internal class
// file project1  => project2 can access the file class in another project or self project another class


// protected : project1  a class => b class  can access the protected properties in inherited class or sub inherited class
// private : project1  a class => b class  cant access the private properties in another class only can use in self class


//oop.BaseAndDriveDemo();



// upcating : derive class converted to base class
// downcating : base class converted to derive class
//oop.upAndDownCasting();



// virtual modifier : allows methods properties and other class memebers to have
// default behavier while providing the option for what behavier to be override
//oop.virtualModifierDemo();




// abstract modifier
// prevents the class from being instantiated and maked it's members
// act ad placeholder that must be implemented by any non-abstract derived class




// virtual modifier                             abstract modifier
// uesd for method,properties, other members    used for method,properties, other members
// allows for default implementation            does not allow for default implementation
// overriding is optional                       overriding is required in all derived non-abstract classes
// can used with absract and none               can only be used within abstract classes
//oop.abstractModifier();



// method overloadin : defining of multiple methods with the same name but different parameters
// 

//oop.methodOverloading();



// interface : a contract that defines a set of methods and properties that a class must implement
// access modifier interface interfacename { access modifier properties, access modifier methods }
//oop.interfaceDemo();



// os operator : a special method that defines the behavior of an operator when applied to a specific type
// expression is SomeType variabnleName
// 
//oop.isOperatorDemo();




// sealed modifier : prevents a class from being inherited and a method from being overridden
// 


//oop.sealedModifierDemo();

// struct : a value type that can contain data and methods
// structs is short for structure
// someStrature someObject = new someStrature();
// someObject.[Feild]
// someObject.[Property]
// someObject.[Method]

// someObject = new someStrature() { [Feild] = value, [Property] = value, };
// 
//other.structsDemo();



// readonly struct : a struct that can only be initialized once and cannot be modified after that
// other.readonlystructsDemo();
// 
//other.withExpressionDemo();



//

//other.ExplicitParameterlessConstructorDemo();



// auto default constructor : 
//other.autoDefaultStructDemo();


//other.primaryConstructorDemo();



// can use the data types as a struct and can be used as a struct
//other.primativeAsStructDemo();



// enums : a value type that defines a set of named constants

// enum is short for enumeration : just like  struct, enums are value types, enum is a set of named constants, with un underlying intgerling type, (int by default)
// as a rule of thumb enums are ideal when representing a set of related valid options, 
//  seasons : spring, summer, autumn, winter
//  payment methods : cash, credit card, debit card, paypal
//  access modifier enum EnumName { enum member = constant value }
// 
//other.enumsDemo();


// in .net almost everthing is a type organized into categories that determine their bahavier and memory management

// commmon types system  : 
// object base type -> value type  and reference type 
// value type : struct type, enyum type,
// reference type : class type, interface type, delegate type
// value type : struct type -> built-in struct type, user-defined struct type : system.int32, system.double, system.char, system.bool, system.datetime, system.decimal, system.guid, system.timespan
// enum types : built-in enum type, user-defined enum type : system.enum

// reference type : class type -> built-in class type, user-defined class type : system.object, system.string, system.array, system.exception, system.type



// all types are derived from system.object class
// can use object instead of system.object
// system.object has 3 main methods that all types inherit by default
// 1 : ToString() : returns a string representation of the object
// 2 : Equals(object obj) : determines whether the specified object is equal to the current object
// 3 : GetHashCode() : returns a hash code for the current object
// 4 : GetType() : returns the type of the current object

TypeAndBehavier.systemObject();
