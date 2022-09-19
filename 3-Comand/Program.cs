using _3_Comand.Implementations;
using _3_Comand.Models;

// Receiver
TV someTV = new TV();

// Command
TVCommand command = new TVCommand(someTV);

// Invoker
RemoteController remote = new RemoteController();
remote.SetCommand(command);
remote.PressButton();
remote.PressUndo();

Console.ReadLine();