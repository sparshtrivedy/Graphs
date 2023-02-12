##How to run the application?
- Start by cd-ing into the API folder of the project
- Run `dotnet watch run` command in the terminal which will create and seed the SQLite lumber database using EF migrations
- The seeded table can be seen by installing the SQLite VS code extension
- The .NET version I am using is 6.0 and Entity Framework version is 7.0.2
- Head to http://localhost:5000/index.html to see the swagger documentation for the lumber API. This is where we are running our server side.
- Then cd into ../client to run the client side of the application.
- `npm intall` all the dependencies
- `npm start` to run the client side in the browser and see the application in action!

##Project description?
- The type dropdown can be used to select the kind of data we want to display
- We can use the date selectors to select the boundaries we want to display the data for.
- The `i` icon, on clicking, we open up a dialogue with information about the application.
