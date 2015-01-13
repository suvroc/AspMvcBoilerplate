using FluentMigrator.VersionTableInfo;

namespace Core.NHibernate.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "VersionInfo";
            }
        }
    }
}