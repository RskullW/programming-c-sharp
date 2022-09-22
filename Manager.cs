using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Manager
    {
        private bool _isOpenedFile;
        private FileManager _fileManager;
        private StringBuilder[] _stringBuilders;
        private Dictionary<string, uint> _dictionaryString;
        private string _path;

        public Manager()
        {
            _isOpenedFile = false;
            _dictionaryString = new Dictionary<string, uint>();
        }

        public void OpenMenu()
        {
            ushort itemMenu = 0;

            while (itemMenu != 5)
            {
                DisplayMenu();
                
                itemMenu = ushort.Parse(Console.ReadLine() ?? throw new Exception("Error! Not correct item menu!"));

                switch (itemMenu)
                {
                    case 1: OpenFile(); break;
                    case 2: FindNumberOfWords(); break;
                    case 3: SortedFile(); break;
                    case 4: LeaveTenWords(); break;
                    case 5: CloseFile(); break;
                    
                    default: throw new Exception("Error! Not correct item menu");
                }
                
                StartPause();
            }

        }

        private void SortDictionary()
        {
            _dictionaryString = _dictionaryString.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        private void OpenFile()
        {
            if (_isOpenedFile)
            {
                throw new Exception("Error! The file was opened!");
            }

            
            int index = 0;
            _isOpenedFile = true;

            _fileManager = new FileManager(EnterPath(), true);
            _stringBuilders = new StringBuilder[FindNumberOfWords()];
            
            for (uint i = 0; i < _stringBuilders.Length; ++i)
            {
                _stringBuilders[i] = new StringBuilder(255);
                _fileManager.ReadFile(index++, _stringBuilders[i]);
                
                if (!_dictionaryString.ContainsKey(_stringBuilders[i].ToString()))
                {
                    _dictionaryString.Add(_stringBuilders[i].ToString(), 0);
                }

                else
                {
                    _dictionaryString[_stringBuilders[i].ToString()]++;
                }
            }
            
            SortDictionary();
        }

        private int FindNumberOfWords()
        {
            if (!_isOpenedFile)
            {
                throw new Exception("Error! The file not was opened!");
            }
            
            Display("\nMaximum number of words in file = " + _fileManager.GetLength());

            return _fileManager.GetLength();
        }

        private void SortedFile()
        {
            if (!_isOpenedFile)
            {
                throw new Exception("Error! The file not was opened!");
            }

            LocalClosedAndOpenFile();

            StringBuilder text = new StringBuilder(255);

            for (uint i = 0; i < _stringBuilders.Length; ++i)
            {
                text.Append(_stringBuilders[i]+" ");
            }

            var words = string.Join(" ", text.ToString().Split().OrderBy(x => x));

            _fileManager.WriteFile(words);
            
            LocalClosedAndOpenFile(true);
        }
        
        private void LeaveTenWords()
        {
            if (!_isOpenedFile)
            {
                throw new Exception("Error! The file not was opened!");
            }
            
            LocalClosedAndOpenFile();

            ushort index = 1;
            
            string text = "";

            foreach (var word in _dictionaryString)
            {
                text += word.Key + " ";
                index++;

                if (index >= 10)
                {
                    break;
                }
            }
            
            _fileManager.WriteFile(text);

            LocalClosedAndOpenFile(true);
        }

        private void CloseFile()
        {
            if (_isOpenedFile)
            {
                Display("\nDispose");
                _fileManager.Dispose();
            }
        }
        
        private string EnterPath()
        {
            
            Display("Enter path in file: ");
            _path = Console.ReadLine();
            
            return _path;
        }
        private void StartPause()
        {
            Display("\nEnter any character to continue");
            var temp = Console.ReadLine();
            Console.Clear();
        }
        private void DisplayMenu()
        {
            Display("1. Open file");
            Display("2. Find number of words in file");
            Display("3. Sorted file");
            Display("4. Leave 10 words");
            Display("5. Close file");
        }
        public static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private void LocalClosedAndOpenFile(bool read = false)
        {
            _fileManager.Dispose();
            _fileManager = new FileManager(_path, read);
        }
    }
}