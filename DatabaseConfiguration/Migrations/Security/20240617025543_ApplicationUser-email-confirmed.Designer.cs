﻿// <auto-generated />
using System;
using ImproveU_backend.DatabaseConfiguration.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ImproveU_backend.DatabaseConfiguration.Migrations.Security
{
    [DbContext(typeof(SecurityContext))]
    [Migration("20240617025543_ApplicationUser-email-confirmed")]
    partial class ApplicationUseremailconfirmed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ImproveU_backend.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int?>("TreinoId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ImproveU_backend.Models.EdFisico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("RegistroConselho")
                        .HasColumnType("text");

                    b.Property<int?>("TreinoId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("EdFisico");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Exercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Exercicio");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Direcao")
                        .HasColumnType("integer");

                    b.Property<int>("EdFisicoId")
                        .HasColumnType("integer");

                    b.Property<int?>("ItemTreinoId")
                        .HasColumnType("integer");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("EdFisicoId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Extensão")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("ImproveU_backend.Models.ItemTreinoARealizar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CargaEmKg")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExercicioId")
                        .HasColumnType("integer");

                    b.Property<int?>("IntervaloDescanso")
                        .HasColumnType("integer");

                    b.Property<int?>("Repeticoes")
                        .HasColumnType("integer");

                    b.Property<int?>("Series")
                        .HasColumnType("integer");

                    b.Property<int>("TreinoId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("TreinoId");

                    b.ToTable("ItemTreinoARealizar");
                });

            modelBuilder.Entity("ImproveU_backend.Models.ItemTreinoRealizados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CargaEmKg")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExercicioId")
                        .HasColumnType("integer");

                    b.Property<int?>("FeedbackId")
                        .HasColumnType("integer");

                    b.Property<int?>("IntervaloDescanso")
                        .HasColumnType("integer");

                    b.Property<int?>("Repeticoes")
                        .HasColumnType("integer");

                    b.Property<int?>("Series")
                        .HasColumnType("integer");

                    b.Property<int>("TreinoId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ExercicioId");

                    b.HasIndex("FeedbackId")
                        .IsUnique();

                    b.HasIndex("TreinoId");

                    b.ToTable("ItemTreinoRealizados");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("data_criacao")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("identity_user_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("ultima_atualizacao");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId")
                        .IsUnique();

                    b.ToTable("pessoas", (string)null);
                });

            modelBuilder.Entity("ImproveU_backend.Models.Treino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCriacao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("DataFimVigencia")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DataInicioVigencia")
                        .HasColumnType("date");

                    b.Property<int>("EdFisicoId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UltimaAlteracao")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("EdFisicoId");

                    b.ToTable("Treino");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("ApplicationRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("ApplicationUserTokens", (string)null);
                });

            modelBuilder.Entity("ImproveU_backend.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Ativo")
                        .HasColumnType("integer");

                    b.Property<int>("Papel")
                        .HasColumnType("integer");

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("ImproveU_backend.Models.Aluno", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Pessoa", "Pessoa")
                        .WithOne("Aluno")
                        .HasForeignKey("ImproveU_backend.Models.Aluno", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ImproveU_backend.Models.EdFisico", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Pessoa", "Pessoa")
                        .WithOne("EdFisico")
                        .HasForeignKey("ImproveU_backend.Models.EdFisico", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Feedback", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Aluno", "Aluno")
                        .WithMany("Feedbacks")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImproveU_backend.Models.EdFisico", "EdFisico")
                        .WithMany("Feedbacks")
                        .HasForeignKey("EdFisicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("EdFisico");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Foto", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Pessoa", "Pessoa")
                        .WithMany("Fotos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ImproveU_backend.Models.ItemTreinoARealizar", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Exercicio", "ExercicioARealizar")
                        .WithMany("ItensTreino")
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImproveU_backend.Models.Treino", "Treino")
                        .WithMany("ItensTreinoARealizar")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExercicioARealizar");

                    b.Navigation("Treino");
                });

            modelBuilder.Entity("ImproveU_backend.Models.ItemTreinoRealizados", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Exercicio", "ExercicioRealizado")
                        .WithMany()
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImproveU_backend.Models.Feedback", "Feedback")
                        .WithOne("ItemTreinoRealizado")
                        .HasForeignKey("ImproveU_backend.Models.ItemTreinoRealizados", "FeedbackId");

                    b.HasOne("ImproveU_backend.Models.Treino", "Treino")
                        .WithMany("ItensTreinoRealizados")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExercicioRealizado");

                    b.Navigation("Feedback");

                    b.Navigation("Treino");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Pessoa", b =>
                {
                    b.HasOne("ImproveU_backend.Models.ApplicationUser", "IdentityAppUser")
                        .WithOne("Pessoa")
                        .HasForeignKey("ImproveU_backend.Models.Pessoa", "IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityAppUser");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Treino", b =>
                {
                    b.HasOne("ImproveU_backend.Models.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImproveU_backend.Models.EdFisico", "EdFisico")
                        .WithMany("Treinos")
                        .HasForeignKey("EdFisicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("EdFisico");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImproveU_backend.Models.ApplicationUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithOne()
                        .HasForeignKey("ImproveU_backend.Models.ApplicationUser", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImproveU_backend.Models.Aluno", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("ImproveU_backend.Models.EdFisico", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Exercicio", b =>
                {
                    b.Navigation("ItensTreino");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Feedback", b =>
                {
                    b.Navigation("ItemTreinoRealizado")
                        .IsRequired();
                });

            modelBuilder.Entity("ImproveU_backend.Models.Pessoa", b =>
                {
                    b.Navigation("Aluno");

                    b.Navigation("EdFisico")
                        .IsRequired();

                    b.Navigation("Fotos");
                });

            modelBuilder.Entity("ImproveU_backend.Models.Treino", b =>
                {
                    b.Navigation("ItensTreinoARealizar");

                    b.Navigation("ItensTreinoRealizados");
                });

            modelBuilder.Entity("ImproveU_backend.Models.ApplicationUser", b =>
                {
                    b.Navigation("Pessoa")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
