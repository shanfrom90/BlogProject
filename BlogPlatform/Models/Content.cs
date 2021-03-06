using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {   
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty { get; set; }
        public virtual Category Category { get; set; }
        //may need to add Display Annotation-select Category
        public int CategoryId { get; set; }
    }
}
