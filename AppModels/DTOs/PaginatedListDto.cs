using BookWebApi.AppCommons;
using System.Collections.Generic;

namespace BookWebApi.AppModels.DTOs
{
    public class PaginatedListDto<T>
    {
        public PageMeta MetaData { get; set; }
        public IEnumerable<T> Data { get; set; }
        public PaginatedListDto()
        {
            Data = new List<T>();
        }
    }
}
