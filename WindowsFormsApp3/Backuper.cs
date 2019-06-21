using System;
using System.IO;


namespace WindowsFormsApp3
{
    public class Backuper
    {
        public string SourceDirectory { get; set; }
        public string DestinationDirectory { get; set; }
        public Boolean AutomaticOrManual { get; set; }
        public int ProgressPercentage { get; set; }
        public uint BackupInterval { get; set; }
        public string TracebilityComputerName { get; set; }

        public Backuper(string TracebilityComputerName)
        {
            this.TracebilityComputerName = TracebilityComputerName;
        }

        public void CopyFiles(IProgress<int> progress, IProgress<string> progress2)
        {
            //const string Src_FOLDER = @"C:\Users\ts-575\TransferFiles\Source";
            //const string Dest_FOLDER = @"C:\Users\ts-575\TransferFiles\Destination";
            
            string[] originalFiles = Directory.GetFiles(SourceDirectory, "*", SearchOption.AllDirectories);
            string[] destineFiles = Directory.GetFiles(DestinationDirectory, "*", SearchOption.AllDirectories);
            if (originalFiles.Length >= destineFiles.Length)
            {
                Array.ForEach(originalFiles, (originalFileLocation) =>
                {
                    ///originalFileLocation is treated as an item inside the "originalFile" array and originalFileLocation is just a directory
                    ///You can try to log this out: Console.WriteLine(originalFileLocation);
                    FileInfo originalFile = new FileInfo(originalFileLocation);
                    FileInfo destFile = new FileInfo(originalFileLocation.Replace(SourceDirectory, DestinationDirectory));

                    if (destFile.Exists)
                    {
                        if (originalFile.Length > destFile.Length)
                        {
                            //originalFile.CopyTo(destFile.FullName, true);
                            progress2.Report(originalFile.ToString());
                            originalFile.CopyTo(destFile, x => { progress.Report(x);Console.WriteLine(x); });
                            
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(destFile.DirectoryName);
                        //originalFile.CopyTo(destFile.FullName, false);
                        progress2.Report(originalFile.ToString());
                        originalFile.CopyTo(destFile, x => { progress.Report(x); Console.WriteLine(x); });
                        Console.WriteLine("File Copied.");
                    }
                });
            }

            else
            {
                Array.ForEach(destineFiles, (destineFileLocation) =>
                {
                    ///originalFileLocation is treated as an item inside the "originalFile" array and originalFileLocation is just a directory
                    ///You can try to log this out: Console.WriteLine(originalFileLocation);
                    FileInfo destFile = new FileInfo(destineFileLocation);
                    FileInfo originalFile = new FileInfo(destineFileLocation.Replace(DestinationDirectory, SourceDirectory));

                    if (originalFile.Exists)
                    {
                        if (originalFile.Length != destFile.Length)
                        {
                            //originalFile.CopyTo(destFile.FullName, true);
                            progress2.Report(originalFile.ToString());
                            originalFile.CopyTo(destFile, x => { progress.Report(x); Console.WriteLine(x); });
                            Console.WriteLine("File Copied.");
                            progress.Report(100);
                        }
                    }
                    else
                    {

                        destFile.Delete();
                    }
                });
            }
        }


        public void CreateTraceList()
        {

        }

        public void GetProgress()
        {

        }

        public void OperateManually()
        {

        }

        public void OperateAutomatically()
        {

        }
    }
}
