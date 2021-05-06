namespace Database.Models
{
    public class ImageStorage
    {
        public int ID { get; set; }

        public byte[] Image { get; set; }

        public int PlaceID { get; set; }

        public Place Place { get; set; }
    }
}