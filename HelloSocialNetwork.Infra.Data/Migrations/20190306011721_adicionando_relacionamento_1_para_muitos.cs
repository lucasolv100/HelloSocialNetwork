﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloSocialNetwork.Infra.Data.Migrations
{
    public partial class adicionando_relacionamento_1_para_muitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Postagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Postagens");
        }
    }
}
