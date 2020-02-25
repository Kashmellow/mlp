
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mlp;

namespace mlp.Migrations
{
    [DbContext(typeof(MlpContext))]
    partial class MlpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mlp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeGroup")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Leader",

                            DateTimeGroup = new DateTime(2020, 2, 24, 14, 13, 45, 271, DateTimeKind.Local).AddTicks(5546),
                            Description = "I am a strong Pony! Haaaaay!",
                            Image = "RainbowDash.svg",
                            Name = "Rainbow Dash",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)

                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Pony",

                            DateTimeGroup = new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9301),
                            Description = "I am a shy Pony... hello!",
                            Image = "FlutterShy.svg",
                            Name = "Fluttershy",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)

                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Pony",

                            DateTimeGroup = new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9425),
                            Description = "I am a fun Pony!!!",
                            Image = "PinkyPie.svg",
                            Name = "Pinkie Pie",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)

                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Pony",

                            DateTimeGroup = new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9438),
                            Description = "I am yet another pony, heya!",
                            Image = "TwilightSparkle.svg",
                            Name = "Twilight Sparkle",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)

                        });
                });

            modelBuilder.Entity("mlp.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Content = "I love this pony!!",
                            ProductId = 1,
                            Rating = 5.0,
                            ReviewerName = "Carl"
                        },
                        new
                        {
                            ReviewId = 2,
                            Content = "I love to feed my pony!!",
                            ProductId = 2,
                            Rating = 5.0,
                            ReviewerName = "Amelia"
                        },
                        new
                        {
                            ReviewId = 3,
                            Content = "I love to ride my pony!!",
                            ProductId = 3,
                            Rating = 5.0,
                            ReviewerName = "Colleen"
                        },
                        new
                        {
                            ReviewId = 4,
                            Content = "I wish I had this pony!!",
                            ProductId = 4,
                            Rating = 5.0,
                            ReviewerName = "Tim"
                        },
                        new
                        {
                            ReviewId = 5,
                            Content = "I love collecting all sorts of ponies, but Rainbow Dash's colors are the best!!",
                            ProductId = 1,
                            Rating = 5.0,
                            ReviewerName = "Nick"
                        },
                        new
                        {
                            ReviewId = 6,
                            Content = "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...",
                            ProductId = 2,
                            Rating = 4.0,
                            ReviewerName = "Alice"
                        },
                        new
                        {
                            ReviewId = 7,
                            Content = "Quite an impeccable product indeed, although I do feel compelled to point out minor fabric manufacturing issues in light of corners being potentially cut during production. That being said, Pinkie Pie is a total cutie that never ceases to melt my tender heart~ Hats off to the lovely souls at Hasbro for spreading the love!",
                            ProductId = 3,
                            Rating = 4.5,
                            ReviewerName = "Chad"
                        },
                        new
                        {
                            ReviewId = 8,
                            Content = "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...",
                            ProductId = 4,
                            Rating = 3.5,
                            ReviewerName = "Mina"
                        },
                        new
                        {
                            ReviewId = 9,
                            Content = "I don't even know where to start with Twilight Sparkle. If I could give her more than 5 stars, I would. I deeply connect with her cutie mark which represents the interconnectedness of all. I just got it as a tattoo. TS4L ",
                            ProductId = 4,
                            Rating = 5.0,
                            ReviewerName = "Charles"
                        },
                        new
                        {
                            ReviewId = 10,
                            Content = "I just have to be the one to say it. Rainbow Dash isn't all she's cracked up to be. I've literally had night terrors where she appears at the end of my bed and her eyes are like black bottomless pits into the darkness of my soul. So scary.",
                            ProductId = 1,
                            Rating = 1.0,
                            ReviewerName = "Viktor"
                        },
                        new
                        {
                            ReviewId = 11,
                            Content = "Fluttershy is my personal favorite. I love everything about her and though I do not have anything bad to say about Fluttershy I did have a bad experience with one of the toys. Lets just say it required a doctor consultation. So I give it a 1.",
                            ProductId = 2,
                            Rating = 1.0,
                            ReviewerName = "Albert"
                        },
                        new
                        {
                            ReviewId = 12,
                            Content = "I watch My Little Ponies every single day. I am a very big fan of the show and my favorite pony is Pinkie Pie. She is so kind and shy and it reminds me of myself.",
                            ProductId = 3,
                            Rating = 5.0,
                            ReviewerName = "Esmay"
                        });
                });

            modelBuilder.Entity("mlp.Models.Review", b =>
                {
                    b.HasOne("mlp.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
