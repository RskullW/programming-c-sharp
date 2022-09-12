using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class ManagerFiles
    {
        public event Action OnAutoSave;
        private Task _pointTask;
        private CancellationTokenSource _tokenSource;
        private CancellationToken _cancellationToken;

        private int _autoSaveTime;
        private Queue<Animal> _animals;
        private string _pathToFile;
        private BinaryReader _binaryReader;
        private BinaryWriter _binaryWriter;
        public string PathToFile => _pathToFile;


        public ManagerFiles()
        {
            _autoSaveTime = 60000; // 60000 = 1 minute
            
            _animals = new Queue<Animal>();
            Display("Enter the path to the file:");
            _pathToFile = Console.ReadLine() ?? "ListAnimals.bin";

            _binaryReader = new BinaryReader(File.Open(_pathToFile, FileMode.OpenOrCreate));
        }
        public Queue<Animal> GetAnimals()
        {
            return _animals;
        }
        public void SetAnimals(Queue<Animal> animals)
        {
            _animals = animals;
        }
        public void SaveFile()
        {
            Display("File was saved...");
            WriteData();
        }
        public void CloseManager()
        {
            if (_tokenSource != null)
            {
                _tokenSource.Cancel();
            }
            
            CloseStreams();
        }
        public void ReadFile()
        {
            while (_binaryReader.PeekChar() > -1)
            {
                var name = _binaryReader.ReadString();
                var naturalZone = _binaryReader.ReadString();
                var expenses = _binaryReader.ReadSingle();
                
                _animals.Enqueue(new Animal(name, naturalZone, expenses));
            }
            
            _binaryReader.Close();
        }
        public void StartAutoSave()
        {
            if (_pointTask == null || _pointTask.Status == TaskStatus.RanToCompletion)
            {
                _tokenSource = new CancellationTokenSource();
                _cancellationToken = _tokenSource.Token;
                _pointTask = StartAutomaticFileSaving(_cancellationToken);
            }
        }
        public void Display<T>(T message) 
        {
            Console.WriteLine(message);
        }
        private async Task StartAutomaticFileSaving(CancellationToken cancellationToken)
        {
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
                
                OnAutoSave?.Invoke();
                
                WriteData();
                Display("The file is automatically saved...");
                await Task.Delay(_autoSaveTime);
            }
        }
        private void WriteData()
        {
            File.Delete(_pathToFile);
            
            _binaryWriter = new BinaryWriter(File.Open(_pathToFile, FileMode.Create));

            foreach (var animal in _animals)
            {
                _binaryWriter.Write(animal.Name);
                _binaryWriter.Write(animal.NaturalZone);
                _binaryWriter.Write(animal.Expenses);
            }
            
            _binaryWriter.Close();
        }
        private void CloseStreams()
        {
            WriteData();
            
            _binaryWriter.Close();
            _binaryReader.Close();
        }
    }
}