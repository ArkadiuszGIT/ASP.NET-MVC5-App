namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0dbc8481-5109-4b35-a4c8-a2e81bb1e137', N'adminMovies@vidly.com', 0, N'AD3toiJfnhYLvtFecrSP/9qPm7rOeYUuVzP14Thhw2F1FQOAR69SQ2qIICKLUxTFBA==', N'daca9d96-e8ef-4865-bdbf-4222e597884b', NULL, 0, 0, NULL, 1, 0, N'adminMovies@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e8354d6e-fd9d-4c52-a0c3-22795c24aad2', N'guest@vidly.com', 0, N'AI7ZAbiA4buCR5DzMyVxCt5NyV+uolkgC6bgnGsrBWuTU16+hVb/pG8Gd5X8Gtj7Tw==', N'eb3ce464-1bef-4261-bf33-d023459d37fa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cc0fa560-cc24-47c1-9100-219beb1c34f8', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0dbc8481-5109-4b35-a4c8-a2e81bb1e137', N'cc0fa560-cc24-47c1-9100-219beb1c34f8')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
