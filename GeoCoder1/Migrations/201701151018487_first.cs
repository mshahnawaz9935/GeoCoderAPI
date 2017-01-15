namespace GeoCoder1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Townlands",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        X = c.String(),
                        Y = c.String(),
                        OBJECTID = c.String(),
                        County = c.String(),
                        Contae = c.String(),
                        Local_Government_Area = c.String(),
                        Classification = c.String(),
                        English_name = c.String(),
                        IG_E = c.String(),
                        IG_N = c.String(),
                        ITM_E = c.String(),
                        ITM_N = c.String(),
                        Validated_By = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Townlands");
        }
    }
}
