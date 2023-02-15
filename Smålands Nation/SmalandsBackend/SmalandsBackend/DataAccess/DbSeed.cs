using Microsoft.EntityFrameworkCore;
using SmalandsBackend.Models;

namespace SmalandsBackend.DataAccess
{
    public static class DbSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Board[] boardMembers =
            {
                new Board()
                {
                    Id = 1,
                    Name = "Gabriella Långbergs",
                    Role = "Ordförande",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                new Board()
                {
                    Id=2,
                    Name = "Eric Sandberg",
                    Role = "Vice-Ordförande",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                 new Board()
                {
                    Id=3,
                    Name = "Oliver Nordwall",
                    Role = "Ekonomiansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                  new Board()
                {
                    Id=4,
                    Name = "André Franzén",
                    Role = "Festansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                   new Board()
                {
                    Id=5,
                    Name = "Dag Mattsson",
                    Role = "Fest-och Utskottsansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                    new Board()
                {
                    Id=6,
                    Name = "Amanda Sten",
                    Role = "Festansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                     new Board()
                {
                    Id=7,
                    Name = "Linus Johansson",
                    Role = "Aktivitets-och Utskottsansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                      new Board()
                {
                    Id=8,
                    Name = "Mia Parkkinen",
                    Role = "Aktivitetsansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                       new Board()
                {
                    Id=9,
                    Name = "Mårten Stridh",
                    Role = "Housemoose",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                        new Board()
                {
                    Id=10,
                    Name = "Philip Giselson",
                    Role = "Band och PA",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                         new Board()
                {
                    Id=11,
                    Name = "Cornelis Blom",
                    Role = "Band/PA-och Jobbansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                          new Board()
                {
                    Id=12,
                    Name = "Filippa Lindblom",
                    Role = "Info/Webb/PR",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                           new Board()
                {
                    Id=13,
                    Name = "Josefin Augustson",
                    Role = "Samarbete",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                            new Board()
                {
                    Id=14,
                    Name = "Behiye Kaya",
                    Role = "Samarbete",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                             new Board()
                {
                    Id=15,
                    Name = "Melvin Johnsson",
                    Role = "Sivansansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },
                             new Board()
                {
                    Id=16,
                    Name = "Ramazan Soyal",
                    Role = "Sivansansvarig",
                    Picture = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU"
                },

            };
            image[] imageGallery =
            {
                new image()
                {
                    Id=1,
                    PictureUrl = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU",
                    Description = "Generic Image",
                    Height = 50,
                    Width = 50,
                    Title = "Test image",
                },
                 new image()
                {
                    Id=2,
                    PictureUrl = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU",
                    Description = "Generic Image2",
                    Height = 50,
                    Width = 50,
                    Title = "Image",
                },
                  new image()
                {
                    Id=3,
                    PictureUrl = "https://i.picsum.photos/id/5/200/300.jpg?hmac=1TWjKFT7_MRP0ApEyDUA3eCP0HXaKTWJfHgVjwGNoZU",
                    Description = "Generic Image3",
                    Height = 50,
                    Width = 50,
                    Title = "Test imag3",
                },
            };
            foreach (var member in boardMembers)
            {
                modelBuilder.Entity<Board>().HasData(member);
            }
            foreach (var image in imageGallery)
            {
                modelBuilder.Entity<image>().HasData(image);
            }
        }
    }
}
