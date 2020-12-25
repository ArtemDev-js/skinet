using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 50;

        public int PageIndex { get; set; } = 1; //by default API will return the first page

        private int _pageSize = 6;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value; 
            //if value is bigger we will return MaxPageSize, if not that we will returm value.
        }

        public int? BrandId { get; set; }  //int? meant this parameter is optional
        public int? TypeId { get; set; }

        public string Sort { get; set; }

        private string _search;
        public string Search 
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }
}
