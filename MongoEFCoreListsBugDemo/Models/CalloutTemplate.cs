using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoEFCoreListBugDemo.Models
{
    public class CalloutTemplate
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public bool inheritFromCallout { get; set; }
        public List<CallRound> callRounds { get; set; }
        public Qualifier qualifiers { get; set; }
    }
    public class CallRound
    {
        public List<CollectionReference>? jobQualifiers { get; set; }
        public bool isOvertime { get; set; }
        public bool offerOrientedOnly { get; set; }
        public string genderRequirements { get; set; }

    }
    public class Qualifier
    {
        public ObjectId worksiteId { get; set; }
        public ObjectId jobClassificationId { get; set; }
        public List<CollectionReference> jobQualifiers { get; set; }
        public string genderRequirements { get; set; }
    }



}
