﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pucfarma.api.Data;

#nullable disable

namespace pucfarma.api.Migrations
{
    [DbContext(typeof(PucFarmaDbContext))]
    [Migration("20240525000148_M005")]
    partial class M005
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pucfarma.api.Models.AvaliacaoModel", b =>
                {
                    b.Property<int>("avaliacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("avaliacaoId"));

                    b.Property<string>("comentario")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("dataAvaliacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("nota")
                        .HasColumnType("integer");

                    b.Property<int>("produtoId")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioId")
                        .HasColumnType("integer");

                    b.HasKey("avaliacaoId");

                    b.HasIndex("produtoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("pucfarma.api.Models.FarmaciaModel", b =>
                {
                    b.Property<string>("nomeFarmacia")
                        .HasColumnType("text");

                    b.Property<string>("horarioFuncionamento")
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .HasColumnType("text");

                    b.HasKey("nomeFarmacia");

                    b.ToTable("Farmacia");
                });

            modelBuilder.Entity("pucfarma.api.Models.PedidoModel", b =>
                {
                    b.Property<int>("pedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("pedidoId"));

                    b.Property<DateTime?>("dataPedido")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("metodoPagamento")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("previsaoEntrega")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("status")
                        .HasColumnType("integer");

                    b.Property<int>("usuarioId")
                        .HasColumnType("integer");

                    b.HasKey("pedidoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("pucfarma.api.Models.PedidoProdutoModel", b =>
                {
                    b.Property<int>("pedidoId")
                        .HasColumnType("integer");

                    b.Property<int>("produtoId")
                        .HasColumnType("integer");

                    b.Property<int>("pedidoProdutoId")
                        .HasColumnType("integer");

                    b.Property<int>("quantidade")
                        .HasColumnType("integer");

                    b.HasKey("pedidoId", "produtoId");

                    b.HasIndex("produtoId");

                    b.ToTable("Pedido_Produto");
                });

            modelBuilder.Entity("pucfarma.api.Models.ProdutoModel", b =>
                {
                    b.Property<int>("produtoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("produtoId"));

                    b.Property<int?>("categoria")
                        .HasColumnType("integer");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<int?>("estoqueDisponivel")
                        .HasColumnType("integer");

                    b.Property<string>("fabricante")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("fotoProduto")
                        .HasColumnType("text");

                    b.Property<string>("nomeFarmacia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nomeProduto")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("porcentagemDesconto")
                        .HasColumnType("integer");

                    b.Property<decimal>("preco")
                        .HasColumnType("numeric");

                    b.HasKey("produtoId");

                    b.HasIndex("nomeFarmacia");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("pucfarma.api.Models.UsuarioModel", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("usuarioId"));

                    b.Property<string>("bairro")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("cep")
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("complemento")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("estado")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("nomeCompleto")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("numero")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("rua")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("telefone")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("tipoUsuario")
                        .HasColumnType("integer");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("pucfarma.api.Models.AvaliacaoModel", b =>
                {
                    b.HasOne("pucfarma.api.Models.ProdutoModel", "produto")
                        .WithMany("produtoAvaliacao")
                        .HasForeignKey("produtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pucfarma.api.Models.UsuarioModel", "usuario")
                        .WithMany("usuarioAvaliacao")
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("produto");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("pucfarma.api.Models.FarmaciaModel", b =>
                {
                    b.OwnsOne("pucfarma.api.Models.Endereco", "enderecoFarmacia", b1 =>
                        {
                            b1.Property<string>("FarmaciaModelnomeFarmacia")
                                .HasColumnType("text");

                            b1.Property<string>("bairro")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("character varying(30)");

                            b1.Property<string>("cep")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("cidade")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("character varying(30)");

                            b1.Property<string>("complemento")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)");

                            b1.Property<string>("estado")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)");

                            b1.Property<string>("numero")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("character varying(10)");

                            b1.Property<string>("rua")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("character varying(30)");

                            b1.HasKey("FarmaciaModelnomeFarmacia");

                            b1.ToTable("Farmacia");

                            b1.WithOwner()
                                .HasForeignKey("FarmaciaModelnomeFarmacia");
                        });

                    b.Navigation("enderecoFarmacia");
                });

            modelBuilder.Entity("pucfarma.api.Models.PedidoModel", b =>
                {
                    b.HasOne("pucfarma.api.Models.UsuarioModel", "usuario")
                        .WithMany("usuarioPedido")
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("pucfarma.api.Models.PedidoProdutoModel", b =>
                {
                    b.HasOne("pucfarma.api.Models.PedidoModel", "pedido")
                        .WithMany("pedidoProduto")
                        .HasForeignKey("pedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pucfarma.api.Models.ProdutoModel", "produto")
                        .WithMany("produtoPedido")
                        .HasForeignKey("produtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pedido");

                    b.Navigation("produto");
                });

            modelBuilder.Entity("pucfarma.api.Models.ProdutoModel", b =>
                {
                    b.HasOne("pucfarma.api.Models.FarmaciaModel", "farmacia")
                        .WithMany("farmaciaProduto")
                        .HasForeignKey("nomeFarmacia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("farmacia");
                });

            modelBuilder.Entity("pucfarma.api.Models.FarmaciaModel", b =>
                {
                    b.Navigation("farmaciaProduto");
                });

            modelBuilder.Entity("pucfarma.api.Models.PedidoModel", b =>
                {
                    b.Navigation("pedidoProduto");
                });

            modelBuilder.Entity("pucfarma.api.Models.ProdutoModel", b =>
                {
                    b.Navigation("produtoAvaliacao");

                    b.Navigation("produtoPedido");
                });

            modelBuilder.Entity("pucfarma.api.Models.UsuarioModel", b =>
                {
                    b.Navigation("usuarioAvaliacao");

                    b.Navigation("usuarioPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
