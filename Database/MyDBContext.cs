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
                   CityName = "Zaporizhzhia",
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
                   Image = Resources.kyoto2,
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
                            new Place() { PlaceId = 1, CityId = 1, PlaceName = "Warner Brothers", Address = "4301 W Olive Ave, Burbank, CA 91505, United States", Cost = 400 , Time = 4 , Image = Resources.warner_bros, Descriprion = "The Warner Brothers tour offers guests a unique opportunity to study in detail all the television and filming processes and is led through the studio by professional film studio guides who tell interesting stories from the filming, reveal some of the secrets of creating certain scenes of legendary films.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 2, CityId = 1, PlaceName = "Hollywood", Address = "Los Angeles, CA 90068, United States", Cost = 140 , Time = 1 , Image = Resources.Hollywood_Sign_Zuschnitt_801x501, Descriprion = "The white letters that form the inscription HOLLYWOOD, surrounded by the lush green slopes of Mount Lee, are without exaggeration the most recognizable settlement sign on the planet and also the only one with its own website. The symbol of the Dream Factory, Los Angeles, California and, often, all the States, the inscription Hollywood first appeared in 1923 - and over the past almost a century, it has repeatedly become the object of ridicule, a reason for curious scandals and a cinematic landscape.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 3, CityId = 1, PlaceName = "Broad Contemporary Art Museum", Address = "221 S Grand Ave, Los Angeles, CA 90012, United States", Cost = 400 , Time = 3 , Image = Resources.The_Broad_Contemporary_Art_Museum_in_Downtown_Los_Angeles, Descriprion = "Museum in Los Angeles, California dedicated to contemporary art. Housed in three locations throughout the city, Downtown, Little Tokyo and West Hollywood, exhibits consist primarily of post-1940 American and European contemporary art.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 4, CityId = 1, PlaceName = "Griffith Park", Address = "4730 Crystal Springs Dr, Los Angeles, CA 90027, United States", Cost = 40 , Image = Resources.Griffith_Park_Los_Angeles_Hiking_Track, Descriprion = "Griffith Park, jokingly called Los Angeles Central Park (by analogy with New York), covers a fantastic area of ​​1,700 hectares - and it is in the center of one of the largest metropolitan areas in the United States. More than 10 million people visit the park annually. This interest is more than justified: there is a lot of entertainment on the territory - from the observation deck with an excellent view of the textbook inscription Hollywood, to the Greek Amphitheater, observatory, planetarium, golf club and children's attractions.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 5, CityId = 1, PlaceName = "Madame Tussauds Hollywood", Address = "6933 Hollywood Blvd, Hollywood, CA 90028, United States", Cost = 450 , Time = 2 , Image = Resources.madame_tussauds_hollywood, Descriprion = "A popular branch of the London Wax Museum, which is located on Los Angeles Hollywood Boulevard. Residents of the city and tourists come here to look at the sculptures of their favorite actors, famous athletes, famous media figures, singers, comedians, historical figures and politicians.", ImageStorage = new List<ImageStorage>() },

                            new Place() { PlaceId = 6, CityId = 2, PlaceName = "Healing springs in Terpenye", Address = "Terpinnya, Zaporizhia Oblast, 72333", Cost = 400 , Time = 3 , Image = Resources.Healing_springs_in_Terpenye, Descriprion = "The village of Terpenye has three main springs and 12 smaller springs. The main ones are named after the saints - the source of St. Nicholas the Wonderworker destroys all diseases, the source of the Virgin gives health, and the source of Panteleimon heals a variety of diseases: liver, digestion, kidneys.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 7, CityId = 2, PlaceName = "Popov's estate", Address = "Gagarina Street, 12, Vasylivka, Zaporizhia region, 71600", Cost = 100 , Time = 2 , Image = Resources.usadba_popova, Descriprion = "A large-scale manor house (in everyday life Popov's castle) was built in 1864-84. designed by Melitopol architect A. N. Ageenko in the neo-Gothic style for General Vasily Pavlovich Popov. Since 1993, a museum has been organized on the territory of the outbuildings and the horse yard that have survived from the estate.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 8, CityId = 2, PlaceName = "Vasilievsky Zoo", Address = "Stepova Street, 8, Vasylivka, Zaporizhia region, 71600", Cost = 300 , Time = 2 , Image = Resources.vasilievka_zoo, Descriprion = "Be sure to take the Time to visit the unusual town of Vasilyevka. Its main attraction is considered to be an unusual zoo owned by a local resident, a true master of his craft.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 9, CityId = 2, PlaceName = "Zaporizhzhya Sich", Address = " is. Khortytsia, street Old Redoubt 10, Zaporozhye, Zaporozhye region, 69000", Cost = 300 , Time = 4 , Image = Resources.sech, Descriprion = "A unique historical and cultural complex that recreates the image of the Cossack capital and the atmosphere of the times of the Cossacks.", ImageStorage = new List<ImageStorage>() },

                            new Place() { PlaceId = 10, CityId = 3, PlaceName = "Crossroads at Shibuya", Cost = 420 , Time = 3 , Image = Resources._12_Perekrestok_na_Sibuya_e1528915241354, Descriprion = "It is the largest and most famous diagonal crosswalk in Japan. Located in front of Shibuya Station, in the Shibuya Special District, Tokyo. It is one of the most famous diagonal crosswalks in the world. More than 3,000 pedestrians can cross the road at the same time, making it one of the symbols of Tokyo and Japan in general.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 11, CityId = 3, PlaceName = "Asakusa area", Cost = 250 , Time = 2 , Image = Resources._2_Rayon_Asakusa_e1528832886299, Descriprion = "Asakusa is a traditional Tokyo area, least damaged during the bombing of the Second World War. There are many ancient Shinto shrines, which quite often hold lavish festivals - matsuri. The largest and most revered temple of Asakusa is Senso-ji.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 12, CityId = 3, PlaceName = "Akihabara station", Cost = 300 , Time = 5 , Image = Resources._4_Outside_Akihabara_Station_e1528841551644, Descriprion = "Akihabara is best known as one of the largest shopping areas in the world for electronics, computing, anime and otaku goods, including new and used goods. New goods are mainly found on the main street of Chuodori, while old and used ones are found in the back streets of Soto Kanda 3-chome. Many anime shops and otaku restaurants / clubs can be found in the Akihabara area.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 13, CityId = 3, PlaceName = "Emperor Meiji shrine", Address = "1-1 Yoyogikamizonocho, Shibuya City, Tokyo 151-8557, Japan", Cost = 300 , Time = 2 , Image = Resources._10_Hram_imperatora_Meydzi_e1528833104117, Descriprion = "Various items from the reign of the imperial couple are presented here. The Meiji Jingu Outer Garden, located 1.13 km from the Inner Garden, is world renowned as the center of Japanese sports.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 14, CityId = 3, PlaceName = "Happon Garden", Address = "1 Chome-1-1 Shirokanedai, Minato City, Tokyo 108-0071, Japan", Cost = 300 , Time = 2 , Image = Resources._8_Sad_Happoen_e1528833047691, Descriprion = "Usually a rock garden is a flat area, most of which is covered with sand or small pebbles. But the main element is, at first glance, the groups of rough stones chaotically located on it. However, the disorder is only apparent, in fact, the arrangement and composition of stones in groups obey certain rules emanating from the worldview concepts of Zen Buddhism.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 15, CityId = 3, PlaceName = "National Center for the Arts", Address = "7 Chome-22-2 Roppongi, Minato City, Tokyo 106-8558, Japan", Cost = 300 , Time = 3 , Image = Resources.the_national_art_center_tokyo_t2, Descriprion = "Unlike other national museums in Japan, the National Arts Center does not have a permanent exhibition, the museum works on the principle of German museums, the Kunsthalle, which implies holding temporary exhibitions organized by sponsors and other museums.", ImageStorage = new List<ImageStorage>() },


                            new Place() { PlaceId = 16, CityId = 4, PlaceName = "Kyoto National Municipal Museum", Address = "3-1 Kitanomarukoen, Chiyoda City, Tokyo 102-8322, Japan", Cost = 420 , Time = 2 , Image = Resources.kyoto_national_municipal_museum, Descriprion = "A museum dedicated to collecting and preserving works of art and related reference materials of the 20th century, relating to Japan and other countries of the world. Special attention is paid to artists or art movements of Kyoto and the Kansai region.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 17, CityId = 4, PlaceName = "Kyoto International Manga Museum", Address = "452 Kinbukicho, Nakagyo Ward, Kyoto, 604-0846, Japan", Cost = 300 , Time = 3 , Image = Resources._22_Kyoto_International_Manga_Museum, Descriprion = "Having visited Kyoto, you simply cannot pass by the Museum of Manga - legendary Japanese comics, the characters of which amaze us with at least the size of their eyes. In this museum, you can safely take a volume of manga and go to lie on the emerald grass in the courtyard, enjoying the twists and turns of an exciting plot.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 18, CityId = 4, PlaceName = "Bamboo grove", Address = "Ukyo Ward, Kyoto, 616-0007, Japan", Cost = 100 , Time = 4 , Image = Resources._3_Bambukovaya_roshha_Sagano_e1528829507639, Descriprion = "The Sagano Bamboo Forest, also known as the Sagano Bamboo Grove, is a scenic alley of thousands of bamboo trees soaring upward, lined up in neat rows.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 19, CityId = 4, PlaceName = "Kiyomizu-dera shrine", Address = "294 Kiyomizu, Higashiyama Ward, Kyoto, 605-0862, Japan", Cost = 450 , Time = 3 , Image = Resources._4_Hram_Kiyomidzue1528829737668, Descriprion = "The temple complex occupies a vast territory on a picturesque mountainside. There is a small waterfall on the territory of the temple. In one of the main halls there is a sacred Buddha stone, to which one must descend through a tunnel in complete darkness.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 20, CityId = 4, PlaceName = "Kyoto Art University", Address = "2-116 Kitashirakawa Uryuzancho, Sakyo Ward, Kyoto, 606-8271, Japan", Cost = 300 , Time = 2 , Image = Resources.kyoto_university_of_art, Descriprion = "Kyoto University of Art and Design is a private university in Sakyo-ku. It was registered as a junior college in 1977 and became a four-year college in 1991. Many outstanding performing artists remain at the university as permanent faculty members and visiting lecturers.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 21, CityId = 4, PlaceName = "Golden Pavilion", Address = "1 Kinkakujicho, Kita Ward, Kyoto, 603-8361, Japan", Cost = 350 , Time = 1 , Image = Resources._2_Zotoy_pavilon_e1528829317599, Descriprion = "One of the temples in the Rokuon-ji complex in Kita district of Kyoto, Japan. The pavilion was built in 1397 as a holiday villa for the shogun Ashikaga Yoshimitsu, here he spent the last years of his life, having lost all interest in the country's political life.", ImageStorage = new List<ImageStorage>() },

                            new Place() { PlaceId = 22, CityId = 5, PlaceName = "The White house", Address = "1600 Pennsylvania Avenue NW, Washington, DC 20500, United States", Cost = 500 , Time = 4 , Image = Resources.white_house, Descriprion = "Official residence of the President of the United States. Irish architect James Hoban designed the neoclassical residence. Construction took place from 1792 to 1800. The white painted Aquia Creek sandstone was used. In 1801, Thomas Jefferson moved into the house. To hide the stables and vaults, he, along with architect Benjamin Henry Latrobe, added low colonnades to each wing.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 23, CityId = 5, PlaceName = "Washington Monument", Address = "2 15th St NW, Washington, DC 20024, United States", Cost = 300 , Time = 1 , Image = Resources.washington_monument, Descriprion = "Lined with Maryland granite, a granite obelisk 169 meters high and weighing 91 thousand tons. The largest obelisk in the world and the tallest structure in Washington. There is not a single skyscraper in the city itself and, by tradition, none of the buildings can exceed the Washington Monument in height, although there is no specific law on this limitation.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 24, CityId = 5, PlaceName = "National Museum of Aeronautics and Astronautics", Address = "600 Independence Ave SW, Washington, DC 20560, United States", Cost = 480 , Time = 4 , Image = Resources.national_air_and_space_museum, Descriprion = "It is a research center in the history and science of aviation and space flight, as well as planetology, geology and geophysics. Almost all of the museum's exhibits are original historical specimens or their duplicates.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 25, CityId = 5, PlaceName = "Library of Congress", Address = "101 Independence Ave SE, Washington, DC 20540, United States", Cost = 375 , Time = 5 , Image = Resources.library_of_congress, Descriprion = "A research library that officially serves the United States Congress and is the de facto national library of the United States. It is the oldest federal cultural institution in the United States.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 26, CityId = 5, PlaceName = "United States Capitol", Address = "First St SE, Washington, DC 20004, United States", Cost = 800 , Time = 2 , Image = Resources.united_states_capitol, Descriprion = "The seat of the US Congress on Capitol Hill in Washington DC, the ideological and urban center of the District of Columbia. Connects to the Washington Monument and Lincoln Memorial by the 1800-meter National Mall. To the east of the parliamentary center is the Library of Congress.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 27, CityId = 5, PlaceName = "Lincoln Memorial", Address = "2 Lincoln Memorial Cir NW, Washington, DC 20002, United States", Cost = 40 , Image = Resources.lincoln_memorial, Descriprion = "A memorial complex located on the National Mall in downtown Washington. It was built in honor of the sixteenth President of the United States, Abraham Lincoln. His presidency fell on the years of the Civil War (1861-1865). The memorial, erected in 1914-1922, symbolizes Lincoln's belief that all people should be free.", ImageStorage = new List<ImageStorage>() },


                            new Place() { PlaceId = 28, CityId = 6, PlaceName = "Ice hotel", Address = "Lehtoahontie 31, 97220 Rovaniemi, Finland", Cost = 1540 , Time = 24 , Image = Resources.ice_hotel, Descriprion = "The first ice hotel in the world was the Icehotel in the village of Jukkasjärvi, about 17 km from Kiruna, Sweden; it is built every year from December to April. In 1989, Japanese ice painters visited the area and opened an exhibition of ice art. In the spring of 1990, the French artist Jean Deri held an exhibition of the cylindrical igloo in this area. One night there were no hotel rooms available in the city, so some of its visitors asked for permission to spend the night in the exhibition hall. They slept in deerskin sleeping bags and became the first guests of the hotel to stay overnight.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 29, CityId = 6, PlaceName = "Santa park", Address = "Tarvantie 1, 96930 Rovaniemi, Finland", Cost = 600 , Time = 4 , Image = Resources.Santa_park, Descriprion = "Not far from the village of Santa there is a wonderful place - Santa Park, where favorite winter holidays continue all year round, where elves sing, children laugh, and the air is saturated with the smell of spices.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 30, CityId = 6, PlaceName = "Santa Claus village", Address = "96930 Rovaniemi, Finland", Cost = 300 , Time = 5 , Image = Resources.santa_klaus_village, Descriprion = "An amusement park in Finland dedicated to the Christmas grandfather, who in Finland is called Joulupukki (Finn. Joulupukki), and in English-speaking countries - Santa Claus. Located near the city of Rovaniemi in the Lapland province. Traditionally, it is believed that Santa Claus was born in Lapland. Santa Claus Village is considered to be the immediate residence of Santa Claus, and therefore is one of the most visited tourist destinations in Finland.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 31, CityId = 6, PlaceName = "Ranua Zoo", Address = "Rovaniementie 29, 97700 Ranua, Finland", Cost = 300 , Time = 4 , Image = Resources.ranua_zoo, Descriprion = "The park is home to about 60 species of representatives of the northern fauna. The sightseeing route is designed in such a way that all animals and birds are encountered sequentially, in conditions close to natural.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 32, CityId = 6, PlaceName = "Lapland Bridge", Address = "Utsjoentie, 99980 Utsjoki, Finland", Cost = 30 , Image = Resources.yatkankyuntyllya_bridge, Descriprion = "Lapland Bridge was opened in 1993. Due to the fact that the bridge is located on the border between the two states, two road departments are involved in its support at once: the Norwegian State Road Administration and the Finnish Transport Agency.", ImageStorage = new List<ImageStorage>() },
                            new Place() { PlaceId = 33, CityId = 6, PlaceName = "Pilke Museum", Address = "Ounasjoentie 6, 96200 Rovaniemi, Finland", Cost = 420 , Time = 5 , Image = Resources.pilke_museum, Descriprion = "Scientific center for the study of the regions of the North. A museum dedicated to the history, traditions and culture of the northern peoples.", ImageStorage = new List<ImageStorage>() }

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