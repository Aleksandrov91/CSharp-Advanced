﻿using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Export
{
    [XmlType("Category")]
    public class CategoryDto
    {
        public string Name { get; set; }

        [XmlElement("MostPopularItem")]
        public ItemDto MostPopularItem { get; set; }
    }
}
