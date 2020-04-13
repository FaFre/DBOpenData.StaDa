/* 
 * Stationsdatenbereitstellung
 *
 * An API providing master data for German railway stations by DB Station&Service AG.
 *
 * The version of the OpenAPI document: 2.2.01
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Station
    /// </summary>
    [DataContract]
    public partial class Station :  IEquatable<Station>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets HasSteplessAccess
        /// </summary>
        [DataMember(Name="hasSteplessAccess", EmitDefaultValue=false)]
        public Partial? HasSteplessAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Station" /> class.
        /// </summary>
        /// <param name="number">unique identifier representing a specific railway station.</param>
        /// <param name="name">the stations name.</param>
        /// <param name="mailingAdress">mailingAdress.</param>
        /// <param name="category">the stations category (-1...7). Stations with category -1 or 0 are not in production, e.g. planned, saled, without train stops..</param>
        /// <param name="priceCategory">determines in some respect the price for train stops at a specific station (1..7).</param>
        /// <param name="federalState">german federal state.</param>
        /// <param name="hasParking">public parking y/n.</param>
        /// <param name="hasBicycleParking">public bicycle parking y/n.</param>
        /// <param name="hasPublicFacilities">public facilities y/n.</param>
        /// <param name="hasLockerSystem">public facilities y/n.</param>
        /// <param name="hasLocalPublicTransport">local public transport y/n.</param>
        /// <param name="hasTaxiRank">taxi rank in front of the station y/n.</param>
        /// <param name="hasTravelNecessities">a shop for travel necessities y/n.</param>
        /// <param name="hasSteplessAccess">hasSteplessAccess.</param>
        /// <param name="hasMobilityService">values are &#39;no&#39;, &#39;yes, advance notification is requested...&#39; or &#39;yes, advance notification is required...&#39;.</param>
        /// <param name="hasWiFi">public Wi-Fi is available y/n.</param>
        /// <param name="hasTravelCenter">local travel center y/n.</param>
        /// <param name="hasRailwayMission">railway mission y/n.</param>
        /// <param name="hasDBLounge">DB lounge y/n.</param>
        /// <param name="hasLostAndFound">lost and found y/n.</param>
        /// <param name="hasCarRental">car sharing or car rental y/n.</param>
        /// <param name="evaNumbers">station related EVA-Numbers.</param>
        /// <param name="riL100Identifiers">station related Ril100s.</param>
        /// <param name="timetableOffice">timetableOffice.</param>
        /// <param name="stationManagement">stationManagement.</param>
        /// <param name="localServiceStaff">localServiceStaff.</param>
        /// <param name="dBinformation">dBinformation.</param>
        /// <param name="regionalbereich">regionalbereich.</param>
        /// <param name="szentrale">szentrale.</param>
        /// <param name="aufgabentraeger">aufgabentraeger.</param>
        public Station(int number = default(int), string name = default(string), Address mailingAdress = default(Address), int category = default(int), int priceCategory = default(int), string federalState = default(string), bool hasParking = default(bool), bool hasBicycleParking = default(bool), bool hasPublicFacilities = default(bool), bool hasLockerSystem = default(bool), bool hasLocalPublicTransport = default(bool), bool hasTaxiRank = default(bool), bool hasTravelNecessities = default(bool), Partial hasSteplessAccess = default(Partial), string hasMobilityService = default(string), bool hasWiFi = default(bool), bool hasTravelCenter = default(bool), bool hasRailwayMission = default(bool), bool hasDBLounge = default(bool), bool hasLostAndFound = default(bool), bool hasCarRental = default(bool), List<EVANumber> evaNumbers = default(List<EVANumber>), List<RiL100Identifier> riL100Identifiers = default(List<RiL100Identifier>), TimetableOffice timetableOffice = default(TimetableOffice), StationManagementRef stationManagement = default(StationManagementRef), Schedule localServiceStaff = default(Schedule), Schedule dBinformation = default(Schedule), RegionalBereichRef regionalbereich = default(RegionalBereichRef), SZentraleRef szentrale = default(SZentraleRef), Aufgabentraeger aufgabentraeger = default(Aufgabentraeger))
        {
            this.Number = number;
            this.Name = name;
            this.MailingAdress = mailingAdress;
            this.Category = category;
            this.PriceCategory = priceCategory;
            this.FederalState = federalState;
            this.HasParking = hasParking;
            this.HasBicycleParking = hasBicycleParking;
            this.HasPublicFacilities = hasPublicFacilities;
            this.HasLockerSystem = hasLockerSystem;
            this.HasLocalPublicTransport = hasLocalPublicTransport;
            this.HasTaxiRank = hasTaxiRank;
            this.HasTravelNecessities = hasTravelNecessities;
            this.HasSteplessAccess = hasSteplessAccess;
            this.HasMobilityService = hasMobilityService;
            this.HasWiFi = hasWiFi;
            this.HasTravelCenter = hasTravelCenter;
            this.HasRailwayMission = hasRailwayMission;
            this.HasDBLounge = hasDBLounge;
            this.HasLostAndFound = hasLostAndFound;
            this.HasCarRental = hasCarRental;
            this.EvaNumbers = evaNumbers;
            this.RiL100Identifiers = riL100Identifiers;
            this.TimetableOffice = timetableOffice;
            this.StationManagement = stationManagement;
            this.LocalServiceStaff = localServiceStaff;
            this.DBinformation = dBinformation;
            this.Regionalbereich = regionalbereich;
            this.Szentrale = szentrale;
            this.Aufgabentraeger = aufgabentraeger;
        }
        
        /// <summary>
        /// unique identifier representing a specific railway station
        /// </summary>
        /// <value>unique identifier representing a specific railway station</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int Number { get; set; }

        /// <summary>
        /// the stations name
        /// </summary>
        /// <value>the stations name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MailingAdress
        /// </summary>
        [DataMember(Name="mailingAdress", EmitDefaultValue=false)]
        public Address MailingAdress { get; set; }

        /// <summary>
        /// the stations category (-1...7). Stations with category -1 or 0 are not in production, e.g. planned, saled, without train stops.
        /// </summary>
        /// <value>the stations category (-1...7). Stations with category -1 or 0 are not in production, e.g. planned, saled, without train stops.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int Category { get; set; }

        /// <summary>
        /// determines in some respect the price for train stops at a specific station (1..7)
        /// </summary>
        /// <value>determines in some respect the price for train stops at a specific station (1..7)</value>
        [DataMember(Name="priceCategory", EmitDefaultValue=false)]
        public int PriceCategory { get; set; }

        /// <summary>
        /// german federal state
        /// </summary>
        /// <value>german federal state</value>
        [DataMember(Name="federalState", EmitDefaultValue=false)]
        public string FederalState { get; set; }

        /// <summary>
        /// public parking y/n
        /// </summary>
        /// <value>public parking y/n</value>
        [DataMember(Name="hasParking", EmitDefaultValue=false)]
        public bool HasParking { get; set; }

        /// <summary>
        /// public bicycle parking y/n
        /// </summary>
        /// <value>public bicycle parking y/n</value>
        [DataMember(Name="hasBicycleParking", EmitDefaultValue=false)]
        public bool HasBicycleParking { get; set; }

        /// <summary>
        /// public facilities y/n
        /// </summary>
        /// <value>public facilities y/n</value>
        [DataMember(Name="hasPublicFacilities", EmitDefaultValue=false)]
        public bool HasPublicFacilities { get; set; }

        /// <summary>
        /// public facilities y/n
        /// </summary>
        /// <value>public facilities y/n</value>
        [DataMember(Name="hasLockerSystem", EmitDefaultValue=false)]
        public bool HasLockerSystem { get; set; }

        /// <summary>
        /// local public transport y/n
        /// </summary>
        /// <value>local public transport y/n</value>
        [DataMember(Name="hasLocalPublicTransport", EmitDefaultValue=false)]
        public bool HasLocalPublicTransport { get; set; }

        /// <summary>
        /// taxi rank in front of the station y/n
        /// </summary>
        /// <value>taxi rank in front of the station y/n</value>
        [DataMember(Name="hasTaxiRank", EmitDefaultValue=false)]
        public bool HasTaxiRank { get; set; }

        /// <summary>
        /// a shop for travel necessities y/n
        /// </summary>
        /// <value>a shop for travel necessities y/n</value>
        [DataMember(Name="hasTravelNecessities", EmitDefaultValue=false)]
        public bool HasTravelNecessities { get; set; }

        /// <summary>
        /// values are &#39;no&#39;, &#39;yes, advance notification is requested...&#39; or &#39;yes, advance notification is required...&#39;
        /// </summary>
        /// <value>values are &#39;no&#39;, &#39;yes, advance notification is requested...&#39; or &#39;yes, advance notification is required...&#39;</value>
        [DataMember(Name="hasMobilityService", EmitDefaultValue=false)]
        public string HasMobilityService { get; set; }

        /// <summary>
        /// public Wi-Fi is available y/n
        /// </summary>
        /// <value>public Wi-Fi is available y/n</value>
        [DataMember(Name="hasWiFi", EmitDefaultValue=false)]
        public bool HasWiFi { get; set; }

        /// <summary>
        /// local travel center y/n
        /// </summary>
        /// <value>local travel center y/n</value>
        [DataMember(Name="hasTravelCenter", EmitDefaultValue=false)]
        public bool HasTravelCenter { get; set; }

        /// <summary>
        /// railway mission y/n
        /// </summary>
        /// <value>railway mission y/n</value>
        [DataMember(Name="hasRailwayMission", EmitDefaultValue=false)]
        public bool HasRailwayMission { get; set; }

        /// <summary>
        /// DB lounge y/n
        /// </summary>
        /// <value>DB lounge y/n</value>
        [DataMember(Name="hasDBLounge", EmitDefaultValue=false)]
        public bool HasDBLounge { get; set; }

        /// <summary>
        /// lost and found y/n
        /// </summary>
        /// <value>lost and found y/n</value>
        [DataMember(Name="hasLostAndFound", EmitDefaultValue=false)]
        public bool HasLostAndFound { get; set; }

        /// <summary>
        /// car sharing or car rental y/n
        /// </summary>
        /// <value>car sharing or car rental y/n</value>
        [DataMember(Name="hasCarRental", EmitDefaultValue=false)]
        public bool HasCarRental { get; set; }

        /// <summary>
        /// station related EVA-Numbers
        /// </summary>
        /// <value>station related EVA-Numbers</value>
        [DataMember(Name="evaNumbers", EmitDefaultValue=false)]
        public List<EVANumber> EvaNumbers { get; set; }

        /// <summary>
        /// station related Ril100s
        /// </summary>
        /// <value>station related Ril100s</value>
        [DataMember(Name="riL100Identifiers", EmitDefaultValue=false)]
        public List<RiL100Identifier> RiL100Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets TimetableOffice
        /// </summary>
        [DataMember(Name="timetableOffice", EmitDefaultValue=false)]
        public TimetableOffice TimetableOffice { get; set; }

        /// <summary>
        /// Gets or Sets StationManagement
        /// </summary>
        [DataMember(Name="stationManagement", EmitDefaultValue=false)]
        public StationManagementRef StationManagement { get; set; }

        /// <summary>
        /// Gets or Sets LocalServiceStaff
        /// </summary>
        [DataMember(Name="localServiceStaff", EmitDefaultValue=false)]
        public Schedule LocalServiceStaff { get; set; }

        /// <summary>
        /// Gets or Sets DBinformation
        /// </summary>
        [DataMember(Name="DBinformation", EmitDefaultValue=false)]
        public Schedule DBinformation { get; set; }

        /// <summary>
        /// Gets or Sets Regionalbereich
        /// </summary>
        [DataMember(Name="regionalbereich", EmitDefaultValue=false)]
        public RegionalBereichRef Regionalbereich { get; set; }

        /// <summary>
        /// Gets or Sets Szentrale
        /// </summary>
        [DataMember(Name="szentrale", EmitDefaultValue=false)]
        public SZentraleRef Szentrale { get; set; }

        /// <summary>
        /// Gets or Sets Aufgabentraeger
        /// </summary>
        [DataMember(Name="aufgabentraeger", EmitDefaultValue=false)]
        public Aufgabentraeger Aufgabentraeger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Station {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MailingAdress: ").Append(MailingAdress).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  PriceCategory: ").Append(PriceCategory).Append("\n");
            sb.Append("  FederalState: ").Append(FederalState).Append("\n");
            sb.Append("  HasParking: ").Append(HasParking).Append("\n");
            sb.Append("  HasBicycleParking: ").Append(HasBicycleParking).Append("\n");
            sb.Append("  HasPublicFacilities: ").Append(HasPublicFacilities).Append("\n");
            sb.Append("  HasLockerSystem: ").Append(HasLockerSystem).Append("\n");
            sb.Append("  HasLocalPublicTransport: ").Append(HasLocalPublicTransport).Append("\n");
            sb.Append("  HasTaxiRank: ").Append(HasTaxiRank).Append("\n");
            sb.Append("  HasTravelNecessities: ").Append(HasTravelNecessities).Append("\n");
            sb.Append("  HasSteplessAccess: ").Append(HasSteplessAccess).Append("\n");
            sb.Append("  HasMobilityService: ").Append(HasMobilityService).Append("\n");
            sb.Append("  HasWiFi: ").Append(HasWiFi).Append("\n");
            sb.Append("  HasTravelCenter: ").Append(HasTravelCenter).Append("\n");
            sb.Append("  HasRailwayMission: ").Append(HasRailwayMission).Append("\n");
            sb.Append("  HasDBLounge: ").Append(HasDBLounge).Append("\n");
            sb.Append("  HasLostAndFound: ").Append(HasLostAndFound).Append("\n");
            sb.Append("  HasCarRental: ").Append(HasCarRental).Append("\n");
            sb.Append("  EvaNumbers: ").Append(EvaNumbers).Append("\n");
            sb.Append("  RiL100Identifiers: ").Append(RiL100Identifiers).Append("\n");
            sb.Append("  TimetableOffice: ").Append(TimetableOffice).Append("\n");
            sb.Append("  StationManagement: ").Append(StationManagement).Append("\n");
            sb.Append("  LocalServiceStaff: ").Append(LocalServiceStaff).Append("\n");
            sb.Append("  DBinformation: ").Append(DBinformation).Append("\n");
            sb.Append("  Regionalbereich: ").Append(Regionalbereich).Append("\n");
            sb.Append("  Szentrale: ").Append(Szentrale).Append("\n");
            sb.Append("  Aufgabentraeger: ").Append(Aufgabentraeger).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Station);
        }

        /// <summary>
        /// Returns true if Station instances are equal
        /// </summary>
        /// <param name="input">Instance of Station to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Station input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MailingAdress == input.MailingAdress ||
                    (this.MailingAdress != null &&
                    this.MailingAdress.Equals(input.MailingAdress))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.PriceCategory == input.PriceCategory ||
                    this.PriceCategory.Equals(input.PriceCategory)
                ) && 
                (
                    this.FederalState == input.FederalState ||
                    (this.FederalState != null &&
                    this.FederalState.Equals(input.FederalState))
                ) && 
                (
                    this.HasParking == input.HasParking ||
                    this.HasParking.Equals(input.HasParking)
                ) && 
                (
                    this.HasBicycleParking == input.HasBicycleParking ||
                    this.HasBicycleParking.Equals(input.HasBicycleParking)
                ) && 
                (
                    this.HasPublicFacilities == input.HasPublicFacilities ||
                    this.HasPublicFacilities.Equals(input.HasPublicFacilities)
                ) && 
                (
                    this.HasLockerSystem == input.HasLockerSystem ||
                    this.HasLockerSystem.Equals(input.HasLockerSystem)
                ) && 
                (
                    this.HasLocalPublicTransport == input.HasLocalPublicTransport ||
                    this.HasLocalPublicTransport.Equals(input.HasLocalPublicTransport)
                ) && 
                (
                    this.HasTaxiRank == input.HasTaxiRank ||
                    this.HasTaxiRank.Equals(input.HasTaxiRank)
                ) && 
                (
                    this.HasTravelNecessities == input.HasTravelNecessities ||
                    this.HasTravelNecessities.Equals(input.HasTravelNecessities)
                ) && 
                (
                    this.HasSteplessAccess == input.HasSteplessAccess ||
                    this.HasSteplessAccess.Equals(input.HasSteplessAccess)
                ) && 
                (
                    this.HasMobilityService == input.HasMobilityService ||
                    (this.HasMobilityService != null &&
                    this.HasMobilityService.Equals(input.HasMobilityService))
                ) && 
                (
                    this.HasWiFi == input.HasWiFi ||
                    this.HasWiFi.Equals(input.HasWiFi)
                ) && 
                (
                    this.HasTravelCenter == input.HasTravelCenter ||
                    this.HasTravelCenter.Equals(input.HasTravelCenter)
                ) && 
                (
                    this.HasRailwayMission == input.HasRailwayMission ||
                    this.HasRailwayMission.Equals(input.HasRailwayMission)
                ) && 
                (
                    this.HasDBLounge == input.HasDBLounge ||
                    this.HasDBLounge.Equals(input.HasDBLounge)
                ) && 
                (
                    this.HasLostAndFound == input.HasLostAndFound ||
                    this.HasLostAndFound.Equals(input.HasLostAndFound)
                ) && 
                (
                    this.HasCarRental == input.HasCarRental ||
                    this.HasCarRental.Equals(input.HasCarRental)
                ) && 
                (
                    this.EvaNumbers == input.EvaNumbers ||
                    this.EvaNumbers != null &&
                    input.EvaNumbers != null &&
                    this.EvaNumbers.SequenceEqual(input.EvaNumbers)
                ) && 
                (
                    this.RiL100Identifiers == input.RiL100Identifiers ||
                    this.RiL100Identifiers != null &&
                    input.RiL100Identifiers != null &&
                    this.RiL100Identifiers.SequenceEqual(input.RiL100Identifiers)
                ) && 
                (
                    this.TimetableOffice == input.TimetableOffice ||
                    (this.TimetableOffice != null &&
                    this.TimetableOffice.Equals(input.TimetableOffice))
                ) && 
                (
                    this.StationManagement == input.StationManagement ||
                    (this.StationManagement != null &&
                    this.StationManagement.Equals(input.StationManagement))
                ) && 
                (
                    this.LocalServiceStaff == input.LocalServiceStaff ||
                    (this.LocalServiceStaff != null &&
                    this.LocalServiceStaff.Equals(input.LocalServiceStaff))
                ) && 
                (
                    this.DBinformation == input.DBinformation ||
                    (this.DBinformation != null &&
                    this.DBinformation.Equals(input.DBinformation))
                ) && 
                (
                    this.Regionalbereich == input.Regionalbereich ||
                    (this.Regionalbereich != null &&
                    this.Regionalbereich.Equals(input.Regionalbereich))
                ) && 
                (
                    this.Szentrale == input.Szentrale ||
                    (this.Szentrale != null &&
                    this.Szentrale.Equals(input.Szentrale))
                ) && 
                (
                    this.Aufgabentraeger == input.Aufgabentraeger ||
                    (this.Aufgabentraeger != null &&
                    this.Aufgabentraeger.Equals(input.Aufgabentraeger))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MailingAdress != null)
                    hashCode = hashCode * 59 + this.MailingAdress.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.PriceCategory.GetHashCode();
                if (this.FederalState != null)
                    hashCode = hashCode * 59 + this.FederalState.GetHashCode();
                hashCode = hashCode * 59 + this.HasParking.GetHashCode();
                hashCode = hashCode * 59 + this.HasBicycleParking.GetHashCode();
                hashCode = hashCode * 59 + this.HasPublicFacilities.GetHashCode();
                hashCode = hashCode * 59 + this.HasLockerSystem.GetHashCode();
                hashCode = hashCode * 59 + this.HasLocalPublicTransport.GetHashCode();
                hashCode = hashCode * 59 + this.HasTaxiRank.GetHashCode();
                hashCode = hashCode * 59 + this.HasTravelNecessities.GetHashCode();
                hashCode = hashCode * 59 + this.HasSteplessAccess.GetHashCode();
                if (this.HasMobilityService != null)
                    hashCode = hashCode * 59 + this.HasMobilityService.GetHashCode();
                hashCode = hashCode * 59 + this.HasWiFi.GetHashCode();
                hashCode = hashCode * 59 + this.HasTravelCenter.GetHashCode();
                hashCode = hashCode * 59 + this.HasRailwayMission.GetHashCode();
                hashCode = hashCode * 59 + this.HasDBLounge.GetHashCode();
                hashCode = hashCode * 59 + this.HasLostAndFound.GetHashCode();
                hashCode = hashCode * 59 + this.HasCarRental.GetHashCode();
                if (this.EvaNumbers != null)
                    hashCode = hashCode * 59 + this.EvaNumbers.GetHashCode();
                if (this.RiL100Identifiers != null)
                    hashCode = hashCode * 59 + this.RiL100Identifiers.GetHashCode();
                if (this.TimetableOffice != null)
                    hashCode = hashCode * 59 + this.TimetableOffice.GetHashCode();
                if (this.StationManagement != null)
                    hashCode = hashCode * 59 + this.StationManagement.GetHashCode();
                if (this.LocalServiceStaff != null)
                    hashCode = hashCode * 59 + this.LocalServiceStaff.GetHashCode();
                if (this.DBinformation != null)
                    hashCode = hashCode * 59 + this.DBinformation.GetHashCode();
                if (this.Regionalbereich != null)
                    hashCode = hashCode * 59 + this.Regionalbereich.GetHashCode();
                if (this.Szentrale != null)
                    hashCode = hashCode * 59 + this.Szentrale.GetHashCode();
                if (this.Aufgabentraeger != null)
                    hashCode = hashCode * 59 + this.Aufgabentraeger.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
