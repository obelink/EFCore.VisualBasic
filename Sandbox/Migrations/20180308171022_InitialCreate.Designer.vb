﻿' <auto-generated />
Imports System
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.Metadata.Internal
Imports Microsoft.EntityFrameworkCore.Migrations
Imports Microsoft.EntityFrameworkCore.Storage
Imports Sandbox

Namespace Sandbox.Migrations
    <DbContext(GetType(TestContext))>
    <Migration("20180308171022_InitialCreate")>
    Partial Class InitialCreate
        Protected Overrides Sub BuildTargetModel(modelBuilder As ModelBuilder)
            modelBuilder _
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30268")
            modelBuilder.Entity("Sandbox.Blog", Sub(b)

                    b.Property(Of Integer)("Id") _
                        .ValueGeneratedOnAdd()

                    b.HasKey("Id")

                    b.ToTable("Blogs")
                End Sub)

        End Sub
    End Class
End Namespace
