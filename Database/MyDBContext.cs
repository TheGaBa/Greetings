using Database.Models;
using Database.Properties;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Database
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<ImageStorage> ImageStorage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
               new City()
               {
                   CityId = 1,
                   CityName = "LosAngeles",
                   Image = Resources.La1,
                   Rating = "4.9",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 2,
                   CityName = "Zp",
                   Image = Resources.zaporizhzhya_2,
                   Rating = "4.1",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 3,
                   CityName = "Tokyo",
                   Image = Resources._1,
                   Rating = "5.0",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 4,
                   CityName = "Kyoto",
                   Image = Resources.kyoto1,
                   Rating = "5.0",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 5,
                   CityName = "Washington",
                   Image = Resources.Washington1,
                   Rating = "4.7",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 6,
                   CityName = "Lapland",
                   Image = Resources.lapland,
                   Rating = "4.8",
                   Places = new List<Place>()
               }
            );

            modelBuilder.Entity<Place>().HasData(
                            new Place() { PlaceId = 1, CityId = 1, PlaceName = "Warner Brothers", Address = "4301 W Olive Ave, Burbank, CA 91505, Соединенные Штаты", Cost = 400, Time = 240, Image = Resources.warner_bros, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 2, CityId = 1, PlaceName = "Hollywood", Address = "Los Angeles, CA 90068, Соединенные Штаты", Cost = 140, Time = 30, Image = Resources.Hollywood_Sign_Zuschnitt_801x501, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 3, CityId = 1, PlaceName = "Broad Contemporary Art Museum", Address = "221 S Grand Ave, Los Angeles, CA 90012, Соединенные Штаты", Cost = 400, Time = 180, Image = Resources.The_Broad_Contemporary_Art_Museum_in_Downtown_Los_Angeles, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 4, CityId = 1, PlaceName = "Griffith Park", Address = "4730 Crystal Springs Dr, Los Angeles, CA 90027, Соединенные Штаты", Cost = 40, Image = Resources.Griffith_Park_Los_Angeles_Hiking_Track, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 5, CityId = 1, PlaceName = "Madame Tussauds Hollywood", Address = "6933 Hollywood Blvd, Hollywood, CA 90028, Соединенные Штаты", Cost = 450, Time = 120, Image = Resources.madame_tussauds_hollywood, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },

                            new Place() { PlaceId = 6, CityId = 2, PlaceName = "Лечебные источники в Терпенье", Address = "Terpinnya, Zaporizhia Oblast, 72333", Cost = 400, Time = 180, Image = Resources.Healing_springs_in_Terpenye, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 7, CityId = 2, PlaceName = "Усадьба Попова", Address = "вулиця Гагаріна, 12, Василівка, Запорізька область, 71600", Cost = 100, Time = 120, Image = Resources.usadba_popova, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 8, CityId = 2, PlaceName = "Васильевский зоопарк", Address = "Степова вулиця, 8, Василівка, Запорізька область, 71600", Cost = 300, Time = 120, Image = Resources.vasilievka_zoo, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 9, CityId = 2, PlaceName = "Запорожская Сечь", Address = "о.Хортиця, вул. Старого редуту 10, Запоріжжя, Запорізька область, 69000", Cost = 300, Time = 240, Image = Resources.sech, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },

            new Place() { PlaceId = 10, CityId = 3, PlaceName = "Перекресток на Сибуя", Cost = 420, Time = 180, Image = Resources._12_Perekrestok_na_Sibuya_e1528915241354, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 11, CityId = 3, PlaceName = "Район Асакуса", Cost = 250, Time = 120, Image = Resources._2_Rayon_Asakusa_e1528832886299, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 12, CityId = 3, PlaceName = "Станция Акихабара", Cost = 300, Time = 300, Image = Resources._4_Outside_Akihabara_Station_e1528841551644, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 13, CityId = 3, PlaceName = "Храм императора Мейдзы", Address = "1-1 Yoyogikamizonocho, Shibuya City, Tokyo 151-8557, Япония", Cost = 300, Time = 120, Image = Resources._10_Hram_imperatora_Meydzi_e1528833104117, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 14, CityId = 3, PlaceName = "Сад Хаппон", Address = "1 Chome-1-1 Shirokanedai, Minato City, Tokyo 108-0071, Япония", Cost = 300, Time = 120, Image = Resources._8_Sad_Happoen_e1528833047691, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 15, CityId = 3, PlaceName = "Национальный центр искусства", Address = "7 Chome-22-2 Roppongi, Minato City, Tokyo 106-8558, Япония", Cost = 300, Time = 180, Image = Resources.the_national_art_center_tokyo_t2, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },


                            new Place() { PlaceId = 16, CityId = 4, PlaceName = "Национальный муниципальный музей Киото", Address = "3-1 Kitanomarukoen, Chiyoda City, Tokyo 102-8322, Япония", Cost = 420, Time = 120, Image = Resources.kyoto_national_municipal_museum, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 17, CityId = 4, PlaceName = "Интернациональный музей манги Киото", Address = "452 Kinbukicho, Nakagyo Ward, Kyoto, 604-0846, Япония", Cost = 300, Time = 180, Image = Resources._22_Kyoto_International_Manga_Museum, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 18, CityId = 4, PlaceName = "Бамбуковая роща", Address = "Ukyo Ward, Kyoto, 616-0007, Япония", Cost = 100, Time = 240, Image = Resources._3_Bambukovaya_roshha_Sagano_e1528829507639, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 19, CityId = 4, PlaceName = "Храм Киёмидзу-дэра", Address = "294 Kiyomizu, Higashiyama Ward, Kyoto, 605-0862, Япония", Cost = 450, Time = 180, Image = Resources._4_Hram_Kiyomidzue1528829737668, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 20, CityId = 4, PlaceName = "Университет искусства Киото", Address = "2-116 Kitashirakawa Uryuzancho, Sakyo Ward, Kyoto, 606-8271, Япония", Cost = 300, Time = 120, Image = Resources.kyoto_university_of_art, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 21, CityId = 4, PlaceName = "Золотой павильон", Address = "1 Kinkakujicho, Kita Ward, Kyoto, 603-8361, Япония", Cost = 350, Time = 60, Image = Resources._2_Zotoy_pavilon_e1528829317599, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },

            new Place() { PlaceId = 22, CityId = 5, PlaceName = "Белый дом", Address = "1600 Pennsylvania Avenue NW, Washington, DC 20500, Соединенные Штаты", Cost = 500, Time = 240, Image = Resources.white_house, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 23, CityId = 5, PlaceName = "Вашингтонский монумент", Address = "2 15th St NW, Washington, DC 20024, Соединенные Штаты", Cost = 300, Time = 60, Image = Resources.washington_monument, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 24, CityId = 5, PlaceName = "Национальный музей воздухоплавания и астронавтики", Address = "600 Independence Ave SW, Washington, DC 20560, Соединенные Штаты", Cost = 480, Time = 240, Image = Resources.national_air_and_space_museum, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 25, CityId = 5, PlaceName = "Библиотека конгресса", Address = "101 Independence Ave SE, Washington, DC 20540, Соединенные Штаты", Cost = 375, Time = 300, Image = Resources.library_of_congress, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 26, CityId = 5, PlaceName = "Капитолий Соединенных Штатов", Address = "First St SE, Washington, DC 20004, Соединенные Штаты", Cost = 800, Time = 120, Image = Resources.united_states_capitol, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 27, CityId = 5, PlaceName = "Мемориал Линкольна", Address = "2 Lincoln Memorial Cir NW, Washington, DC 20002, Соединенные Штаты", Cost = 40, Image = Resources.lincoln_memorial, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },


                            new Place() { PlaceId = 28, CityId = 6, PlaceName = "Ледяной отель", Address = "Lehtoahontie 31, 97220 Rovaniemi, Финляндия", Cost = 1540, Time = 1440, Image = Resources.ice_hotel, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 29, CityId = 6, PlaceName = "Санта парк", Address = "Tarvantie 1, 96930 Rovaniemi, Финляндия", Cost = 600, Time = 240, Image = Resources.Santa_park, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 30, CityId = 6, PlaceName = "Деревня Санта Клауса", Address = "96930 Rovaniemi, Финляндия", Cost = 300, Time = 300, Image = Resources.santa_klaus_village, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 31, CityId = 6, PlaceName = "Зоопарк Рануа", Address = "Rovaniementie 29, 97700 Ranua, Финляндия", Cost = 300, Time = 240, Image = Resources.ranua_zoo, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 32, CityId = 6, PlaceName = "Лапландский мост", Address = "Utsjoentie, 99980 Utsjoki, Финляндия", Cost = 30, Image = Resources.yatkankyuntyllya_bridge, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 33, CityId = 6, PlaceName = "Музей Пильке", Address = "Ounasjoentie 6, 96200 Rovaniemi, Финляндия", Cost = 420, Time = 300, Image = Resources.pilke_museum, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() }

                            );

            modelBuilder.Entity<ImageStorage>().HasData(
                            new ImageStorage() { ID = 1, Image = Resources.wb1, PlaceID = 1 },
                            new ImageStorage() { ID = 2, Image = Resources.wb2, PlaceID = 1 },
                            new ImageStorage() { ID = 3, Image = Resources.wb3, PlaceID = 1 },
                            new ImageStorage() { ID = 4, Image = Resources.holly1, PlaceID = 2 },
                            new ImageStorage() { ID = 5, Image = Resources.holly2, PlaceID = 2 },
                            new ImageStorage() { ID = 6, Image = Resources.holly3, PlaceID = 2 },
                            new ImageStorage() { ID = 7, Image = Resources.bc1, PlaceID = 3 },
                            new ImageStorage() { ID = 8, Image = Resources.bc2, PlaceID = 3 },
                            new ImageStorage() { ID = 9, Image = Resources.bc3, PlaceID = 3 },
                            new ImageStorage() { ID = 10, Image = Resources.gp1, PlaceID = 4 },
                            new ImageStorage() { ID = 11, Image = Resources.gp2, PlaceID = 4 },
                            new ImageStorage() { ID = 12, Image = Resources.gp3, PlaceID = 4 },
                            new ImageStorage() { ID = 13, Image = Resources.mt1, PlaceID = 5 },
                            new ImageStorage() { ID = 14, Image = Resources.mt2, PlaceID = 5 },
                            new ImageStorage() { ID = 15, Image = Resources.mt3, PlaceID = 5 }
                        );
        }
    }
}