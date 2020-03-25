using DecoratorPattern.Abstract;
using DecoratorPattern.Entities;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The problem:
            // Some operations on a file are needed before reading from and writing to the file.
            // Without the decorator pattern, a new subclass of FileDataStore would be needed for each
            // new operation. This causes a problem when a combination of two or more operations are needed.

            // The solution:
            // Creating wrappers around FileDataStore that implements the same interface as FileDataStore itself.
            // This way, the wrappers can call the methods of FileDataStore after adding their additional
            // functionalities in those same methods.

            IDataStore dataStore = new FileDataStore("file1");
            dataStore = new FileCompressionDecorator(dataStore);
            dataStore = new FileEncryptionDecorator(dataStore);

            // In some other part of the code, a client is using the dataStore to read and write data
            // without caring about the underlying operations that take place before reading and writing.
            // This way, we can add a new decorator that extends those operations without changing the
            // client code.

            dataStore.WriteData("data");
            dataStore.ReadData();

            // Consequences:
            // Ordering the wrappers is important.
            // Removing a wrapper from the wrappers stack is difficult.
        }
    }
}
