using FluentMigrator;

namespace Core.NHibernate.DbMigrations.V20150101
{
    [Migration(20150101)]
    public class _01_CreateTaskTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Tasks")
                .WithColumn("TaskId");
        }
    }
}