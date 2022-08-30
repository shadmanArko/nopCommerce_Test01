using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.BS23.ShowTableOfAllCustomersBeforeNews.Domains;

namespace Nop.Plugin.BS23.ShowTableOfAllCustomersBeforeNews.Mapping.Builders
{
    public class PluginBuilder : NopEntityBuilder<CustomTable>
    {
        #region Methods

        public override void MapEntity(CreateTableExpressionBuilder table)
        {
        }

        #endregion
    }
}