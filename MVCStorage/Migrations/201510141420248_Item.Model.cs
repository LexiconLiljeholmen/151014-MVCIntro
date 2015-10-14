namespace MVCStorage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Model", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Model");
        }
    }
}
