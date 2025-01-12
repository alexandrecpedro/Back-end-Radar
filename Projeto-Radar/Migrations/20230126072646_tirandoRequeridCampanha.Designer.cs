﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_Radar.Context;

#nullable disable

namespace ProjetoRadar.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230126072646_tirandoRequeridCampanha")]
    partial class tirandoRequeridCampanha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projeto_Radar.Entitys.Campanha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date")
                        .HasColumnName("data");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nome");

                    b.Property<string>("UrlFotoPrateleira")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url_foto_prateleira");

                    b.HasKey("Id");

                    b.ToTable("tb_campanhas");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_categorias");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("complemento");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<double>("Numero")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("numero");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("tb_clientes");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("complemento");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("INT")
                        .HasColumnName("numero");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("observacao");

                    b.Property<double>("latitude")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("latitude");

                    b.Property<double>("longitude")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("longitude");

                    b.HasKey("Id");

                    b.ToTable("tb_lojas");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id")
                        .HasAnnotation("Relational:JsonPropertyName", "cliente_id");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("DATE")
                        .HasColumnName("data");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("valor_total")
                        .HasAnnotation("Relational:JsonPropertyName", "valor_total");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("tb_pedidos");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.PedidoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("pedido_id")
                        .HasAnnotation("Relational:JsonPropertyName", "pedido_id");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.Property<double>("Valor")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("valor");

                    b.Property<int?>("produtoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("produto_id")
                        .HasAnnotation("Relational:JsonPropertyName", "produto_id");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("produtoId");

                    b.ToTable("tb_pedidoProduto");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.PosicoesProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CampanhaId")
                        .HasColumnType("int")
                        .HasColumnName("campanha_id")
                        .HasAnnotation("Relational:JsonPropertyName", "campanha_id");

                    b.Property<double>("PosicaoX")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("posicao_x");

                    b.Property<double>("PosicaoY")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("posicao_y");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.ToTable("tb_posicoesProdutos");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("categoria_id")
                        .HasAnnotation("Relational:JsonPropertyName", "categoria_id");

                    b.Property<double>("Custo")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("custo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descricao");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("foto_url");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nome");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("INT")
                        .HasColumnName("qtd_estoque")
                        .HasAnnotation("Relational:JsonPropertyName", "qtd_estoque");

                    b.Property<double>("Valor")
                        .HasColumnType("DOUBLE")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("tb_produtos");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nome");

                    b.Property<string>("Permissao")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasColumnName("permissao");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("tb_usuarios");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Pedido", b =>
                {
                    b.HasOne("Projeto_Radar.Entitys.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.PedidoProduto", b =>
                {
                    b.HasOne("Projeto_Radar.Entitys.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projeto_Radar.Entitys.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("produtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.PosicoesProduto", b =>
                {
                    b.HasOne("Projeto_Radar.Entitys.Campanha", "Campanha")
                        .WithMany()
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");
                });

            modelBuilder.Entity("Projeto_Radar.Entitys.Produto", b =>
                {
                    b.HasOne("Projeto_Radar.Entitys.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
