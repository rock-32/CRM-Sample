using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_Sample.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CRMAdminTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRMAdminTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSourceTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSourceTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatusTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatusTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskItemTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItemTb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchTb_ClientsTb_Client_Id",
                        column: x => x.Client_Id,
                        principalTable: "ClientsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Id = table.Column<int>(type: "int", nullable: false),
                    clientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignTb_ClientsTb_clientsId",
                        column: x => x.clientsId,
                        principalTable: "ClientsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentTb_BranchTb_branchId",
                        column: x => x.branchId,
                        principalTable: "BranchTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role_Id = table.Column<int>(type: "int", nullable: false),
                    rolesId = table.Column<int>(type: "int", nullable: false),
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffsTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffsTb_BranchTb_branchId",
                        column: x => x.branchId,
                        principalTable: "BranchTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffsTb_RoleTb_rolesId",
                        column: x => x.rolesId,
                        principalTable: "RoleTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadsTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextFollowUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FollowUpNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false),
                    Department_Id = table.Column<int>(type: "int", nullable: false),
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Campaign_Id = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    LeadSourceId = table.Column<int>(type: "int", nullable: true),
                    LeadStatusId = table.Column<int>(type: "int", nullable: true),
                    StaffsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadsTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsTb_BranchTb_BranchId",
                        column: x => x.BranchId,
                        principalTable: "BranchTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_CampaignTb_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "CampaignTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_DepartmentTb_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DepartmentTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_LeadSourceTb_LeadSourceId",
                        column: x => x.LeadSourceId,
                        principalTable: "LeadSourceTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_LeadStatusTb_LeadStatusId",
                        column: x => x.LeadStatusId,
                        principalTable: "LeadStatusTb",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeadsTb_StaffsTb_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "StaffsTb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserTaskTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taskitem_Id = table.Column<int>(type: "int", nullable: false),
                    taskItemId = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTaskTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTaskTb_StaffsTb_usersId",
                        column: x => x.usersId,
                        principalTable: "StaffsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTaskTb_TaskItemTb_taskItemId",
                        column: x => x.taskItemId,
                        principalTable: "TaskItemTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadsHistoryTb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lead_Id = table.Column<int>(type: "int", nullable: false),
                    leadId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadsHistoryTb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadsHistoryTb_LeadsTb_leadId",
                        column: x => x.leadId,
                        principalTable: "LeadsTb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchTb_Client_Id",
                table: "BranchTb",
                column: "Client_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignTb_clientsId",
                table: "CampaignTb",
                column: "clientsId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentTb_branchId",
                table: "DepartmentTb",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsHistoryTb_leadId",
                table: "LeadsHistoryTb",
                column: "leadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_BranchId",
                table: "LeadsTb",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_CampaignId",
                table: "LeadsTb",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_DepartmentId",
                table: "LeadsTb",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_LeadSourceId",
                table: "LeadsTb",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_LeadStatusId",
                table: "LeadsTb",
                column: "LeadStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadsTb_StaffsId",
                table: "LeadsTb",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffsTb_branchId",
                table: "StaffsTb",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffsTb_rolesId",
                table: "StaffsTb",
                column: "rolesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTaskTb_taskItemId",
                table: "UserTaskTb",
                column: "taskItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTaskTb_usersId",
                table: "UserTaskTb",
                column: "usersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CRMAdminTb");

            migrationBuilder.DropTable(
                name: "LeadsHistoryTb");

            migrationBuilder.DropTable(
                name: "UserTaskTb");

            migrationBuilder.DropTable(
                name: "LeadsTb");

            migrationBuilder.DropTable(
                name: "TaskItemTb");

            migrationBuilder.DropTable(
                name: "CampaignTb");

            migrationBuilder.DropTable(
                name: "DepartmentTb");

            migrationBuilder.DropTable(
                name: "LeadSourceTb");

            migrationBuilder.DropTable(
                name: "LeadStatusTb");

            migrationBuilder.DropTable(
                name: "StaffsTb");

            migrationBuilder.DropTable(
                name: "BranchTb");

            migrationBuilder.DropTable(
                name: "RoleTb");

            migrationBuilder.DropTable(
                name: "ClientsTb");
        }
    }
}
