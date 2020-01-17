using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EventsMobile.Models

{
    public class Fbo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Epc { get; set; } = string.Empty;

        public bool IsCheckedIn { get; set; } = false;

        public string ControlId { get; set; }

        public string FboId { get; set; } = string.Empty;

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string LanguageCode { get; set; }

        public string CountryCode { get; set; }

        public string BadgeFirstName { get; set; }

        public string BadgeSurname { get; set; }

        public string BadgeCountryCode { get; set; }

        public string PassportNumber { get; set; }

        public long ChequeId { get; set; } = 0;

        public int GroupId { get; set; }

        public int TierId { get; set; }

        public int? PartnershipId { get; set; }

        public long? SiteCode { get; set; }

        public bool IsSpeaker { get; set; }

        public bool IsTranslator { get; set; }

        public bool IsNotificationEmailSent { get; set; }

        public int EagleCaps { get; set; }

        public string Name => $"{Forename} {Surname}";

        public bool IsPersonOfInterest => IsSpeaker || IsTranslator;

        //-START-JOP-Fri-15-Feb-2019
        public string ChequeCollectionBy { get; set; } = string.Empty;
        public string ChequeTimeSlot { get; set; } = string.Empty;

        //-START-JOP-Mon-18-Feb-2019
        public int HeadsetsIssued { get; set; } = 0;
        public int HeadsetReturned { get; set; } = 0;

    }
}
