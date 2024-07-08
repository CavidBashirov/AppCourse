using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Admin.Books
{
    public class BookDto
    {
        public string Name { get; set; }
        public List<string> Authors { get; set; }
    }
}
