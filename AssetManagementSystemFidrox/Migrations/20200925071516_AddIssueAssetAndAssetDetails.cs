using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemFidrox.Migrations
{
    public partial class AddIssueAssetAndAssetDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LasrName = table.Column<string>(maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    PhoneNumber2 = table.Column<string>(maxLength: 12, nullable: true),
                    IsAdmin = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphicsCardModels",
                columns: table => new
                {
                    Graphics_CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Graphics_Card_GC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicsCardModels", x => x.Graphics_CardId);
                });

            migrationBuilder.CreateTable(
                name: "HardDiskModels",
                columns: table => new
                {
                    Hard_DiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hard_Disk_HD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDiskModels", x => x.Hard_DiskId);
                });

            migrationBuilder.CreateTable(
                name: "ItemsBrands",
                columns: table => new
                {
                    brandsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brands_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsBrands", x => x.brandsId);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystemModels",
                columns: table => new
                {
                    OSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Operating_System = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystemModels", x => x.OSId);
                });

            migrationBuilder.CreateTable(
                name: "RamModels",
                columns: table => new
                {
                    RAM_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RAM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamModels", x => x.RAM_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetDetails",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Asset_No = table.Column<string>(maxLength: 50, nullable: false),
                    Asset_name = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_model_no = table.Column<string>(maxLength: 50, nullable: true),
                    AstProcessor = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_type = table.Column<string>(maxLength: 50, nullable: false),
                    Asset_accessories = table.Column<string>(maxLength: 150, nullable: true),
                    Asset_Ram_GB = table.Column<string>(nullable: false),
                    Asset_HardDisk_GB = table.Column<string>(nullable: false),
                    Asset_LicenseKey = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_Mouse = table.Column<string>(nullable: true),
                    Asset_Bag_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_graphics_crd_GB = table.Column<string>(nullable: true),
                    Asset_Charger = table.Column<string>(nullable: true),
                    Asset_OS = table.Column<string>(nullable: true),
                    Asset_purchase_dt = table.Column<string>(nullable: true),
                    Asset_puch_place = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_price = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_purchase_bill_no = table.Column<string>(maxLength: 50, nullable: true),
                    Asset_Status = table.Column<string>(nullable: true),
                    Asset_Remarks = table.Column<string>(maxLength: 250, nullable: true),
                    ramModelRAM_ID = table.Column<int>(nullable: true),
                    hardDiskModelHard_DiskId = table.Column<int>(nullable: true),
                    itemsBrandbrandsId = table.Column<int>(nullable: true),
                    graphicsCardGraphics_CardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDetails", x => x.AssetId);
                    table.ForeignKey(
                        name: "FK_AssetDetails_GraphicsCardModels_graphicsCardGraphics_CardId",
                        column: x => x.graphicsCardGraphics_CardId,
                        principalTable: "GraphicsCardModels",
                        principalColumn: "Graphics_CardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetails_HardDiskModels_hardDiskModelHard_DiskId",
                        column: x => x.hardDiskModelHard_DiskId,
                        principalTable: "HardDiskModels",
                        principalColumn: "Hard_DiskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetails_ItemsBrands_itemsBrandbrandsId",
                        column: x => x.itemsBrandbrandsId,
                        principalTable: "ItemsBrands",
                        principalColumn: "brandsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetails_RamModels_ramModelRAM_ID",
                        column: x => x.ramModelRAM_ID,
                        principalTable: "RamModels",
                        principalColumn: "RAM_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetIssueDetails",
                columns: table => new
                {
                    IssueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fdx_Emp_Id = table.Column<int>(nullable: false),
                    Fdx_Emp_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Fdx_Emp_wrk_loc = table.Column<string>(nullable: true),
                    Fdx_Emp_Designation = table.Column<string>(maxLength: 50, nullable: true),
                    Fdx_Emp_Recived_item = table.Column<string>(nullable: true),
                    Fdx_Emp_EmailId = table.Column<string>(maxLength: 50, nullable: false),
                    Fdx_Emp_Replace_Item = table.Column<string>(nullable: true),
                    Fdx_Emp_Acknowledge = table.Column<string>(nullable: false),
                    Fdx_Asset_no = table.Column<string>(maxLength: 50, nullable: false),
                    Fdx_Asset_issued_dt = table.Column<string>(nullable: false),
                    Fdx_Asset_return_dt = table.Column<string>(nullable: true),
                    Fdx_Asset_Status = table.Column<string>(maxLength: 10, nullable: true),
                    Fdx_Asset_Remarks = table.Column<string>(maxLength: 250, nullable: true),
                    Fdx_Asset_New_Old = table.Column<string>(nullable: true),
                    Fdx_Asset_Model_name = table.Column<string>(maxLength: 150, nullable: true),
                    assetDetailsAssetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetIssueDetails", x => x.IssueID);
                    table.ForeignKey(
                        name: "FK_AssetIssueDetails_AssetDetails_assetDetailsAssetId",
                        column: x => x.assetDetailsAssetId,
                        principalTable: "AssetDetails",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetails_graphicsCardGraphics_CardId",
                table: "AssetDetails",
                column: "graphicsCardGraphics_CardId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetails_hardDiskModelHard_DiskId",
                table: "AssetDetails",
                column: "hardDiskModelHard_DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetails_itemsBrandbrandsId",
                table: "AssetDetails",
                column: "itemsBrandbrandsId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetails_ramModelRAM_ID",
                table: "AssetDetails",
                column: "ramModelRAM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AssetIssueDetails_assetDetailsAssetId",
                table: "AssetIssueDetails",
                column: "assetDetailsAssetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssetIssueDetails");

            migrationBuilder.DropTable(
                name: "OperatingSystemModels");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AssetDetails");

            migrationBuilder.DropTable(
                name: "GraphicsCardModels");

            migrationBuilder.DropTable(
                name: "HardDiskModels");

            migrationBuilder.DropTable(
                name: "ItemsBrands");

            migrationBuilder.DropTable(
                name: "RamModels");
        }
    }
}
