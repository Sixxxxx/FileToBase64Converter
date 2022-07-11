using Microsoft.AspNetCore.Http;

namespace FileToBase64Converter
{
    public static class FileConverter
    {
        public static string ConvertToBase64(IFormFile file)
        {
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    return Convert.ToBase64String(fileBytes);
                }
            }
            return null;
        }
    }
}