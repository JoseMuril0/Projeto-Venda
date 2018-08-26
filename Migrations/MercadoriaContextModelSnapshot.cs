using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MercadoriasAlura;

namespace MercadoriasAlura.Migrations
{
    [DbContext(typeof(MercadoriaContext))]
    partial class MercadoriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MercadoriasAlura.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MercadoriaId");

                    b.Property<int?>("MercadoriasId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("MercadoriasId");

                    b.ToTable("Compras");
                });

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

            modelBuilder.Entity("MercadoriasAlura.Compra", b =>
                {
                    b.HasOne("MercadoriasAlura.Mercadorias", "Mercadorias")
                        .WithMany()
                        .HasForeignKey("MercadoriasId");
                });
        }
    }
}
