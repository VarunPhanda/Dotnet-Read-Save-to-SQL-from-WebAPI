using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace AppSample
{
    public class AppRequest
    {
        #region GetData
        public static IEnumerable<GeoClientResponse> GetData()
        {
            var requestDataList = ReadSQLData();
            List<GeoClientResponse> responseList = new List<GeoClientResponse>();
            foreach (var data in requestDataList)
            {
                var responseData = GetSingleData(data.HouseNumber, data.Street, data.Borough);
                responseList.Add(responseData);
            }
            return responseList;
        }

        public static GeoClientResponse GetSingleData(string hNo, string streetName, string borough)
        {
            var json_data = GetDataAsString(hNo, streetName, borough);
            if (!string.IsNullOrEmpty(json_data))
            {
                return JsonConvert.DeserializeObject<GeoClientResponse>(json_data);
            }
            else
            {
                return null;
            }
        }

        private static string GetDataAsString(string hNo, string streetName, string borough)
        {
            using (var webClient = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    string app_id = "<APP_ID>",
                        app_key = "<APP_KEY>";
                    var url = "<URL>";
                    var uri = new Uri(string.Format($"{url}.json?houseNumber={hNo}&street={streetName}&borough={borough}&app_id={app_id}&app_key={app_key}", string.Empty));

                    json_data = webClient.DownloadString(uri);
                }
                catch (Exception ex) { throw ex; }
                return json_data;
            }
        }
        #endregion

        #region SaveData
        public static bool SaveCollection(IEnumerable<GeoClientResponse> responseList)
        {
            var isInserted = false;
            var table = GetSQLDataTable();
            foreach (var response in responseList)
            {
                AddDataRow(response, table);
            }
            isInserted = InsertSQLData(table);
            return isInserted;
        }

        public static bool SaveData(string data)
        {
            GeoClientResponse geoClientResponse = null;
            if (!string.IsNullOrEmpty(data))
            {
                geoClientResponse = JsonConvert.DeserializeObject<GeoClientResponse>(data);
            }
            var table = GetSQLDataTable();
            AddDataRow(geoClientResponse, table);
            var isInserted = InsertSQLData(table);
            return isInserted;
        }
        #endregion

        #region SQL
        private static IEnumerable<GeoClientSource> ReadSQLData()
        {
            List<GeoClientSource> requestData = new List<GeoClientSource>();
            SqlConnection con = new SqlConnection(@"Data Source=<SOURCE>;Initial Catalog=<CATALOG>;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from SRC_GEOCLIENT", con);
            cmd.Connection = con;
            try
            {
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        GeoClientSource data = new GeoClientSource();
                        data.HouseNumber = oReader["houseNumber"].ToString();
                        data.Street = oReader["street"].ToString();
                        data.Borough = oReader["borough"].ToString();
                        requestData.Add(data);
                    }

                    con.Close();
                }
                Console.WriteLine("Records inserted successfully!");
                return requestData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private static bool InsertSQLData(DataTable dtData)
        {
            SqlConnection con = new SqlConnection(@"Data Source=<SOURCE>;Initial Catalog=<CATALOG>;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("InsertGeoClientDestination", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dtGeoClient", dtData);
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records inserted successfully!");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private static DataTable GetSQLDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("alleyCrossStreetsFlag", typeof(string));
            table.Columns.Add("assemblyDistrict", typeof(string));
            table.Columns.Add("bbl", typeof(string));
            table.Columns.Add("bblBoroughCode", typeof(string));
            table.Columns.Add("bblTaxBlock", typeof(string));
            table.Columns.Add("bblTaxLot", typeof(string));
            table.Columns.Add("boardOfElectionsPreferredLgc", typeof(string));
            table.Columns.Add("boePreferredStreetName", typeof(string));
            table.Columns.Add("boePreferredstreetCode", typeof(string));
            table.Columns.Add("boroughCode1In", typeof(string));
            table.Columns.Add("buildingIdentificationNumber", typeof(string));
            table.Columns.Add("censusBlock2000", typeof(string));
            table.Columns.Add("censusBlock2010", typeof(string));
            table.Columns.Add("censusTract1990", typeof(string));
            table.Columns.Add("censusTract2000", typeof(string));
            table.Columns.Add("censusTract2010", typeof(string));
            table.Columns.Add("cityCouncilDistrict", typeof(string));
            table.Columns.Add("civilCourtDistrict", typeof(string));
            table.Columns.Add("coincidentSegmentCount", typeof(string));
            table.Columns.Add("communityDistrict", typeof(string));
            table.Columns.Add("communityDistrictBoroughCode", typeof(string));
            table.Columns.Add("communityDistrictNumber", typeof(string));
            table.Columns.Add("communitySchoolDistrict", typeof(string));
            table.Columns.Add("condominiumBillingBbl", typeof(string));
            table.Columns.Add("congressionalDistrict", typeof(string));
            table.Columns.Add("cooperativeIdNumber", typeof(string));
            table.Columns.Add("crossStreetNamesFlagIn", typeof(string));
            table.Columns.Add("dcpCommercialStudyArea", typeof(string));
            table.Columns.Add("dcpPreferredLgc", typeof(string));
            table.Columns.Add("dotStreetLightContractorArea", typeof(string));
            table.Columns.Add("dynamicBlock", typeof(string));
            table.Columns.Add("electionDistrict", typeof(string));
            table.Columns.Add("fireBattalion", typeof(string));
            table.Columns.Add("fireCompanyNumber", typeof(string));
            table.Columns.Add("fireCompanyType", typeof(string));
            table.Columns.Add("fireDivision", typeof(string));
            table.Columns.Add("firstBoroughName", typeof(string));
            table.Columns.Add("firstStreetCode", typeof(string));
            table.Columns.Add("firstStreetNameNormalized", typeof(string));
            table.Columns.Add("fromLionNodeId", typeof(string));
            table.Columns.Add("fromPreferredLgcsFirstSetOf5", typeof(string));
            table.Columns.Add("genericId", typeof(string));
            table.Columns.Add("geosupportFunctionCode", typeof(string));
            table.Columns.Add("geosupportReturnCode", typeof(string));
            table.Columns.Add("geosupportReturnCode2", typeof(string));
            table.Columns.Add("gi5DigitStreetCode1", typeof(string));
            table.Columns.Add("gi5DigitStreetCode2", typeof(string));
            table.Columns.Add("gi5DigitStreetCode3", typeof(string));
            table.Columns.Add("gi5DigitStreetCode4", typeof(string));
            table.Columns.Add("giBoroughCode1", typeof(string));
            table.Columns.Add("giBoroughCode2", typeof(string));
            table.Columns.Add("giBoroughCode3", typeof(string));
            table.Columns.Add("giBoroughCode4", typeof(string));
            table.Columns.Add("giBuildingIdentificationNumber1", typeof(string));
            table.Columns.Add("giBuildingIdentificationNumber2", typeof(string));
            table.Columns.Add("giBuildingIdentificationNumber3", typeof(string));
            table.Columns.Add("giBuildingIdentificationNumber4", typeof(string));
            table.Columns.Add("giDcpPreferredLgc1", typeof(string));
            table.Columns.Add("giDcpPreferredLgc2", typeof(string));
            table.Columns.Add("giDcpPreferredLgc3", typeof(string));
            table.Columns.Add("giDcpPreferredLgc4", typeof(string));
            table.Columns.Add("giHighHouseNumber1", typeof(string));
            table.Columns.Add("giHighHouseNumber2", typeof(string));
            table.Columns.Add("giHighHouseNumber3", typeof(string));
            table.Columns.Add("giHighHouseNumber4", typeof(string));
            table.Columns.Add("giLowHouseNumber1", typeof(string));
            table.Columns.Add("giLowHouseNumber2", typeof(string));
            table.Columns.Add("giLowHouseNumber3", typeof(string));
            table.Columns.Add("giLowHouseNumber4", typeof(string));
            table.Columns.Add("giSideOfStreetIndicator1", typeof(string));
            table.Columns.Add("giSideOfStreetIndicator2", typeof(string));
            table.Columns.Add("giSideOfStreetIndicator3", typeof(string));
            table.Columns.Add("giSideOfStreetIndicator4", typeof(string));
            table.Columns.Add("giStreetCode1", typeof(string));
            table.Columns.Add("giStreetCode2", typeof(string));
            table.Columns.Add("giStreetCode3", typeof(string));
            table.Columns.Add("giStreetCode4", typeof(string));
            table.Columns.Add("giStreetName1", typeof(string));
            table.Columns.Add("giStreetName2", typeof(string));
            table.Columns.Add("giStreetName3", typeof(string));
            table.Columns.Add("giStreetName4", typeof(string));
            table.Columns.Add("healthArea", typeof(string));
            table.Columns.Add("healthCenterDistrict", typeof(string));
            table.Columns.Add("highBblOfThisBuildingsCondominiumUnits", typeof(string));
            table.Columns.Add("highCrossStreetB5SC1", typeof(string));
            table.Columns.Add("highCrossStreetCode1", typeof(string));
            table.Columns.Add("highCrossStreetName1", typeof(string));
            table.Columns.Add("highHouseNumberOfBlockfaceSortFormat", typeof(string));
            table.Columns.Add("houseNumber", typeof(string));
            table.Columns.Add("houseNumberIn", typeof(string));
            table.Columns.Add("houseNumberSortFormat", typeof(string));
            table.Columns.Add("hurricaneEvacuationZone", typeof(string));
            table.Columns.Add("individualSegmentLength", typeof(string));
            table.Columns.Add("instructionalRegion", typeof(string));
            table.Columns.Add("interimAssistanceEligibilityIndicator", typeof(string));
            table.Columns.Add("internalLabelXCoordinate", typeof(string));
            table.Columns.Add("internalLabelYCoordinate", typeof(string));
            table.Columns.Add("latitude", typeof(int));
            table.Columns.Add("latitudeInternalLabel", typeof(int));
            table.Columns.Add("legacySegmentId", typeof(string));
            table.Columns.Add("lionBoroughCode", typeof(string));
            table.Columns.Add("lionBoroughCodeForVanityAddress", typeof(string));
            table.Columns.Add("lionFaceCode", typeof(string));
            table.Columns.Add("lionFaceCodeForVanityAddress", typeof(string));
            table.Columns.Add("lionKey", typeof(string));
            table.Columns.Add("lionKeyForVanityAddress", typeof(string));
            table.Columns.Add("lionSequenceNumber", typeof(string));
            table.Columns.Add("lionSequenceNumberForVanityAddress", typeof(string));
            table.Columns.Add("listOf4Lgcs", typeof(string));
            table.Columns.Add("longitude", typeof(int));
            table.Columns.Add("longitudeInternalLabel", typeof(int));
            table.Columns.Add("lowBblOfThisBuildingsCondominiumUnits", typeof(string));
            table.Columns.Add("lowCrossStreetB5SC1", typeof(string));
            table.Columns.Add("lowCrossStreetCode1", typeof(string));
            table.Columns.Add("lowCrossStreetName1", typeof(string));
            table.Columns.Add("lowHouseNumberOfBlockfaceSortFormat", typeof(string));
            table.Columns.Add("lowHouseNumberOfDefiningAddressRange", typeof(string));
            table.Columns.Add("noCrossStreetCalculationFlag", typeof(string));
            table.Columns.Add("nta", typeof(string));
            table.Columns.Add("ntaName", typeof(string));
            table.Columns.Add("numberOfCrossStreetB5SCsHighAddressEnd", typeof(string));
            table.Columns.Add("numberOfCrossStreetB5SCsLowAddressEnd", typeof(string));
            table.Columns.Add("numberOfCrossStreetsHighAddressEnd", typeof(string));
            table.Columns.Add("numberOfCrossStreetsLowAddressEnd", typeof(string));
            table.Columns.Add("numberOfEntriesInListOfGeographicIdentifiers", typeof(string));
            table.Columns.Add("numberOfExistingStructuresOnLot", typeof(string));
            table.Columns.Add("numberOfStreetFrontagesOfLot", typeof(string));
            table.Columns.Add("physicalId", typeof(string));
            table.Columns.Add("policePatrolBoroughCommand", typeof(string));
            table.Columns.Add("policePrecinct", typeof(string));
            table.Columns.Add("returnCode1a", typeof(string));
            table.Columns.Add("returnCode1e", typeof(string));
            table.Columns.Add("roadwayType", typeof(string));
            table.Columns.Add("rpadBuildingClassificationCode", typeof(string));
            table.Columns.Add("rpadSelfCheckCodeForBbl", typeof(string));
            table.Columns.Add("sanbornBoroughCode", typeof(string));
            table.Columns.Add("sanbornPageNumber", typeof(string));
            table.Columns.Add("sanbornVolumeNumber", typeof(string));
            table.Columns.Add("sanitationCollectionSchedulingSectionAndSubsection", typeof(string));
            table.Columns.Add("sanitationDistrict", typeof(string));
            table.Columns.Add("sanitationOrganicsCollectionSchedule", typeof(string));
            table.Columns.Add("sanitationRecyclingCollectionSchedule", typeof(string));
            table.Columns.Add("sanitationRegularCollectionSchedule", typeof(string));
            table.Columns.Add("sanitationSnowPriorityCode", typeof(string));
            table.Columns.Add("segmentAzimuth", typeof(string));
            table.Columns.Add("segmentIdentifier", typeof(string));
            table.Columns.Add("segmentLengthInFeet", typeof(string));
            table.Columns.Add("segmentOrientation", typeof(string));
            table.Columns.Add("segmentTypeCode", typeof(string));
            table.Columns.Add("sideOfStreetIndicator", typeof(string));
            table.Columns.Add("sideOfStreetOfVanityAddress", typeof(string));
            table.Columns.Add("splitLowHouseNumber", typeof(string));
            table.Columns.Add("stateSenatorialDistrict", typeof(string));
            table.Columns.Add("streetName1In", typeof(string));
            table.Columns.Add("streetStatus", typeof(string));
            table.Columns.Add("streetWidth", typeof(string));
            table.Columns.Add("taxMapNumberSectionAndVolume", typeof(string));
            table.Columns.Add("toLionNodeId", typeof(string));
            table.Columns.Add("trafficDirection", typeof(string));
            table.Columns.Add("underlyingStreetCode", typeof(string));
            table.Columns.Add("uspsPreferredCityName", typeof(string));
            table.Columns.Add("workAreaFormatIndicatorIn", typeof(string));
            table.Columns.Add("xCoordinate", typeof(string));
            table.Columns.Add("xCoordinateHighAddressEnd", typeof(string));
            table.Columns.Add("xCoordinateLowAddressEnd", typeof(string));
            table.Columns.Add("xCoordinateOfCenterofCurvature", typeof(string));
            table.Columns.Add("yCoordinate", typeof(string));
            table.Columns.Add("yCoordinateHighAddressEnd", typeof(string));
            table.Columns.Add("yCoordinateLowAddressEnd", typeof(string));
            table.Columns.Add("yCoordinateOfCenterofCurvature", typeof(string));
            table.Columns.Add("zipCode", typeof(int));

            return table;
        }

        private static void AddDataRow(GeoClientResponse welcome, DataTable table)
        {
            var row = table.NewRow();

            row["alleyCrossStreetsFlag"] = welcome.Address.AlleyCrossStreetsFlag;
            row["assemblyDistrict"] = welcome.Address.AssemblyDistrict;
            row["bbl"] = welcome.Address.Bbl;
            row["bblBoroughCode"] = welcome.Address.BblBoroughCode;
            row["bblTaxBlock"] = welcome.Address.BblTaxBlock;
            row["bblTaxLot"] = welcome.Address.BblTaxLot;
            row["boardOfElectionsPreferredLgc"] = welcome.Address.BoardOfElectionsPreferredLgc;
            row["boePreferredStreetName"] = welcome.Address.BoePreferredStreetName;
            row["boePreferredstreetCode"] = welcome.Address.BoePreferredstreetCode;
            row["boroughCode1In"] = welcome.Address.BoroughCode1In;
            row["buildingIdentificationNumber"] = welcome.Address.BuildingIdentificationNumber;
            row["censusBlock2000"] = welcome.Address.CensusBlock2000;
            row["censusBlock2010"] = welcome.Address.CensusBlock2010;
            row["censusTract1990"] = welcome.Address.CensusTract1990;
            row["censusTract2000"] = welcome.Address.CensusTract2000;
            row["censusTract2010"] = welcome.Address.CensusTract2010;
            row["cityCouncilDistrict"] = welcome.Address.CityCouncilDistrict;
            row["civilCourtDistrict"] = welcome.Address.CivilCourtDistrict;
            row["coincidentSegmentCount"] = welcome.Address.CoincidentSegmentCount;
            row["communityDistrict"] = welcome.Address.CommunityDistrict;
            row["communityDistrictBoroughCode"] = welcome.Address.CommunityDistrictBoroughCode;
            row["communityDistrictNumber"] = welcome.Address.CommunityDistrictNumber;
            row["communitySchoolDistrict"] = welcome.Address.CommunitySchoolDistrict;
            row["condominiumBillingBbl"] = welcome.Address.CondominiumBillingBbl;
            row["congressionalDistrict"] = welcome.Address.CongressionalDistrict;
            row["cooperativeIdNumber"] = welcome.Address.CooperativeIdNumber;
            row["crossStreetNamesFlagIn"] = welcome.Address.CrossStreetNamesFlagIn;
            row["dcpCommercialStudyArea"] = welcome.Address.DcpCommercialStudyArea;
            row["dcpPreferredLgc"] = welcome.Address.DcpPreferredLgc;
            row["dotStreetLightContractorArea"] = welcome.Address.DotStreetLightContractorArea;
            row["dynamicBlock"] = welcome.Address.DynamicBlock;
            row["electionDistrict"] = welcome.Address.ElectionDistrict;
            row["fireBattalion"] = welcome.Address.FireBattalion;
            row["fireCompanyNumber"] = welcome.Address.FireCompanyNumber;
            row["fireCompanyType"] = welcome.Address.FireCompanyType;
            row["fireDivision"] = welcome.Address.FireDivision;
            row["firstBoroughName"] = welcome.Address.FirstBoroughName;
            row["firstStreetCode"] = welcome.Address.FirstStreetCode;
            row["firstStreetNameNormalized"] = welcome.Address.FirstStreetNameNormalized;
            row["fromLionNodeId"] = welcome.Address.FromLionNodeId;
            row["fromPreferredLgcsFirstSetOf5"] = welcome.Address.FromPreferredLgcsFirstSetOf5;
            row["genericId"] = welcome.Address.GenericId;
            row["geosupportFunctionCode"] = welcome.Address.GeosupportFunctionCode;
            row["geosupportReturnCode"] = welcome.Address.GeosupportReturnCode;
            row["geosupportReturnCode2"] = welcome.Address.GeosupportReturnCode2;
            row["gi5DigitStreetCode1"] = welcome.Address.Gi5DigitStreetCode1;
            row["gi5DigitStreetCode2"] = welcome.Address.Gi5DigitStreetCode2;
            row["gi5DigitStreetCode3"] = welcome.Address.Gi5DigitStreetCode3;
            row["gi5DigitStreetCode4"] = welcome.Address.Gi5DigitStreetCode4;
            row["giBoroughCode1"] = welcome.Address.GiBoroughCode1;
            row["giBoroughCode2"] = welcome.Address.GiBoroughCode2;
            row["giBoroughCode3"] = welcome.Address.GiBoroughCode3;
            row["giBoroughCode4"] = welcome.Address.GiBoroughCode4;
            row["giBuildingIdentificationNumber1"] = welcome.Address.GiBuildingIdentificationNumber1;
            row["giBuildingIdentificationNumber2"] = welcome.Address.GiBuildingIdentificationNumber2;
            row["giBuildingIdentificationNumber3"] = welcome.Address.GiBuildingIdentificationNumber3;
            row["giBuildingIdentificationNumber4"] = welcome.Address.GiBuildingIdentificationNumber4;
            row["giDcpPreferredLgc1"] = welcome.Address.GiDcpPreferredLgc1;
            row["giDcpPreferredLgc2"] = welcome.Address.GiDcpPreferredLgc2;
            row["giDcpPreferredLgc3"] = welcome.Address.GiDcpPreferredLgc3;
            row["giDcpPreferredLgc4"] = welcome.Address.GiDcpPreferredLgc4;
            row["giHighHouseNumber1"] = welcome.Address.GiHighHouseNumber1;
            row["giHighHouseNumber2"] = welcome.Address.GiHighHouseNumber2;
            row["giHighHouseNumber3"] = welcome.Address.GiHighHouseNumber3;
            row["giHighHouseNumber4"] = welcome.Address.GiHighHouseNumber4;
            row["giLowHouseNumber1"] = welcome.Address.GiLowHouseNumber1;
            row["giLowHouseNumber2"] = welcome.Address.GiLowHouseNumber2;
            row["giLowHouseNumber3"] = welcome.Address.GiLowHouseNumber3;
            row["giLowHouseNumber4"] = welcome.Address.GiLowHouseNumber4;
            row["giSideOfStreetIndicator1"] = welcome.Address.GiSideOfStreetIndicator1;
            row["giSideOfStreetIndicator2"] = welcome.Address.GiSideOfStreetIndicator1;
            row["giSideOfStreetIndicator3"] = welcome.Address.GiSideOfStreetIndicator3;
            row["giSideOfStreetIndicator4"] = welcome.Address.GiSideOfStreetIndicator4;
            row["giStreetCode1"] = welcome.Address.GiStreetCode1;
            row["giStreetCode2"] = welcome.Address.GiStreetCode2;
            row["giStreetCode3"] = welcome.Address.GiStreetCode3;
            row["giStreetCode4"] = welcome.Address.GiStreetCode4;
            row["giStreetName1"] = welcome.Address.GiStreetName1;
            row["giStreetName2"] = welcome.Address.GiStreetName2;
            row["giStreetName3"] = welcome.Address.GiStreetName3;
            row["giStreetName4"] = welcome.Address.GiStreetName4;
            row["healthArea"] = welcome.Address.HealthArea;
            row["healthCenterDistrict"] = welcome.Address.HealthCenterDistrict;
            row["highBblOfThisBuildingsCondominiumUnits"] = welcome.Address.HighBblOfThisBuildingsCondominiumUnits;
            row["highCrossStreetB5SC1"] = welcome.Address.HighCrossStreetB5Sc1;
            row["highCrossStreetCode1"] = welcome.Address.HighCrossStreetCode1;
            row["highCrossStreetName1"] = welcome.Address.HighCrossStreetName1;
            row["highHouseNumberOfBlockfaceSortFormat"] = welcome.Address.HighHouseNumberOfBlockfaceSortFormat;
            row["houseNumber"] = welcome.Address.HouseNumber;
            row["houseNumberIn"] = welcome.Address.HouseNumberIn;
            row["houseNumberSortFormat"] = welcome.Address.HouseNumberSortFormat;
            row["hurricaneEvacuationZone"] = welcome.Address.HurricaneEvacuationZone;
            row["individualSegmentLength"] = welcome.Address.IndividualSegmentLength;
            row["instructionalRegion"] = welcome.Address.InstructionalRegion;
            row["interimAssistanceEligibilityIndicator"] = welcome.Address.InterimAssistanceEligibilityIndicator;
            row["internalLabelXCoordinate"] = welcome.Address.InternalLabelXCoordinate;
            row["internalLabelYCoordinate"] = welcome.Address.InternalLabelYCoordinate;
            row["latitude"] = welcome.Address.Latitude;
            row["latitudeInternalLabel"] = welcome.Address.LatitudeInternalLabel;
            row["legacySegmentId"] = welcome.Address.LegacySegmentId;
            row["lionBoroughCode"] = welcome.Address.LionBoroughCode;
            row["lionBoroughCodeForVanityAddress"] = welcome.Address.LionBoroughCodeForVanityAddress;
            row["lionFaceCode"] = welcome.Address.LionFaceCode;
            row["lionFaceCodeForVanityAddress"] = welcome.Address.LionFaceCodeForVanityAddress;
            row["lionKey"] = welcome.Address.LionKey;
            row["lionKeyForVanityAddress"] = welcome.Address.LionKeyForVanityAddress;
            row["lionSequenceNumber"] = welcome.Address.LionSequenceNumber;
            row["lionSequenceNumberForVanityAddress"] = welcome.Address.LionSequenceNumberForVanityAddress;
            row["listOf4Lgcs"] = welcome.Address.ListOf4Lgcs;
            row["longitude"] = welcome.Address.Longitude;
            row["longitudeInternalLabel"] = welcome.Address.LongitudeInternalLabel;
            row["lowBblOfThisBuildingsCondominiumUnits"] = welcome.Address.LowBblOfThisBuildingsCondominiumUnits;
            row["lowCrossStreetB5SC1"] = welcome.Address.LowCrossStreetB5Sc1;
            row["lowCrossStreetCode1"] = welcome.Address.LowCrossStreetCode1;
            row["lowCrossStreetName1"] = welcome.Address.LowCrossStreetName1;
            row["lowHouseNumberOfBlockfaceSortFormat"] = welcome.Address.LowHouseNumberOfBlockfaceSortFormat;
            row["lowHouseNumberOfDefiningAddressRange"] = welcome.Address.LowHouseNumberOfDefiningAddressRange;
            row["noCrossStreetCalculationFlag"] = welcome.Address.NoCrossStreetCalculationFlag;
            row["nta"] = welcome.Address.Nta;
            row["ntaName"] = welcome.Address.NtaName;
            row["numberOfCrossStreetB5SCsHighAddressEnd"] = welcome.Address.NumberOfCrossStreetB5SCsHighAddressEnd;
            row["numberOfCrossStreetB5SCsLowAddressEnd"] = welcome.Address.NumberOfCrossStreetB5SCsLowAddressEnd;
            row["numberOfCrossStreetsHighAddressEnd"] = welcome.Address.NumberOfCrossStreetsHighAddressEnd;
            row["numberOfCrossStreetsLowAddressEnd"] = welcome.Address.NumberOfCrossStreetsLowAddressEnd;
            row["numberOfEntriesInListOfGeographicIdentifiers"] = welcome.Address.NumberOfEntriesInListOfGeographicIdentifiers;
            row["numberOfExistingStructuresOnLot"] = welcome.Address.NumberOfExistingStructuresOnLot;
            row["numberOfStreetFrontagesOfLot"] = welcome.Address.NumberOfStreetFrontagesOfLot;
            row["physicalId"] = welcome.Address.PhysicalId;
            row["policePatrolBoroughCommand"] = welcome.Address.PolicePatrolBoroughCommand;
            row["policePrecinct"] = welcome.Address.PolicePrecinct;
            row["returnCode1a"] = welcome.Address.ReturnCode1A;
            row["returnCode1e"] = welcome.Address.ReturnCode1E;
            row["roadwayType"] = welcome.Address.RoadwayType;
            row["rpadBuildingClassificationCode"] = welcome.Address.RpadBuildingClassificationCode;
            row["rpadSelfCheckCodeForBbl"] = welcome.Address.RpadSelfCheckCodeForBbl;
            row["sanbornBoroughCode"] = welcome.Address.SanbornBoroughCode;
            row["sanbornPageNumber"] = welcome.Address.SanbornPageNumber;
            row["sanbornVolumeNumber"] = welcome.Address.SanbornVolumeNumber;
            row["sanitationCollectionSchedulingSectionAndSubsection"] = welcome.Address.SanitationCollectionSchedulingSectionAndSubsection;
            row["sanitationDistrict"] = welcome.Address.SanitationDistrict;
            row["sanitationOrganicsCollectionSchedule"] = welcome.Address.SanitationOrganicsCollectionSchedule;
            row["sanitationRecyclingCollectionSchedule"] = welcome.Address.SanitationRecyclingCollectionSchedule;
            row["sanitationRegularCollectionSchedule"] = welcome.Address.SanitationRegularCollectionSchedule;
            row["sanitationSnowPriorityCode"] = welcome.Address.SanitationSnowPriorityCode;
            row["segmentAzimuth"] = welcome.Address.SegmentAzimuth;
            row["segmentIdentifier"] = welcome.Address.SegmentIdentifier;
            row["segmentLengthInFeet"] = welcome.Address.SegmentLengthInFeet;
            row["segmentOrientation"] = welcome.Address.SegmentOrientation;
            row["segmentTypeCode"] = welcome.Address.SegmentTypeCode;
            row["sideOfStreetIndicator"] = welcome.Address.SideOfStreetIndicator;
            row["sideOfStreetOfVanityAddress"] = welcome.Address.SideOfStreetOfVanityAddress;
            row["splitLowHouseNumber"] = welcome.Address.SplitLowHouseNumber;
            row["stateSenatorialDistrict"] = welcome.Address.StateSenatorialDistrict;
            row["streetName1In"] = welcome.Address.StreetName1In;
            row["streetStatus"] = welcome.Address.StreetStatus;
            row["streetWidth"] = welcome.Address.StreetWidth;
            row["taxMapNumberSectionAndVolume"] = welcome.Address.TaxMapNumberSectionAndVolume;
            row["toLionNodeId"] = welcome.Address.ToLionNodeId;
            row["trafficDirection"] = welcome.Address.TrafficDirection;
            row["underlyingStreetCode"] = welcome.Address.UnderlyingStreetCode;
            row["uspsPreferredCityName"] = welcome.Address.UspsPreferredCityName;
            row["workAreaFormatIndicatorIn"] = welcome.Address.WorkAreaFormatIndicatorIn;
            row["xCoordinate"] = welcome.Address.XCoordinate;
            row["xCoordinateHighAddressEnd"] = welcome.Address.XCoordinateHighAddressEnd;
            row["xCoordinateLowAddressEnd"] = welcome.Address.XCoordinateLowAddressEnd;
            row["xCoordinateOfCenterofCurvature"] = welcome.Address.XCoordinateOfCenterofCurvature;
            row["yCoordinate"] = welcome.Address.YCoordinate;
            row["yCoordinateHighAddressEnd"] = welcome.Address.YCoordinateHighAddressEnd;
            row["yCoordinateLowAddressEnd"] = welcome.Address.YCoordinateLowAddressEnd;
            row["yCoordinateOfCenterofCurvature"] = welcome.Address.YCoordinateOfCenterofCurvature;
            if (welcome.Address.ZipCode != null)
            {
                row["zipCode"] = welcome.Address.ZipCode;
            }
            else
            {
                row["zipCode"] = DBNull.Value;
            }

            table.Rows.Add(row);
        }
        #endregion
    }
}
