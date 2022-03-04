# Order Tracker

#### [Riley Shimp](https://www.github.com/rileyshimp)

## Technologies Used

* C#
* .NET
* CSS
* Razor View Engine
* VSCode

## Description

This is an MVC web application built with C# to help a business keep tack of the vendors that purchase goods and the orders belonging to those vendors. Users are able to click a Vendor's name and go to a new page that will display all of that Vendor's orders. Users are also provided with a link to a page presenting them with a form to create a new Order for a particular Vendor.

## Setup/Installation Requirements

### Step 1
Clone the repository:
``` 
$ git clone https://github.com/RileyShimp/ordertracker.git 
```
### Step 2
First we'll install .NET, which provides access to the C# language. Follow along with instructions for your operating system provided in the following link: 
https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net

### Step 3
Now .NET and C# should be installed and your computer should recognize the `dotnet` command.
Navigate to the `OrderTracker.Solution` directory in your computer terminal and then to the `OrderTracker` folder.

### Step 4
Once in the `OrderTracker` folder, run the command `dotnet run`

### Steps for testing
After completing steps 1 and 2, you can run tests in your terminal.

To do this, navigate to the `OrderTracker.Tests` folder and run the command `dotnet restore`
This command automatically creates new `obj` directories in `OrderTracker` and `OrderTracker.Tests`

Finally, we will run `dotnet test` and the tests will run.

Specific tests are written and can be found in the `ModelTests` folder.

## Known Bugs

* none

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 02/25/2022 Riley Shimp