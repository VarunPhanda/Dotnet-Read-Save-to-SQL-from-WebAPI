namespace AppSample
{
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GeoClientResponse
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("alleyCrossStreetsFlag")]
        public string AlleyCrossStreetsFlag { get; set; }

        [JsonProperty("assemblyDistrict")]
        public string AssemblyDistrict { get; set; }

        [JsonProperty("bbl")]
        public string Bbl { get; set; }

        [JsonProperty("bblBoroughCode")]
        public string BblBoroughCode { get; set; }

        [JsonProperty("bblTaxBlock")]
        public string BblTaxBlock { get; set; }

        [JsonProperty("bblTaxLot")]
        public string BblTaxLot { get; set; }

        [JsonProperty("boardOfElectionsPreferredLgc")]        
        public string BoardOfElectionsPreferredLgc { get; set; }

        [JsonProperty("boePreferredStreetName")]
        public string BoePreferredStreetName { get; set; }

        [JsonProperty("boePreferredstreetCode")]        
        public string BoePreferredstreetCode { get; set; }

        [JsonProperty("boroughCode1In")]        
        public string BoroughCode1In { get; set; }

        [JsonProperty("buildingIdentificationNumber")]        
        public string BuildingIdentificationNumber { get; set; }

        [JsonProperty("censusBlock2000")]        
        public string CensusBlock2000 { get; set; }

        [JsonProperty("censusBlock2010")]        
        public string CensusBlock2010 { get; set; }

        [JsonProperty("censusTract1990")]
        public string CensusTract1990 { get; set; }

        [JsonProperty("censusTract2000")]
        public string CensusTract2000 { get; set; }

        [JsonProperty("censusTract2010")]
        public string CensusTract2010 { get; set; }

        [JsonProperty("cityCouncilDistrict")]        
        public string CityCouncilDistrict { get; set; }

        [JsonProperty("civilCourtDistrict")]
        public string CivilCourtDistrict { get; set; }

        [JsonProperty("coincidentSegmentCount")]        
        public string CoincidentSegmentCount { get; set; }

        [JsonProperty("communityDistrict")]        
        public string CommunityDistrict { get; set; }

        [JsonProperty("communityDistrictBoroughCode")]        
        public string CommunityDistrictBoroughCode { get; set; }

        [JsonProperty("communityDistrictNumber")]
        public string CommunityDistrictNumber { get; set; }

        [JsonProperty("communitySchoolDistrict")]        
        public string CommunitySchoolDistrict { get; set; }

        [JsonProperty("condominiumBillingBbl")]
        public string CondominiumBillingBbl { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("cooperativeIdNumber")]
        public string CooperativeIdNumber { get; set; }

        [JsonProperty("crossStreetNamesFlagIn")]
        public string CrossStreetNamesFlagIn { get; set; }

        [JsonProperty("dcpCommercialStudyArea")]        
        public string DcpCommercialStudyArea { get; set; }

        [JsonProperty("dcpPreferredLgc")]
        public string DcpPreferredLgc { get; set; }

        [JsonProperty("dotStreetLightContractorArea")]        
        public string DotStreetLightContractorArea { get; set; }

        [JsonProperty("dynamicBlock")]        
        public string DynamicBlock { get; set; }

        [JsonProperty("electionDistrict")]
        public string ElectionDistrict { get; set; }

        [JsonProperty("fireBattalion")]        
        public string FireBattalion { get; set; }

        [JsonProperty("fireCompanyNumber")]        
        public string FireCompanyNumber { get; set; }

        [JsonProperty("fireCompanyType")]
        public string FireCompanyType { get; set; }

        [JsonProperty("fireDivision")]        
        public string FireDivision { get; set; }

        [JsonProperty("firstBoroughName")]
        public string FirstBoroughName { get; set; }

        [JsonProperty("firstStreetCode")]
        public string FirstStreetCode { get; set; }

        [JsonProperty("firstStreetNameNormalized")]
        public string FirstStreetNameNormalized { get; set; }

        [JsonProperty("fromLionNodeId")]
        public string FromLionNodeId { get; set; }

        [JsonProperty("fromPreferredLgcsFirstSetOf5")]
        public string FromPreferredLgcsFirstSetOf5 { get; set; }

        [JsonProperty("genericId")]
        public string GenericId { get; set; }

        [JsonProperty("geosupportFunctionCode")]
        public string GeosupportFunctionCode { get; set; }

        [JsonProperty("geosupportReturnCode")]
        public string GeosupportReturnCode { get; set; }

        [JsonProperty("geosupportReturnCode2")]
        public string GeosupportReturnCode2 { get; set; }

        [JsonProperty("gi5DigitStreetCode1")]        
        public string Gi5DigitStreetCode1 { get; set; }

        [JsonProperty("gi5DigitStreetCode2")]        
        public string Gi5DigitStreetCode2 { get; set; }

        [JsonProperty("gi5DigitStreetCode3")]        
        public string Gi5DigitStreetCode3 { get; set; }

        [JsonProperty("gi5DigitStreetCode4")]        
        public string Gi5DigitStreetCode4 { get; set; }

        [JsonProperty("giBoroughCode1")]        
        public string GiBoroughCode1 { get; set; }

        [JsonProperty("giBoroughCode2")]        
        public string GiBoroughCode2 { get; set; }

        [JsonProperty("giBoroughCode3")]        
        public string GiBoroughCode3 { get; set; }

        [JsonProperty("giBoroughCode4")]        
        public string GiBoroughCode4 { get; set; }

        [JsonProperty("giBuildingIdentificationNumber1")]        
        public string GiBuildingIdentificationNumber1 { get; set; }

        [JsonProperty("giBuildingIdentificationNumber2")]        
        public string GiBuildingIdentificationNumber2 { get; set; }

        [JsonProperty("giBuildingIdentificationNumber3")]        
        public string GiBuildingIdentificationNumber3 { get; set; }

        [JsonProperty("giBuildingIdentificationNumber4")]        
        public string GiBuildingIdentificationNumber4 { get; set; }

        [JsonProperty("giDcpPreferredLgc1")]
        public string GiDcpPreferredLgc1 { get; set; }

        [JsonProperty("giDcpPreferredLgc2")]
        public string GiDcpPreferredLgc2 { get; set; }

        [JsonProperty("giDcpPreferredLgc3")]
        public string GiDcpPreferredLgc3 { get; set; }

        [JsonProperty("giDcpPreferredLgc4")]
        public string GiDcpPreferredLgc4 { get; set; }

        [JsonProperty("giHighHouseNumber1")]        
        public string GiHighHouseNumber1 { get; set; }

        [JsonProperty("giHighHouseNumber2")]        
        public string GiHighHouseNumber2 { get; set; }

        [JsonProperty("giHighHouseNumber3")]        
        public string GiHighHouseNumber3 { get; set; }

        [JsonProperty("giHighHouseNumber4")]        
        public string GiHighHouseNumber4 { get; set; }

        [JsonProperty("giLowHouseNumber1")]        
        public string GiLowHouseNumber1 { get; set; }

        [JsonProperty("giLowHouseNumber2")]        
        public string GiLowHouseNumber2 { get; set; }

        [JsonProperty("giLowHouseNumber3")]        
        public string GiLowHouseNumber3 { get; set; }

        [JsonProperty("giLowHouseNumber4")]        
        public string GiLowHouseNumber4 { get; set; }

        [JsonProperty("giSideOfStreetIndicator1")]
        public string GiSideOfStreetIndicator1 { get; set; }

        [JsonProperty("giSideOfStreetIndicator2")]
        public string GiSideOfStreetIndicator2 { get; set; }

        [JsonProperty("giSideOfStreetIndicator3")]
        public string GiSideOfStreetIndicator3 { get; set; }

        [JsonProperty("giSideOfStreetIndicator4")]
        public string GiSideOfStreetIndicator4 { get; set; }

        [JsonProperty("giStreetCode1")]        
        public string GiStreetCode1 { get; set; }

        [JsonProperty("giStreetCode2")]        
        public string GiStreetCode2 { get; set; }

        [JsonProperty("giStreetCode3")]        
        public string GiStreetCode3 { get; set; }

        [JsonProperty("giStreetCode4")]        
        public string GiStreetCode4 { get; set; }

        [JsonProperty("giStreetName1")]
        public string GiStreetName1 { get; set; }

        [JsonProperty("giStreetName2")]
        public string GiStreetName2 { get; set; }

        [JsonProperty("giStreetName3")]
        public string GiStreetName3 { get; set; }

        [JsonProperty("giStreetName4")]
        public string GiStreetName4 { get; set; }

        [JsonProperty("healthArea")]        
        public string HealthArea { get; set; }

        [JsonProperty("healthCenterDistrict")]        
        public string HealthCenterDistrict { get; set; }

        [JsonProperty("highBblOfThisBuildingsCondominiumUnits")]
        public string HighBblOfThisBuildingsCondominiumUnits { get; set; }

        [JsonProperty("highCrossStreetB5SC1")]        
        public string HighCrossStreetB5Sc1 { get; set; }

        [JsonProperty("highCrossStreetCode1")]        
        public string HighCrossStreetCode1 { get; set; }

        [JsonProperty("highCrossStreetName1")]
        public string HighCrossStreetName1 { get; set; }

        [JsonProperty("highHouseNumberOfBlockfaceSortFormat")]
        public string HighHouseNumberOfBlockfaceSortFormat { get; set; }

        [JsonProperty("houseNumber")]        
        public string HouseNumber { get; set; }

        [JsonProperty("houseNumberIn")]        
        public string HouseNumberIn { get; set; }

        [JsonProperty("houseNumberSortFormat")]
        public string HouseNumberSortFormat { get; set; }

        [JsonProperty("hurricaneEvacuationZone")]
        public string HurricaneEvacuationZone { get; set; }

        [JsonProperty("individualSegmentLength")]
        public string IndividualSegmentLength { get; set; }

        [JsonProperty("instructionalRegion")]
        public string InstructionalRegion { get; set; }

        [JsonProperty("interimAssistanceEligibilityIndicator")]
        public string InterimAssistanceEligibilityIndicator { get; set; }

        [JsonProperty("internalLabelXCoordinate")]
        public string InternalLabelXCoordinate { get; set; }

        [JsonProperty("internalLabelYCoordinate")]
        public string InternalLabelYCoordinate { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("latitudeInternalLabel")]
        public double LatitudeInternalLabel { get; set; }

        [JsonProperty("legacySegmentId")]
        public string LegacySegmentId { get; set; }

        [JsonProperty("lionBoroughCode")]        
        public string LionBoroughCode { get; set; }

        [JsonProperty("lionBoroughCodeForVanityAddress")]        
        public string LionBoroughCodeForVanityAddress { get; set; }

        [JsonProperty("lionFaceCode")]        
        public string LionFaceCode { get; set; }

        [JsonProperty("lionFaceCodeForVanityAddress")]        
        public string LionFaceCodeForVanityAddress { get; set; }

        [JsonProperty("lionKey")]
        public string LionKey { get; set; }

        [JsonProperty("lionKeyForVanityAddress")]
        public string LionKeyForVanityAddress { get; set; }

        [JsonProperty("lionSequenceNumber")]
        public string LionSequenceNumber { get; set; }

        [JsonProperty("lionSequenceNumberForVanityAddress")]
        public string LionSequenceNumberForVanityAddress { get; set; }

        [JsonProperty("listOf4Lgcs")]
        public string ListOf4Lgcs { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("longitudeInternalLabel")]
        public double LongitudeInternalLabel { get; set; }

        [JsonProperty("lowBblOfThisBuildingsCondominiumUnits")]
        public string LowBblOfThisBuildingsCondominiumUnits { get; set; }

        [JsonProperty("lowCrossStreetB5SC1")]        
        public string LowCrossStreetB5Sc1 { get; set; }

        [JsonProperty("lowCrossStreetCode1")]        
        public string LowCrossStreetCode1 { get; set; }

        [JsonProperty("lowCrossStreetName1")]
        public string LowCrossStreetName1 { get; set; }

        [JsonProperty("lowHouseNumberOfBlockfaceSortFormat")]
        public string LowHouseNumberOfBlockfaceSortFormat { get; set; }

        [JsonProperty("lowHouseNumberOfDefiningAddressRange")]
        public string LowHouseNumberOfDefiningAddressRange { get; set; }

        [JsonProperty("noCrossStreetCalculationFlag")]
        public string NoCrossStreetCalculationFlag { get; set; }

        [JsonProperty("nta")]
        public string Nta { get; set; }

        [JsonProperty("ntaName")]
        public string NtaName { get; set; }

        [JsonProperty("numberOfCrossStreetB5SCsHighAddressEnd")]        
        public string NumberOfCrossStreetB5SCsHighAddressEnd { get; set; }

        [JsonProperty("numberOfCrossStreetB5SCsLowAddressEnd")]        
        public string NumberOfCrossStreetB5SCsLowAddressEnd { get; set; }

        [JsonProperty("numberOfCrossStreetsHighAddressEnd")]        
        public string NumberOfCrossStreetsHighAddressEnd { get; set; }

        [JsonProperty("numberOfCrossStreetsLowAddressEnd")]        
        public string NumberOfCrossStreetsLowAddressEnd { get; set; }

        [JsonProperty("numberOfEntriesInListOfGeographicIdentifiers")]
        public string NumberOfEntriesInListOfGeographicIdentifiers { get; set; }

        [JsonProperty("numberOfExistingStructuresOnLot")]
        public string NumberOfExistingStructuresOnLot { get; set; }

        [JsonProperty("numberOfStreetFrontagesOfLot")]
        public string NumberOfStreetFrontagesOfLot { get; set; }

        [JsonProperty("physicalId")]
        public string PhysicalId { get; set; }

        [JsonProperty("policePatrolBoroughCommand")]        
        public string PolicePatrolBoroughCommand { get; set; }

        [JsonProperty("policePrecinct")]
        public string PolicePrecinct { get; set; }

        [JsonProperty("returnCode1a")]
        public string ReturnCode1A { get; set; }

        [JsonProperty("returnCode1e")]
        public string ReturnCode1E { get; set; }

        [JsonProperty("roadwayType")]        
        public string RoadwayType { get; set; }

        [JsonProperty("rpadBuildingClassificationCode")]
        public string RpadBuildingClassificationCode { get; set; }

        [JsonProperty("rpadSelfCheckCodeForBbl")]        
        public string RpadSelfCheckCodeForBbl { get; set; }

        [JsonProperty("sanbornBoroughCode")]        
        public string SanbornBoroughCode { get; set; }

        [JsonProperty("sanbornPageNumber")]
        public string SanbornPageNumber { get; set; }

        [JsonProperty("sanbornVolumeNumber")]
        public string SanbornVolumeNumber { get; set; }

        [JsonProperty("sanitationCollectionSchedulingSectionAndSubsection")]
        public string SanitationCollectionSchedulingSectionAndSubsection { get; set; }

        [JsonProperty("sanitationDistrict")]        
        public string SanitationDistrict { get; set; }

        [JsonProperty("sanitationOrganicsCollectionSchedule")]
        public string SanitationOrganicsCollectionSchedule { get; set; }

        [JsonProperty("sanitationRecyclingCollectionSchedule")]
        public string SanitationRecyclingCollectionSchedule { get; set; }

        [JsonProperty("sanitationRegularCollectionSchedule")]
        public string SanitationRegularCollectionSchedule { get; set; }

        [JsonProperty("sanitationSnowPriorityCode")]
        public string SanitationSnowPriorityCode { get; set; }

        [JsonProperty("segmentAzimuth")]        
        public string SegmentAzimuth { get; set; }

        [JsonProperty("segmentIdentifier")]
        public string SegmentIdentifier { get; set; }

        [JsonProperty("segmentLengthInFeet")]
        public string SegmentLengthInFeet { get; set; }

        [JsonProperty("segmentOrientation")]
        public string SegmentOrientation { get; set; }

        [JsonProperty("segmentTypeCode")]
        public string SegmentTypeCode { get; set; }

        [JsonProperty("sideOfStreetIndicator")]
        public string SideOfStreetIndicator { get; set; }

        [JsonProperty("sideOfStreetOfVanityAddress")]
        public string SideOfStreetOfVanityAddress { get; set; }

        [JsonProperty("splitLowHouseNumber")]
        public string SplitLowHouseNumber { get; set; }

        [JsonProperty("stateSenatorialDistrict")]        
        public string StateSenatorialDistrict { get; set; }

        [JsonProperty("streetName1In")]
        public string StreetName1In { get; set; }

        [JsonProperty("streetStatus")]        
        public string StreetStatus { get; set; }

        [JsonProperty("streetWidth")]        
        public string StreetWidth { get; set; }

        [JsonProperty("taxMapNumberSectionAndVolume")]        
        public string TaxMapNumberSectionAndVolume { get; set; }

        [JsonProperty("toLionNodeId")]
        public string ToLionNodeId { get; set; }

        [JsonProperty("trafficDirection")]
        public string TrafficDirection { get; set; }

        [JsonProperty("underlyingStreetCode")]        
        public string UnderlyingStreetCode { get; set; }

        [JsonProperty("uspsPreferredCityName")]
        public string UspsPreferredCityName { get; set; }

        [JsonProperty("workAreaFormatIndicatorIn")]
        public string WorkAreaFormatIndicatorIn { get; set; }

        [JsonProperty("xCoordinate")]
        public string XCoordinate { get; set; }

        [JsonProperty("xCoordinateHighAddressEnd")]
        public string XCoordinateHighAddressEnd { get; set; }

        [JsonProperty("xCoordinateLowAddressEnd")]
        public string XCoordinateLowAddressEnd { get; set; }

        [JsonProperty("xCoordinateOfCenterofCurvature")]
        public string XCoordinateOfCenterofCurvature { get; set; }

        [JsonProperty("yCoordinate")]
        public string YCoordinate { get; set; }

        [JsonProperty("yCoordinateHighAddressEnd")]
        public string YCoordinateHighAddressEnd { get; set; }

        [JsonProperty("yCoordinateLowAddressEnd")]
        public string YCoordinateLowAddressEnd { get; set; }

        [JsonProperty("yCoordinateOfCenterofCurvature")]
        public string YCoordinateOfCenterofCurvature { get; set; }

        [JsonProperty("zipCode")]        
        public string ZipCode { get; set; }
    }

    public partial class GeoClientResponse
    {
        public static GeoClientResponse FromJson(string json) => JsonConvert.DeserializeObject<GeoClientResponse>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GeoClientResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJsonAddress(this Address self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
