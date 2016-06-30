using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the rental dates for each type via a static field
            //implement

            //create a list a propulate it with the date in our file
            FileIO getFile = new FileIO();

            //populate mediaToRent with the values returned from getFile instead of an empty list e.g. "new List<string>();"
            //implement


            List<string> mediaToRent = getFile.ReturnMediaFile(@"..\..\media.txt");

            //create a new list for us to use to store our media objects to rent
            List<Media> rentedMedia = new List<Media>();

            //for each line from the rental 
            foreach (string s in mediaToRent)
            {
                //match each needed component
                //populae with your regex to match the format

                Match match = Regex.Match(s, @"^Type: *(.*),Title: *(.*),Length: *([\w ]*)$");
                if (match.Success)
                {
                    //populate each component with the values from your capture groups
                    string type = match.Groups[1].ToString();
                    string title = match.Groups[2].ToString();
                    string length = match.Groups[3].ToString();

                    //using the components we got figure out which type of object we should create and insert
                    if (type.Equals("Book"))
                    {
                        Book newBook = new Book();
                        newBook.Title = title;
                        newBook.Length = length;
                        rentedMedia.Add(newBook);

                        //create a book object
                        //populate the book object with a title and length
                        //then add the newly created book to rentedMedia
                    }
                    if (type.Equals("DVD"))
                    {
                        DVD newDVD = new DVD();
                        newDVD.Title = title;
                        newDVD.Length = length;
                        rentedMedia.Add(newDVD);

                        //create a book object
                        //populate the book object with a title and length
                        //then add the newly created book to rentedMedia
                    }
                    if (type.Equals("Magazine"))
                    {
                        Magazine newMagazine = new Magazine();
                        newMagazine.Title = title;
                        newMagazine.Length = length;
                        rentedMedia.Add(newMagazine);

                        //create a book object
                        //populate the book object with a title and length
                        //then add the newly created book to rentedMedia
                    }
                    //complete for the DVD and Magazine media types
                    //implement
                }
            }

            //for each media item we have in the list print the details for each
            foreach (Media mediaItem in rentedMedia)
            {

                mediaItem.PrintMediaDetails();
                //for each mediaItem call PrintMediaDetails()
                //implement
            }

            //halt the program so we can read the output
            Console.ReadKey();
        }
    }
}
