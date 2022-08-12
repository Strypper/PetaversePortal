using PetaversePortal.Interfaces;

namespace PetaversePortal.Services
{
    public class FileService : IFileService
    {
        public async Task<FileResult?> OpenCameraAsync()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                    await sourceStream.CopyToAsync(localFileStream);
                    return photo;
                }
                else return null;
            }
            else return null;
        }

        public async Task<FileResult?> OpenFilePickerAsync()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions());
                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                    await sourceStream.CopyToAsync(localFileStream);
                    return photo;
                }
                else return null;
            }
            else return null;
        }
    }
}
