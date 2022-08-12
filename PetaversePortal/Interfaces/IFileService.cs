namespace PetaversePortal.Interfaces
{
    public interface IFileService
    {
        Task<FileResult?> OpenCameraAsync();
        Task<FileResult?> OpenFilePickerAsync();
    }
}
