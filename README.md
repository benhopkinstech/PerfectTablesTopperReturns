# Perfect Tables Topper Returns

C# Windows Forms app linked with a SQL database.

Made for Perfect Tables Ltd to help with checking if an unused returned card cake topper is available to fulfil an order.

Database not included in the project files, table definition is as follows;
CREATE TABLE [dbo].[Returns] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Size]   VARCHAR (50) NOT NULL,
    [Design] VARCHAR (50) NOT NULL,
    [Colour] VARCHAR (50) NOT NULL,
    [Number] INT          NOT NULL
);

Database file path needs to be set in the App.config file.
