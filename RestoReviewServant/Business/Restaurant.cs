using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace RestoReviewService.Business
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Restaurant
    {
        private int _id;
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _mainOffice;
        [DataMember]
        public string MainOffice
        {
            get { return _mainOffice; }
            set { _mainOffice = value; }
        }

        private string _description;
        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}