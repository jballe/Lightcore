using System;

namespace Lightcore.Server.Models
{
    public class FieldModel
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}