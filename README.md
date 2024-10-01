Astronaut Daily Schedule Organizer<br/><br/>
This project is a console-based application designed to help astronauts organize their daily tasks efficiently.
The schedule allows users to add, view, and remove tasks with real-time conflict detection based on task timing. <br/><br/>
Prerequisites:<br/>
.NET SDK (version 6.0 installed)<br/><br/>
1: Getting started:
Clone the repository:
```
git clone https://github.com/purple-black/Ei.Study-Coding-Exercise.git
cd AstronautConsoleApp
```
<br/>
2: Build and Run the project:
Go to View and click on Terminal to open the terminal. Type in the following commands to build and run the project.<br/>
Run the following dotnet command:<br/>
dotnet build
<br/>
dotnet run<br/>

<br/>
3: Usage<br/>
Once running, the application will prompt for the following commands:<br/>

Add: To add a new task by providing task description, start time, end time, and priority.<br/>
View: Display all scheduled tasks for the day.<br/>
Remove: Remove a task by its description.<br/>
Exit: Close the application<br/>

4: Code Structure<br/>
Program.cs: The main entry point and it handles user input and commands.<br/>
ScheduleManager.cs: Manages tasks, observers, and validates time conflicts.<br/>
Task.cs: The task representation with description, start/end time, and priority.<br/>
TaskFactory.cs: For creating new tasks.<br/>
ConsoleObserver.cs: For receiving notifications on task changes.<br/>

<br/>
<br/>

Coding exercise on Design Patterns: <br/><br/>
Creational Design Patterns: <br/><br/>
Abstract Factory: <br/>
UI Elements for Windows and MacOS - buttons and checkboxes <br/><br/>
Singleton:<br/>
Singleton databse pooling: In a large-scale application, multiple parts of the system will need to access a database concurrently.
Having a new connection each time can be resource-intensive and is inefficient.
A Singleton Database Connection Pool can manage a limited number of database connections,
reusing them to optimize performance and resource management. <br/><br/>
Structural Design Patterns: <br/><br/>
Adapter: <br/>
There are PayPal payment processor and anew processor called stripe. 
The interface provided by Stripe is different from that of PayPal. Adapter Pattern is used to create a class
that adapts the Stripe interface to the existing PayPal system. <br/><br/>
Bridge: <br/>
a scenario where we have different types of remote controls (e.g., BasicRemote and AdvancedRemote)
and different types of devices (e.g., TV, Radio).
Using the Bridge pattern, we can create a flexible system where any remote can control any device.<br/><br/>
Behavioural Design Pattern: <br/><br/>
Iterator: <br/>
A scenario where we have a collection of books. Each book has a title and an author,
and we want to traverse this collection in a specific order (like alphabetically by title).
The goal is to create a custom iterator for our BookCollection so that we can traverse it without
exposing its internal structure directly.<br/><br/>
Template Method:<br/>
A document generation system, consider two types of documents
(e.g.,PDF Document and Word Document) that follow a general structure for creation but differ
in the specific implementation of saving the file or setting up the layout.
The Template Method Pattern can be used to define the overall process of document creation,
while allowing subclasses to customize particular steps.<br/><br/>

