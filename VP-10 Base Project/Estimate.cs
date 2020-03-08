using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VP_10_Base_Project
{
    class Estimate
    {
        public int amount { get; set; } 
        public string category { get; set; } 
        public string description { get; set; }
        public string format { get; set; }
        public float price { get; set; }
        public Image image { get; set; }
        public string link { get; set; }
        public Estimate(int _amount, string _category, string _description, float _price, string _format, Image _image, string _link)
        {
            this.amount = _amount;
            this.category = _category;
            this.description = _description;
            this.price = _price;
            this.format = _format;
            this.image = _image;
            this.link = _link;
        }
    }
}
