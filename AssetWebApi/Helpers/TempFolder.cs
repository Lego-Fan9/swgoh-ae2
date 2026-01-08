namespace AssetWebApi.Helpers
{
    public class TempFolder : IDisposable
    {
        public string Folder { get; }

        public TempFolder(string workingDirectory)
        {
            Folder = Path.Combine(workingDirectory, Guid.NewGuid().ToString());
            Directory.CreateDirectory(Folder);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (Directory.Exists(Folder) && disposing)
                {
                    Directory.Delete(Folder, true);
                }
            } 
            catch(Exception ex) 
            {
                    Console.WriteLine($"Could not delete temp folder {Folder} for reason {ex.Message}");
            }

        }
    }
}