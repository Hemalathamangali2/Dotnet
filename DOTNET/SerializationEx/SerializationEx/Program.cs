using System.Buffers.Binary;
using System.IO;

namespace SerializationEx
{
    class Program
    {
        public int ID;
        public string Name;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ID = 1;
            obj.Name = ".Net";

            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter writer = new BinaryWriter(stream)
;
                writer.Write(obj.ID);
                writer.Write(obj.Name);

                // Get the binary data
                byte[] binaryData = stream.ToArray();

                // To deserialize:
                using (MemoryStream readStream = new MemoryStream(binaryData))
                {
                    BinaryReader reader = new BinaryReader(readStream);
                    Program deserializedObj = new Program();
                    deserializedObj.ID = reader.ReadInt32();
                    deserializedObj.Name = reader.ReadString();
                }
            }
        }
    }
}

