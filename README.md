**Notes is an application designed for storing and sharing notes collaboratively. It provides a simple and straightforward way for users to create, view, edit, and search notes. Authentication is not required, allowing anyone to use the application's features.**

## Functional Requirements

+ **Shared Notes:** All users work with a common set of notes.
+ **Note Creation:** Each user can create a note with a title and content.
+ **Note Listing:** Every user can view a list of all notes created by any user.
+ **Note Editing:** Users have the ability to edit any existing note.
+ **Note Searching:** Users can search for notes based on keywords in the title or content.
## Technologies Used

The application is built using the following technologies:
+ **Blazor Server:** The frontend is implemented using Blazor Server, a web framework for building interactive web applications.
+ **Entity Framework Core:** The backend data access is handled by Entity Framework Core, which allows interaction with the database.
+ **PostgreSQL:** PostgreSQL is used as the database management system to store and manage note data.

## Application Structure
+ **NotionService:** The core logic of the application is encapsulated in the NotionService class, which implements the INotionService interface. SOLID principles have been followed in its design.
+ **Database Context:** The application uses Entity Framework Core with PostgreSQL as the database. The database context and models are defined for working with notes.
+ **User Interface:** The user interface is designed with Blazor components, including forms for creating and editing notes, a list view for displaying notes, and a search feature.
## Usage
Users can visit the application without the need for authentication. They can perform the following actions:

+ **Create new notes with titles and content.**
+ **View a list of all notes created by any user.**
+ **Edit existing notes to update their content.**
+ **Search for notes using keywords from the title or content.**
