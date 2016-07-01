using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                mediaFile = File.ReadLines(path).ToList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
                //write out appropriate message
                    //implement
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //write out the message of e
                    //implement
            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
