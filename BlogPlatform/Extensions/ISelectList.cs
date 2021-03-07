using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Extensions
{
    public interface ISelectList
    {
        List<Category> PopulateCategoryList();
    }
}
