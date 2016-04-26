namespace EntityFramework_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_NEWCredit_Cards_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NEWCreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NEWCreditCards", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.NEWCreditCards", new[] { "EmployeeId" });
            DropTable("dbo.NEWCreditCards");
        }
    }
}
