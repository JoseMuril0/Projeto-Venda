using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MercadoriasAlura;

namespace MercadoriasAlura.Migrations
{
    [DbContext(typeof(MercadoriaContext))]
    [Migration("20180826144757_Incial")]
    partial class Incial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MercadoriasAlura.Mercadorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoBarra");

                    b.Property<string>("Descricao");

                    b.Property<double>("Preco");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.ToTable("Mercadoria");
                });
        }
    }
}
