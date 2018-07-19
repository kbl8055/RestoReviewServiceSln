using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestoReviewService.Business
{
    [DataContract]
    public class Ingredient
    {
        private int id;
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal price;
        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string unitOfMeasure;
        [DataMember]
        public string UnitOfMeasure
        {
            get { return unitOfMeasure; }
            set { unitOfMeasure = value; }
        }

        public string UOM { get; set; }

        // TODO: Setup the Category relationship
        [DataMember]
        public int CategoryId { get; set; }
        //[DataMember]
        public Category Category { get; set; }
    }
}