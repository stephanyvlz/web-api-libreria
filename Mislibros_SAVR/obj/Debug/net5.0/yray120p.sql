BEGIN TRANSACTION;
GO

ALTER TABLE [Books] DROP CONSTRAINT [FK_Books_Publisher_PublisherId];
GO

ALTER TABLE [Publisher] DROP CONSTRAINT [PK_Publisher];
GO

EXEC sp_rename N'[Publisher]', N'Publishers';
GO

ALTER TABLE [Publishers] ADD CONSTRAINT [PK_Publishers] PRIMARY KEY ([Id]);
GO

CREATE TABLE [Authors] (
    [Id] int NOT NULL IDENTITY,
    [FullName] nvarchar(max) NULL,
    CONSTRAINT [PK_Authors] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Book_Authors] (
    [Id] int NOT NULL IDENTITY,
    [BookId] int NOT NULL,
    [AuthorId] int NOT NULL,
    CONSTRAINT [PK_Book_Authors] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Book_Authors_Authors_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Authors] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Book_Authors_Books_BookId] FOREIGN KEY ([BookId]) REFERENCES [Books] ([id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Book_Authors_AuthorId] ON [Book_Authors] ([AuthorId]);
GO

CREATE INDEX [IX_Book_Authors_BookId] ON [Book_Authors] ([BookId]);
GO

ALTER TABLE [Books] ADD CONSTRAINT [FK_Books_Publishers_PublisherId] FOREIGN KEY ([PublisherId]) REFERENCES [Publishers] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241113145558_ManyToManyAdded', N'5.0.17');
GO

COMMIT;
GO

