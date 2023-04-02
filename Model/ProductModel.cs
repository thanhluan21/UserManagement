using System;

namespace UserManagement.Model
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
        public string NumberOf { get; set; }

        public DateTime DateAdd { get; set; }
    }
}
