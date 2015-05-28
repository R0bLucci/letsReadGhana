using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsReadGhana
{
    static class Game
    { 

        /*
        PRIVATE MEMBERS
        */


        // random algorithm to shuffle any array i pass as paramenter
        private static string[] _shuffleLettersAndSoundsEngine(string[] arr)
        {
            Random rnd = new Random(); // Instanciate Random class to create object of type Random 
            arr = arr.OrderBy((anyParameter) => rnd.Next()).ToArray(); //Lambda expression 
            return arr; //return shuffled array 
        }

        // Fisher-Yates algorithm to shuffle arrays 
        private static string[] _shuffleItemsEngine(string[] arr)
        {
            Random random = new Random(); // Instanciate Random class to create object of type Random
            int numberOfElements = arr.Length; // store number of elements of array
            for (int i = 0; i < numberOfElements; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                int r = i + (int)(random.NextDouble() * (numberOfElements - i)); // generate random index
                string temp = arr[r]; // store random index position value       
                arr[r] = arr[i]; // take array at the random index and swap it for the value of the index position of the for loop
                arr[i] = temp; // target index position in the loop and put the  temp value into it 
            }
            return arr; // return shuffled array
        }

        // return directory path of the executable (.exe)
        private static string _appRoot()
        {
            return System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath); // retrieve .exe directory path
        }

        // return list of all file names in the letters folder
        private static string[] _getLettersFilePathName()
        {
            return System.IO.Directory.GetFiles(_appRoot() + @"\images\letters"); // retrieve files name from letters folder into a string array
        }

        // return list of all file names in the items folder
        private static string[] _getItemsFilePathName()
        {
            return System.IO.Directory.GetFiles(_appRoot() + @"\images\items"); // retrieve files name from items folder into a string array
        }

        // return file paths list of all sound files in the sound folder
        private static string[] _getSoundsFilePathList()
        {
            return System.IO.Directory.GetFiles(_appRoot() + @"\sound"); // get and return file path of each sound file (.wav)
        }



        /*
         PUBLIC MEMBERS
         */

        // combo method to get and shuffle letters and sound arrays
        public static string[] lettersAndSoundsArrayShuffler(string[] arr, bool isLettersArray, bool toShuffle)
        {
            if (toShuffle && isLettersArray) // if it is letters array and needs to be shuffled
            {
                arr = Game._getLettersFilePathName();
                arr = Game._shuffleLettersAndSoundsEngine(arr);
            }
            else if (toShuffle && isLettersArray == false) // if it is sounds array and needs to be shuffled 
            {
                arr = Game._getSoundsFilePathList();
                arr = Game._shuffleLettersAndSoundsEngine(arr);
            }
            else if(toShuffle == false && isLettersArray) // if it is letters array and does not need to be shuffled 
            {
                arr = Game._getLettersFilePathName();
            }
            else if(toShuffle == false && isLettersArray == false) // if it is sounds array and does not need to be shuffled
            {
                arr = Game._getSoundsFilePathList();
            }

            return arr;
        }

        // combo method to get and shuffle items array 
        public static string[] itemsArrayShuffler(string[] arr, bool shuffle = true)
        {
            if (shuffle)
            {
                arr = Game._getItemsFilePathName(); // get list of item
                arr = Game._shuffleItemsEngine(arr); // randomize or shuffle list of item images
            }
            else
            {
                arr = Game._getItemsFilePathName(); // get list of item
            } 
            return arr;
        }

        // return string name of a single file in the letters folder
        public static string letterName(string[] img, int index)
        {
            System.IO.FileInfo info = new System.IO.FileInfo(img[index]); // instanciate FileInfo class with overloaded constructor to get file name in the letters folder
            return info.Name.Replace(".png", "").ToString(); //remove file extention from file name
        }

        // return string name of a single file in the items folder
        public static string itemName(string[] img, int index) 
        {
            System.IO.FileInfo info = new System.IO.FileInfo(img[index]); //  instanciate FileInfo class with overloaded constructor to get file name in the items folder
            return info.Name.Replace(".png", "").ToString(); //remove file extention from file name
        }

        //return one file path 
        public static string soundPathName(int index)
        {                                                     // save list of sound file path into public variable 
             return Game._getSoundsFilePathList()[index].ToString(); // return string of one file path  
        }
    }
}
