using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BingImageDownloader.Model
{
    public partial class BingResult
    {
        [JsonProperty("images")]
        public Image[] Images { get; set; }        
    }

    public partial class Image
    {
        [JsonProperty("url")]
        public string Url { get; set; }        
    }
}
