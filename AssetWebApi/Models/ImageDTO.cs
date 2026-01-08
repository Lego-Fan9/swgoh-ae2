using SpirV;

namespace AssetWebApi.Models
{
    public class ImageDTO
    {
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = "image/png";
        public string Data { get; set; } = string.Empty;
        public string FromAtlas { get; set; } = string.Empty;
        public bool IsValid { get; set; } = false;
    }

    public class ImageListDTO
    {
        public ImageListDTO(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; } = string.Empty;
        public List<ImageDTO> Images {  get; set; } = new List<ImageDTO>();
    }
}