using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Soda.EntityFrameworkCore.Services;

public class SodaMigrationsSqlGenerator : MigrationsSqlGenerator
{
    public SodaMigrationsSqlGenerator(MigrationsSqlGeneratorDependencies dependencies) : base(dependencies)
    {
    }

    protected override void Generate(CreateIndexOperation operation, IModel? model, MigrationCommandListBuilder builder,
        bool terminate = true)
    {
        base.Generate(operation, model, builder, terminate);
    }
}