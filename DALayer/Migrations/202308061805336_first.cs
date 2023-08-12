namespace DALayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPlans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CreDate = c.DateTime(nullable: false),
                        CreUser = c.Int(nullable: false),
                        DelDate = c.DateTime(),
                        DelUser = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        customerId_id = c.Int(),
                        planId_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.customerId_id)
                .ForeignKey("dbo.Plans", t => t.planId_id)
                .Index(t => t.customerId_id)
                .Index(t => t.planId_id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        SurName = c.String(nullable: false, maxLength: 25),
                        BirthDate = c.DateTime(nullable: false),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeOfMembership = c.Int(nullable: false),
                        CreDate = c.DateTime(nullable: false),
                        CreUser = c.Int(nullable: false),
                        DelDate = c.DateTime(),
                        DelUser = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        CreDate = c.DateTime(nullable: false),
                        CreUser = c.Int(nullable: false),
                        DelDate = c.DateTime(),
                        DelUser = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Departmans",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        CreDate = c.DateTime(nullable: false),
                        CreUser = c.Int(nullable: false),
                        DelDate = c.DateTime(),
                        DelUser = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        SurName = c.String(nullable: false, maxLength: 25),
                        DepartmentId = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 25),
                        CreDate = c.DateTime(nullable: false),
                        CreUser = c.Int(nullable: false),
                        DelDate = c.DateTime(),
                        DelUser = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departmans", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "DepartmentId", "dbo.Departmans");
            DropForeignKey("dbo.CustomerPlans", "planId_id", "dbo.Plans");
            DropForeignKey("dbo.CustomerPlans", "customerId_id", "dbo.Customers");
            DropIndex("dbo.Users", new[] { "DepartmentId" });
            DropIndex("dbo.CustomerPlans", new[] { "planId_id" });
            DropIndex("dbo.CustomerPlans", new[] { "customerId_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Departmans");
            DropTable("dbo.Plans");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerPlans");
        }
    }
}
