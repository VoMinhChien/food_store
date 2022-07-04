IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [CategoryModels] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategorName] nvarchar(250) NOT NULL,
        CONSTRAINT [PK_CategoryModels] PRIMARY KEY ([CategoryId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [PaymentType] (
        [PaymentTypeId] int NOT NULL IDENTITY,
        [PaymentTypeName] nvarchar(150) NOT NULL,
        CONSTRAINT [PK_PaymentType] PRIMARY KEY ([PaymentTypeId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [Roles] (
        [RoleID] int NOT NULL IDENTITY,
        [RoleName] nvarchar(250) NOT NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([RoleID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [Foods] (
        [FoodID] int NOT NULL IDENTITY,
        [FoodName] nvarchar(250) NOT NULL,
        [FoodCategory] int NOT NULL,
        [FoodPrice] float NOT NULL,
        [FoodImage] nvarchar(max) NOT NULL,
        [FoodType] nvarchar(250) NOT NULL,
        [CreatDate] DateTime NOT NULL,
        [ModifyDate] nvarchar(250) NULL,
        [ModifyBy] nvarchar(250) NULL,
        [VAT] float NOT NULL,
        [IsDelete] bit NOT NULL,
        CONSTRAINT [PK_Foods] PRIMARY KEY ([FoodID]),
        CONSTRAINT [FK_Foods_CategoryModels_FoodCategory] FOREIGN KEY ([FoodCategory]) REFERENCES [CategoryModels] ([CategoryId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [Users] (
        [UserId] int NOT NULL IDENTITY,
        [UserFullName] nvarchar(250) NOT NULL,
        [UserEmail] nvarchar(250) NOT NULL,
        [UserPassWord] nvarchar(250) NOT NULL,
        [UserGender] nvarchar(100) NOT NULL,
        [UserBirtday] DateTime NOT NULL,
        [UserPhone] varchar(15) NOT NULL,
        [UserAddress] nvarchar(250) NOT NULL,
        [RoleID] int NOT NULL,
        [UserToken] nvarchar(250) NULL,
        [UserTokenGG] nvarchar(250) NULL,
        [IsDelete] bit NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserId]),
        CONSTRAINT [FK_Users_Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [Roles] ([RoleID]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [Carts] (
        [CardId] int NOT NULL IDENTITY,
        [UserId] int NOT NULL,
        [UserFullName] nvarchar(250) NULL,
        [UserEmail] varchar(250) NULL,
        [UserPhone] varchar(15) NULL,
        [UseAddress] nvarchar(250) NULL,
        [TotalPrice] float NOT NULL,
        [CardTocal] float NOT NULL,
        [VAT] float NOT NULL,
        [PaymentDate] datetime2 NOT NULL,
        [PaymentTypeId] int NOT NULL,
        [IsDelete] bit NOT NULL,
        CONSTRAINT [PK_Carts] PRIMARY KEY ([CardId]),
        CONSTRAINT [FK_Carts_PaymentType_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentType] ([PaymentTypeId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Carts_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE TABLE [CartDetails] (
        [CartdetailId] int NOT NULL IDENTITY,
        [CartID] int NOT NULL,
        [FoodId] int NOT NULL,
        [FoodName] nvarchar(max) NOT NULL,
        [FoodMount] nvarchar(max) NOT NULL,
        [FoodImage] nvarchar(max) NOT NULL,
        [FoodType] nvarchar(max) NULL,
        [VAT] nvarchar(max) NULL,
        [IsDelete] nvarchar(max) NULL,
        CONSTRAINT [PK_CartDetails] PRIMARY KEY ([CartdetailId]),
        CONSTRAINT [FK_CartDetails_Carts_CartID] FOREIGN KEY ([CartID]) REFERENCES [Carts] ([CardId]) ON DELETE CASCADE,
        CONSTRAINT [FK_CartDetails_Foods_FoodId] FOREIGN KEY ([FoodId]) REFERENCES [Foods] ([FoodID]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_CartDetails_CartID] ON [CartDetails] ([CartID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_CartDetails_FoodId] ON [CartDetails] ([FoodId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_Carts_PaymentTypeId] ON [Carts] ([PaymentTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_Carts_UserId] ON [Carts] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_Foods_FoodCategory] ON [Foods] ([FoodCategory]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    CREATE INDEX [IX_Users_RoleID] ON [Users] ([RoleID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220616050821_asmc5')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220616050821_asmc5', N'5.0.17');
END;
GO

COMMIT;
GO

