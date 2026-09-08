using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace practice_the_dotnet10
{
    internal static class nullSafty
    {

        class Book
        {
            public required string Title {  get; set; }
            public required string Author {  get; set; } 
            public double? AvrageRat {  get; set; }
        }
        public static void nullDeclaration()
        {
            //old
            Nullable<bool> isValid = null;
            if (isValid.HasValue)
            {
                Console.WriteLine($"old number has value {isValid}");
            }

            //new way
            bool? isValidNumber = null;

            if (isValidNumber is not null)
            {
                Console.WriteLine($" is valid number has value {isValidNumber}");
            }

                         
            void printBookInfo(Book book)
            {
                Console.WriteLine($"this is my book : {book.AvrageRat}");
            }
            Book book = new Book()
            {
                Title = "New",
                Author = "me"
            };

            printBookInfo(book);

            Book book1 = new()
            {
                Title = "new book1",
                Author = "jamil",
                AvrageRat = 3,
            };

            printBookInfo(book1);
        }





        class Address(string addressLine, string city, string state)
        {
            public string AddressLine { get; set; } = addressLine;
            public string City { get; set; } = city;
            public string State { get; set; } = state;
        }        
        class Person(string name, string lastNem, Address? address = null)
        {
            public string Name { get; set; }
            public string lastName { get; set; }
            public Address? Address { get; set; }
        }
        public static void nullReferenceType()
        {
            Address address = new("new kabul", "shar-now", "markaz");

            Person person = new("khan", "jan", address);
            Person person1 = new("jano", "khano");


            void personCity(Person person)
            {


                Console.WriteLine($"this is the person Address {person.Address.City}");
            }

            personCity(person);

        }




        class ReportOptions
        {
            public ExportOptions Export { get; set; }
        }
        class ExportOptions
        {
            public ExportFormat format { get; set; } = ExportFormat.excel;
        }
        public enum ExportFormat
        {
            excel,
            word
        }
        public static void nullCoalesing()
        {
            ReportOptions  reportOptions = new ReportOptions();
            ExportOptions? exportOptions = new ExportOptions();
            ExportOptions  FallbackexportOptions = new ExportOptions() {  format = ExportFormat.word };


            // old way 
            if (exportOptions is not null)
            {
                reportOptions.Export = exportOptions;
            }
            else
            {
                reportOptions.Export = FallbackexportOptions;
            }


            //old way 2
            reportOptions.Export = exportOptions is not null ? exportOptions : FallbackexportOptions;


            //new way
            reportOptions.Export = exportOptions ?? FallbackexportOptions;
        }





        public static void nullCoaslesingAssignmentDemo()
        {
            ReportOptions options = new() { Export = new() };
            ExportOptions fallback = new() { format = ExportFormat.excel };

            //old way
            if(options is null)
            {
                options.Export = fallback;
            }

            // new way
            options.Export ??= fallback;
        }





        public static void nullConditionalOperator()
        {
            ReportOptions options = new() { Export= new() };

            if (options.Export?.format == ExportFormat.word)
            {
                Console.WriteLine(options.Export.format);
            }
        }
    }
}
