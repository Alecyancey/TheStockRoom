namespace TheStockRoom.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedShelfRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Collection",
                c => new
                    {
                        CollectionId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CollectionId);
            
            CreateTable(
                "dbo.CollectionItem",
                c => new
                    {
                        CollectionItemId = c.Int(nullable: false, identity: true),
                        CollectionId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CollectionItemId)
                .ForeignKey("dbo.Collection", t => t.CollectionId, cascadeDelete: true)
                .ForeignKey("dbo.Item", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.CollectionId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        PrimaryCharacteristic = c.String(),
                        SecondaryCharacteristic = c.String(),
                        Size = c.Double(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        ItemLocationId = c.Int(nullable: false),
                        Shelf_ShelfId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Shelf", t => t.Shelf_ShelfId)
                .ForeignKey("dbo.ItemLocation", t => t.ItemLocationId, cascadeDelete: true)
                .Index(t => t.ItemLocationId)
                .Index(t => t.Shelf_ShelfId);
            
            CreateTable(
                "dbo.ItemLocation",
                c => new
                    {
                        ItemLocationId = c.Int(nullable: false, identity: true),
                        RowNumber = c.Int(nullable: false),
                        ColumnNumber = c.Int(nullable: false),
                        ShelfId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemLocationId)
                .ForeignKey("dbo.Shelf", t => t.ShelfId, cascadeDelete: true)
                .Index(t => t.ShelfId);
            
            CreateTable(
                "dbo.Shelf",
                c => new
                    {
                        ShelfId = c.Int(nullable: false, identity: true),
                        AdjustHeight = c.Double(nullable: false),
                        AdjustWidth = c.Double(nullable: false),
                        AdjustColumnNumber = c.Int(nullable: false),
                        AdjustRowNumber = c.Int(nullable: false),
                        ShelvingUnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShelfId)
                .ForeignKey("dbo.ShelvingUnit", t => t.ShelvingUnitId, cascadeDelete: true)
                .Index(t => t.ShelvingUnitId);
            
            CreateTable(
                "dbo.ShelvingUnit",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                        NumberOfShelves = c.Int(nullable: false),
                        DefaultRowsPerShelf = c.Int(nullable: false),
                        DefaultColumnsPerShelf = c.Int(nullable: false),
                        DefaultShelfHeight = c.Double(nullable: false),
                        DefaultShelfWidth = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UnitId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.CollectionItem", "ItemId", "dbo.Item");
            DropForeignKey("dbo.Item", "ItemLocationId", "dbo.ItemLocation");
            DropForeignKey("dbo.ItemLocation", "ShelfId", "dbo.Shelf");
            DropForeignKey("dbo.Shelf", "ShelvingUnitId", "dbo.ShelvingUnit");
            DropForeignKey("dbo.Item", "Shelf_ShelfId", "dbo.Shelf");
            DropForeignKey("dbo.CollectionItem", "CollectionId", "dbo.Collection");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Shelf", new[] { "ShelvingUnitId" });
            DropIndex("dbo.ItemLocation", new[] { "ShelfId" });
            DropIndex("dbo.Item", new[] { "Shelf_ShelfId" });
            DropIndex("dbo.Item", new[] { "ItemLocationId" });
            DropIndex("dbo.CollectionItem", new[] { "ItemId" });
            DropIndex("dbo.CollectionItem", new[] { "CollectionId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.ShelvingUnit");
            DropTable("dbo.Shelf");
            DropTable("dbo.ItemLocation");
            DropTable("dbo.Item");
            DropTable("dbo.CollectionItem");
            DropTable("dbo.Collection");
        }
    }
}
