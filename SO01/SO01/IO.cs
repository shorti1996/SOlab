using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO01
{
    class IO
    {
        /*
        public bool ReadProcessFromFile(string filename)
        {
            //try to open the file
            StreamReader reader;
            try
            {
                filename = System.IO.Path.Combine("Files\\" + filename);
                path = filename;
                reader = new StreamReader(filename);
            }
            catch (Exception)
            {   //could not read the file
                return false;
            }

            //read the map size
            string[] size;
            size = reader.ReadLine().Split(' ');
            if (!int.TryParse(size[0], out width))
                return false;
            if (!int.TryParse(size[1], out height))
                return false;

            //create entity colleciton acording readed map size
            EntityList = new MapObject[Width, Height];

            //read map entities and add them to the map component array
            for (int i = 0; i < Height; i++)
            {
                string line = reader.ReadLine();
                for (int j = 0; j < Width; j++)
                    CreateComponent(line[j], j, i);
            }

            //map has been loaded
            reader.Close();
            return true;
        }*/
    }
}
