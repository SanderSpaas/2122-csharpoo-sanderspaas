namespace SpyfallProject.presentatielaag
{
    internal class FilePicker
    {
        public FilePicker()
        {
        }

        public string FileSelector()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                return openFileDialog.FileName;
            }
            return @"datalaag\SpyfallData.csv";
        }

        public string OpenSaveDialog()
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            else return null;

        }
    }
}
