using System.IO;

namespace Database.Helpers
{
    public static class ImageConverter
    {
        public static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(MyDBContext)).Location;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(Path.Combine(fullPath, sPath));
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes 
            //to read from file.
            //In this case we want to read entire file. 
            //So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);

            return data;
        }
    }
}