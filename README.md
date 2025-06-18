# WinTerpreters

### A desktop application to create invoices from well defined job confirmations.

## About the Project

With this project, I aim to transfer my knowledge of Java and web development to C# and the .NET ecosystem.
It implements business logic I have developed and implemented before in other
environments, so I can focus on learning the C# language and the .NET framework
as well as Visual Studio. 

## About the Application

This application is designed for freelance interpreters in job pools who 
receive job confirmations via email. It allows them to create invoices
from these confirmations, which can then be sent to the clients.

### Intended Workflow

The workflow is as follows:
	- user receives job confirmation via email
	- user opens the application and imports the job confirmation
	- the application extracts the relevant data from the job confirmation
	- the user can edit the extracted data
	- the user can create an invoice from the edited data

### Build and Run

Prerequisites: - .NET 8 installed on your machine

To build and run the application, just clone this repository and type "dotnet run" from the WinTerpDesktop directory.

`PS> git clone  https://github.com/julien-zigan/winterpreters.git`

`PS> cd .\winterpreters\`

`PS> cd .\WinTerpDesktop\`

`PS> dotnet run` 

You can test the current version by dragging a pdf file into the application window 
or by choosing a pdf file by clicking the button.



