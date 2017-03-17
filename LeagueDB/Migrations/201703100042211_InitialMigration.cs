namespace LeagueDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Build",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item1 = c.String(),
                        Item2 = c.String(),
                        Item3 = c.String(),
                        Item4 = c.String(),
                        Item5 = c.String(),
                        Item6 = c.String(),
                        SumSpell1 = c.String(),
                        SumSpell2 = c.String(),
                        Champion_ID = c.String(maxLength: 128),
                        Item_ID = c.String(maxLength: 128),
                        User_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Champion", t => t.Champion_ID)
                .ForeignKey("dbo.Item", t => t.Item_ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.Champion_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Champion",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Q = c.String(),
                        W = c.String(),
                        E = c.String(),
                        R = c.String(),
                        Passive = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Gold = c.Int(nullable: false),
                        Stats = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Build", "User_ID", "dbo.User");
            DropForeignKey("dbo.Build", "Item_ID", "dbo.Item");
            DropForeignKey("dbo.Build", "Champion_ID", "dbo.Champion");
            DropIndex("dbo.Build", new[] { "User_ID" });
            DropIndex("dbo.Build", new[] { "Item_ID" });
            DropIndex("dbo.Build", new[] { "Champion_ID" });
            DropTable("dbo.User");
            DropTable("dbo.Item");
            DropTable("dbo.Champion");
            DropTable("dbo.Build");
        }
    }
}
