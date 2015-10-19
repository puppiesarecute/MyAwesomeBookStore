namespace MyAwesomeBookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorDatas",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        AuthorDataId = c.Int(nullable: false),
                        name = c.String(),
                        Datum_DatumId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Data", t => t.Datum_DatumId)
                .Index(t => t.Datum_DatumId);
            
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        DatumId = c.Int(nullable: false, identity: true),
                        RootObjectId = c.Int(nullable: false),
                        awards_text = c.String(),
                        dewey_normal = c.String(),
                        marc_enc_level = c.String(),
                        publisher_id = c.String(),
                        summary = c.String(),
                        title_latin = c.String(),
                        title = c.String(),
                        language = c.String(),
                        edition_info = c.String(),
                        isbn13 = c.String(),
                        dewey_decimal = c.String(),
                        title_long = c.String(),
                        lcc_number = c.String(),
                        notes = c.String(),
                        isbn10 = c.String(),
                        book_id = c.String(),
                        physical_description_text = c.String(),
                        publisher_text = c.String(),
                        urls_text = c.String(),
                        publisher_name = c.String(),
                    })
                .PrimaryKey(t => t.DatumId)
                .ForeignKey("dbo.RootObjects", t => t.RootObjectId, cascadeDelete: true)
                .Index(t => t.RootObjectId);
            
            CreateTable(
                "dbo.RootObjects",
                c => new
                    {
                        RootObjectId = c.Int(nullable: false, identity: true),
                        index_searched = c.String(),
                    })
                .PrimaryKey(t => t.RootObjectId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Data", "RootObjectId", "dbo.RootObjects");
            DropForeignKey("dbo.AuthorDatas", "Datum_DatumId", "dbo.Data");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Data", new[] { "RootObjectId" });
            DropIndex("dbo.AuthorDatas", new[] { "Datum_DatumId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RootObjects");
            DropTable("dbo.Data");
            DropTable("dbo.AuthorDatas");
        }
    }
}
