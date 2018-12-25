namespace ScopeCards.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Card
    {
        [Key]
        public int card_serial_number { get; set; }
        public List<int> interventions { get; set; }
        public string compressQR { get; set; }
        public string pin_number { get; set; }
        public string card_profile { get; set; }
        public Recipient recipient { get; set; }
        public List<Alternates> alternates { get; set; }
        public string household_uuid { get; set; }
        public string household_id { get; set; }
        public string qr_code { get; set; }
        public string household_name { get; set; }
        public string location { get; set; }
        public string card_number { get; set; }

        public class Recipient
        {
            public string picture { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string middle_name { get; set; }
            public string gender { get; set; }
            public string document_number { get; set; }
            public List<Fingerprints> fingerprints { get; set; }
            public string birthdate { get; set; }
            public string document_type { get; set; }
            public string bank_account { get; set; }
        }

        public class Alternates
        {
            public string picture { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string middle_name { get; set; }
            public string gender { get; set; }
            public string document_number { get; set; }
            public List<Fingerprints> fingerprints { get; set; }
            public string birthdate { get; set; }
            public string document_type { get; set; }
            public string bank_account { get; set; }
        }

        public class Fingerprints
        {
            public string code { get; set; }
            public string finger { get; set; }
            public string hand { get; set; }

        }

        //public List<int> interventions { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual List<recipient> recipient { get; set; }


    }
}
