using FluentMigrator;
using Nop.Data.Migrations;

namespace Nop.Plugin.BS23.ShowSomethingBeforeNews.Migrations
{
    [NopMigration("2022/03/15 14:45:00:2551770", "Nop.Plugin.BS23.ShowSomethingBeforeNews schema", MigrationProcessType.Installation)]
    public class SchemaMigration : AutoReversingMigration
    {
        private readonly IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        /// <summary>
        /// Collect the UP migration expressions
        /// </summary>
        public override void Up()
        {
        }
    }
}
