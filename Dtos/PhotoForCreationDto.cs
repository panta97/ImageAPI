using Microsoft.AspNetCore.Http;

namespace ImageAPI.Dtos
{
    public class PhotoForCreationDto
    {
        public IFormFile File { get; set; }
        public string PublicId { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }

    }
}