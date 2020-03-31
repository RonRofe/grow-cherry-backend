CREATE TABLE [dbo].[Users] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Email]       VARCHAR (255) NOT NULL,
    [PhoneNumber] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

