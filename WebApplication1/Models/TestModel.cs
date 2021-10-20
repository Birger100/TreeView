using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public List<TreeViewModel> TreeViewModels { get; set; }
        public string SelectedValues { get; set; }
    }
}