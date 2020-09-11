﻿// <auto-generated />
using System;
using KinoCentar.API.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KinoCentar.API.Migrations
{
    [DbContext(typeof(KinoCentarDbContext))]
    partial class KinoCentarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KinoCentar.API.EntityModels.Anketa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ZakljucenoDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Anketa");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.AnketaOdgovor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnketaId")
                        .HasColumnType("int");

                    b.Property<string>("Odgovor")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("RedniBroj")
                        .HasColumnType("int");

                    b.Property<int>("UkupnoIzabrano")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnketaId");

                    b.ToTable("AnketaOdgovor");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Artikal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("JedinicaMjereId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("JedinicaMjereId");

                    b.ToTable("Artikal");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Dojam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("ProjekcijaId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ProjekcijaId");

                    b.ToTable("Dojam");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GodinaSnimanja")
                        .HasColumnType("int");

                    b.Property<string>("ImdbLink")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<byte[]>("Plakat")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PlakatThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("RediteljId")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int?>("Trajanje")
                        .HasColumnType("int");

                    b.Property<string>("VideoLink")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("ZanrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RediteljId");

                    b.HasIndex("ZanrId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.FilmGlumacDodjela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("FilmskaLicnostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("FilmskaLicnostId");

                    b.ToTable("FilmGlumacDodjela");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.FilmskaLicnost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("IsGlumac")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReziser")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("FilmskaLicnost");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.JedinicaMjere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KratkiNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JedinicaMjere");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TipKorisnikaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipKorisnikaId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Obavijest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Prodaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojRacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Popust")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Porez")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Prodaja");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProdajaArtikalDodjela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtikalId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("ProdajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("ProdajaId");

                    b.ToTable("ProdajaArtikalDodjela");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProdajaRezervacijaDodjela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdajaId")
                        .HasColumnType("int");

                    b.Property<int>("RezervacijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdajaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("ProdajaRezervacijaDodjela");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Projekcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijediDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VrijediOd")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("SalaId");

                    b.ToTable("Projekcija");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProjekcijaKorisnikDodjela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPosjete")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPosljednjePosjete")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("ProjekcijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ProjekcijaId");

                    b.ToTable("ProjekcijaKorisnikDodjela");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProjekcijaTermin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjekcijaId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Termin")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ProjekcijaId");

                    b.ToTable("ProjekcijaTermin");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojSjedista")
                        .HasColumnType("int");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumOtkazano")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumProdano")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumProjekcije")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("ProjekcijaTerminId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ProjekcijaTerminId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrojSjedista")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.TipKorisnika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipKorisnika");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Zanr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Anketa", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany("Ankete")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.AnketaOdgovor", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Anketa", "Anketa")
                        .WithMany("Odgovori")
                        .HasForeignKey("AnketaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Artikal", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.JedinicaMjere", "JedinicaMjere")
                        .WithMany("Artikli")
                        .HasForeignKey("JedinicaMjereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Dojam", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany("Dojmovi")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.Projekcija", "Projekcija")
                        .WithMany()
                        .HasForeignKey("ProjekcijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Film", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.FilmskaLicnost", "Reditelj")
                        .WithMany("FilmoviReditelja")
                        .HasForeignKey("RediteljId");

                    b.HasOne("KinoCentar.API.EntityModels.Zanr", "Zanr")
                        .WithMany("Filmovi")
                        .HasForeignKey("ZanrId");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.FilmGlumacDodjela", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Film", "Film")
                        .WithMany("Glumci")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.FilmskaLicnost", "FilmskaLicnost")
                        .WithMany("FilmoviGlumaca")
                        .HasForeignKey("FilmskaLicnostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Korisnik", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.TipKorisnika", "TipKorisnika")
                        .WithMany("Korisnici")
                        .HasForeignKey("TipKorisnikaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Obavijest", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany("Obavijesti")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Prodaja", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProdajaArtikalDodjela", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Artikal", "Artikal")
                        .WithMany("Prodaja")
                        .HasForeignKey("ArtikalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.Prodaja", "Prodaja")
                        .WithMany("ArtikliStavke")
                        .HasForeignKey("ProdajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProdajaRezervacijaDodjela", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Prodaja", "Prodaja")
                        .WithMany("RezervacijeStavke")
                        .HasForeignKey("ProdajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.Rezervacija", "Rezervacija")
                        .WithMany("Prodaja")
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Projekcija", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Film", "Film")
                        .WithMany("Projekcije")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.Sala", "Sala")
                        .WithMany("Projekcije")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProjekcijaKorisnikDodjela", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany("PosjeteProjekcija")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KinoCentar.API.EntityModels.Projekcija", "Projekcija")
                        .WithMany("PosjeteKorisnika")
                        .HasForeignKey("ProjekcijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.ProjekcijaTermin", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Projekcija", "Projekcija")
                        .WithMany("Termini")
                        .HasForeignKey("ProjekcijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoCentar.API.EntityModels.Rezervacija", b =>
                {
                    b.HasOne("KinoCentar.API.EntityModels.Korisnik", "Korisnik")
                        .WithMany("Rezervacije")
                        .HasForeignKey("KorisnikId");

                    b.HasOne("KinoCentar.API.EntityModels.ProjekcijaTermin", "ProjekcijaTermin")
                        .WithMany("Rezervacije")
                        .HasForeignKey("ProjekcijaTerminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
