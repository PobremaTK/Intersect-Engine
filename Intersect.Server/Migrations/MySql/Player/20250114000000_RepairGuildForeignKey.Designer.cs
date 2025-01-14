﻿// <auto-generated />
using System;
using Intersect.Server.Database.PlayerData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intersect.Server.Migrations.MySql.Player
{
    [DbContext(typeof(MySqlPlayerContext))]
    [Migration("20250114000000_RepairGuildForeignKey")]
    partial class MySqlGuildForeignKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Api.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0)
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Issued")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ticket")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("TicketId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Ban", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Banner")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .HasColumnType("longtext");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("PlayerId")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Bans");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Mute", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ip")
                        .HasColumnType("longtext");

                    b.Property<string>("Muter")
                        .HasColumnType("longtext");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("PlayerId")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Mutes");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Bag", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("SlotCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bags");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BagSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("BagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnType("longtext")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("ParentBagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("ParentBagId");

                    b.ToTable("Bag_Items");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BankSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("BagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnType("longtext")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Bank");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Friend", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("TargetId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TargetId");

                    b.ToTable("Player_Friends");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Guild", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("BankSlotsCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("FoundingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("GuildInstanceId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildBankSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("BagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("GuildId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnType("longtext")
                        .HasColumnName("ItemProperties");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("GuildId");

                    b.ToTable("Guild_Bank");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("GuildId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Json")
                        .HasColumnType("longtext")
                        .HasColumnName("Value");

                    b.Property<Guid>("VariableId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("VariableId", "GuildId")
                        .IsUnique();

                    b.ToTable("Guild_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.HotbarSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("BagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ItemOrSpellId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<string>("StatBuffsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("PreferredStatBuffs");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Hotbar");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.InventorySlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid?>("BagId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnType("longtext")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Items");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.PlayerVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Json")
                        .HasColumnType("longtext")
                        .HasColumnName("Value");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("VariableId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("VariableId", "PlayerId")
                        .IsUnique();

                    b.ToTable("Player_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Quest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("QuestId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("TaskProgress")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("QuestId", "PlayerId")
                        .IsUnique();

                    b.ToTable("Player_Quests");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SpellSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<Guid>("SpellId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Spells");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.UserVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Json")
                        .HasColumnType("longtext")
                        .HasColumnName("Value");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("VariableId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VariableId", "UserId")
                        .IsUnique();

                    b.ToTable("User_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0)
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnOrder(2);

                    b.Property<string>("LastIp")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnOrder(1);

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordResetCode")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("PasswordResetTime")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("PlayTimeSeconds")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("PowerJson")
                        .HasColumnType("longtext")
                        .HasColumnName("Power");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Intersect.Server.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnOrder(0)
                        .UseCollation("ascii_general_ci");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("DbGuildId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("Dir")
                        .HasColumnType("int");

                    b.Property<string>("EquipmentJson")
                        .HasColumnType("longtext")
                        .HasColumnName("Equipment");

                    b.Property<long>("Exp")
                        .HasColumnType("bigint");

                    b.Property<string>("Face")
                        .HasColumnType("longtext");

                    b.Property<string>("FooterLabelJson")
                        .HasColumnType("longtext")
                        .HasColumnName("FooterLabel");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuildJoinDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GuildRank")
                        .HasColumnType("int");

                    b.Property<string>("HeaderLabelJson")
                        .HasColumnType("longtext")
                        .HasColumnName("HeaderLabel");

                    b.Property<int>("InstanceType")
                        .HasColumnType("int");

                    b.Property<string>("ItemCooldownsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("ItemCooldowns");

                    b.Property<string>("JsonColor")
                        .HasColumnType("longtext")
                        .HasColumnName("Color");

                    b.Property<DateTime?>("LastOnline")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("LastOverworldMapId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastOverworldMapId")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("LastOverworldX")
                        .HasColumnType("int");

                    b.Property<int>("LastOverworldY")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<Guid>("MapId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnOrder(1);

                    b.Property<string>("NameColorJson")
                        .HasColumnType("longtext")
                        .HasColumnName("NameColor");

                    b.Property<Guid>("PersonalMapInstanceId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<ulong>("PlayTimeSeconds")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("SharedInstanceRespawnDir")
                        .HasColumnType("int");

                    b.Property<Guid>("SharedInstanceRespawnId")
                        .HasColumnType("char(36)")
                        .HasColumnName("SharedInstanceRespawnId")
                        .UseCollation("ascii_general_ci");

                    b.Property<int>("SharedInstanceRespawnX")
                        .HasColumnType("int");

                    b.Property<int>("SharedInstanceRespawnY")
                        .HasColumnType("int");

                    b.Property<Guid>("SharedMapInstanceId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("SpellCooldownsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("SpellCooldowns");

                    b.Property<string>("Sprite")
                        .HasColumnType("longtext");

                    b.Property<int>("StatPoints")
                        .HasColumnType("int");

                    b.Property<string>("StatPointsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("StatPointAllocations");

                    b.Property<string>("StatsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("BaseStats");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .UseCollation("ascii_general_ci");

                    b.Property<string>("VitalsJson")
                        .HasColumnType("longtext")
                        .HasColumnName("Vitals");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.Property<int>("Z")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DbGuildId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Api.RefreshToken", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Ban", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithOne("Ban")
                        .HasForeignKey("Intersect.Server.Database.PlayerData.Ban", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Mute", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithOne("Mute")
                        .HasForeignKey("Intersect.Server.Database.PlayerData.Mute", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BagSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "ParentBag")
                        .WithMany("Slots")
                        .HasForeignKey("ParentBagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bag");

                    b.Navigation("ParentBag");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BankSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Bank")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bag");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Friend", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Owner")
                        .WithMany("Friends")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Intersect.Server.Entities.Player", "Target")
                        .WithMany()
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Owner");

                    b.Navigation("Target");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildBankSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "Guild")
                        .WithMany("Bank")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bag");

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildVariable", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "Guild")
                        .WithMany("Variables")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.HotbarSlot", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Hotbar")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.InventorySlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Items")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bag");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.PlayerVariable", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Variables")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Quest", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Quests")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SpellSlot", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Spells")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.UserVariable", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("Variables")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intersect.Server.Entities.Player", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "DbGuild")
                        .WithMany()
                        .HasForeignKey("DbGuildId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DbGuild");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Bag", b =>
                {
                    b.Navigation("Slots");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Guild", b =>
                {
                    b.Navigation("Bank");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.User", b =>
                {
                    b.Navigation("Ban");

                    b.Navigation("Mute");

                    b.Navigation("Players");

                    b.Navigation("RefreshTokens");

                    b.Navigation("Variables");
                });

            modelBuilder.Entity("Intersect.Server.Entities.Player", b =>
                {
                    b.Navigation("Bank");

                    b.Navigation("Friends");

                    b.Navigation("Hotbar");

                    b.Navigation("Items");

                    b.Navigation("Quests");

                    b.Navigation("Spells");

                    b.Navigation("Variables");
                });
#pragma warning restore 612, 618
        }
    }
}
