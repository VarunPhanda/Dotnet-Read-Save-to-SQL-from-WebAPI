DROP TABLE SRC_GEOCLIENT
GO
CREATE TABLE SRC_GEOCLIENT (
ID int identity,
houseNumber nvarchar(100),
street nvarchar(100),
borough nvarchar(100)
)

DELETE FROM SRC_GEOCLIENT
GO

INSERT INTO SRC_GEOCLIENT(houseNumber, street,borough)
VALUES ('465','GRAND AVENUE','BROOKLYN'),
('351','STREET','BROOKLYN'),
('89-59','165 STREET','QUEENS'),
('222','BROADWAY','MANHATTAN'),
('539','CHAUNCEY STREET','BROOKLYN'),
('1872','WEBSTER AVE','BRONX'),
('43-15','65 STREET','QUEENS'),
('7109','8TH AVENUE','BROOKLYN'),
('171','EAST 74 STREET','MANHATTAN'),
('260','WEST END AVE','MANHATTAN');


DROP TABLE [DST_GEOCLIENT]
GO
CREATE TABLE DST_GEOCLIENT (
ID int identity,
alleyCrossStreetsFlag nvarchar(100) NULL,
assemblyDistrict  nvarchar(100),
bbl  nvarchar(100),
bblBoroughCode  nvarchar(100),
bblTaxBlock  nvarchar(100),
bblTaxLot  nvarchar(100),
boardOfElectionsPreferredLgc  nvarchar(100),
boePreferredStreetName  nvarchar(100),
boePreferredstreetCode  nvarchar(100),
boroughCode1In  nvarchar(100),
buildingIdentificationNumber  nvarchar(100),
--businessImprovementDistrict  nvarchar(100),
censusBlock2000  nvarchar(100),
censusBlock2010  nvarchar(100),
censusTract1990  nvarchar(100),
censusTract2000  nvarchar(100),
censusTract2010  nvarchar(100),
cityCouncilDistrict  nvarchar(100),
civilCourtDistrict  nvarchar(100),
coincidentSegmentCount  nvarchar(100),
communityDistrict  nvarchar(100),
communityDistrictBoroughCode  nvarchar(100),
communityDistrictNumber  nvarchar(100),
communitySchoolDistrict  nvarchar(100),
condominiumBillingBbl  nvarchar(100),
congressionalDistrict  nvarchar(100),
cooperativeIdNumber  nvarchar(100),
--cornerCode  nvarchar(100),
crossStreetNamesFlagIn  nvarchar(100),
dcpCommercialStudyArea  nvarchar(100),
dcpPreferredLgc  nvarchar(100),
dotStreetLightContractorArea  nvarchar(100),
dynamicBlock  nvarchar(100),
electionDistrict  nvarchar(100),
fireBattalion  nvarchar(100),
fireCompanyNumber  nvarchar(100),
fireCompanyType  nvarchar(100),
fireDivision  nvarchar(100),
firstBoroughName  nvarchar(100),
firstStreetCode  nvarchar(100),
firstStreetNameNormalized  nvarchar(100),
fromLionNodeId  nvarchar(100),
fromPreferredLgcsFirstSetOf5  nvarchar(100),
genericId  nvarchar(100),
geosupportFunctionCode  nvarchar(100),
geosupportReturnCode  nvarchar(100),
geosupportReturnCode2  nvarchar(100),
gi5DigitStreetCode1  nvarchar(100),
gi5DigitStreetCode2  nvarchar(100),
gi5DigitStreetCode3  nvarchar(100),
gi5DigitStreetCode4  nvarchar(100),
giBoroughCode1  nvarchar(100),
giBoroughCode2  nvarchar(100),
giBoroughCode3  nvarchar(100),
giBoroughCode4  nvarchar(100),
giBuildingIdentificationNumber1  nvarchar(100),
giBuildingIdentificationNumber2  nvarchar(100),
giBuildingIdentificationNumber3  nvarchar(100),
giBuildingIdentificationNumber4  nvarchar(100),
giDcpPreferredLgc1  nvarchar(100),
giDcpPreferredLgc2  nvarchar(100),
giDcpPreferredLgc3  nvarchar(100),
giDcpPreferredLgc4  nvarchar(100),
giHighHouseNumber1  nvarchar(100),
giHighHouseNumber2  nvarchar(100),
giHighHouseNumber3  nvarchar(100),
giHighHouseNumber4  nvarchar(100),
giLowHouseNumber1  nvarchar(100),
giLowHouseNumber2  nvarchar(100),
giLowHouseNumber3  nvarchar(100),
giLowHouseNumber4  nvarchar(100),
giSideOfStreetIndicator1  nvarchar(100),
giSideOfStreetIndicator2  nvarchar(100),
giSideOfStreetIndicator3  nvarchar(100),
giSideOfStreetIndicator4  nvarchar(100),
giStreetCode1  nvarchar(100),
giStreetCode2  nvarchar(100),
giStreetCode3  nvarchar(100),
giStreetCode4  nvarchar(100),
giStreetName1  nvarchar(100),
giStreetName2  nvarchar(100),
giStreetName3  nvarchar(100),
giStreetName4  nvarchar(100),
healthArea  nvarchar(100),
healthCenterDistrict  nvarchar(100),
highBblOfThisBuildingsCondominiumUnits  nvarchar(100),
highCrossStreetB5SC1  nvarchar(100),
--highCrossStreetB5SC2  nvarchar(100),
--highCrossStreetB5SC3  nvarchar(100),
highCrossStreetCode1  nvarchar(100),
--highCrossStreetCode2  nvarchar(100),
--highCrossStreetCode3  nvarchar(100),
highCrossStreetName1  nvarchar(100),
--highCrossStreetName2  nvarchar(100),
--highCrossStreetName3  nvarchar(100),
highHouseNumberOfBlockfaceSortFormat  nvarchar(100),
houseNumber  nvarchar(100),
houseNumberIn  nvarchar(100),
houseNumberSortFormat  nvarchar(100),
hurricaneEvacuationZone  nvarchar(100),
individualSegmentLength  nvarchar(100),
instructionalRegion  nvarchar(100),
interimAssistanceEligibilityIndicator  nvarchar(100),
internalLabelXCoordinate  nvarchar(100),
internalLabelYCoordinate  nvarchar(100),
latitude int,
latitudeInternalLabel  int,
legacySegmentId  nvarchar(100),
lionBoroughCode  nvarchar(100),
lionBoroughCodeForVanityAddress  nvarchar(100),
lionFaceCode  nvarchar(100),
lionFaceCodeForVanityAddress  nvarchar(100),
lionKey  nvarchar(100),
lionKeyForVanityAddress  nvarchar(100),
lionSequenceNumber  nvarchar(100),
lionSequenceNumberForVanityAddress  nvarchar(100),
listOf4Lgcs  nvarchar(100),
longitude  int,
longitudeInternalLabel  int,
lowBblOfThisBuildingsCondominiumUnits  nvarchar(100),
lowCrossStreetB5SC1  nvarchar(100),
lowCrossStreetCode1  nvarchar(100),
lowCrossStreetName1  nvarchar(100),
lowHouseNumberOfBlockfaceSortFormat  nvarchar(100),
lowHouseNumberOfDefiningAddressRange  nvarchar(100),
noCrossStreetCalculationFlag  nvarchar(100),
nta  nvarchar(100),
ntaName  nvarchar(100),
numberOfCrossStreetB5SCsHighAddressEnd  nvarchar(100),
numberOfCrossStreetB5SCsLowAddressEnd  nvarchar(100),
numberOfCrossStreetsHighAddressEnd  nvarchar(100),
numberOfCrossStreetsLowAddressEnd  nvarchar(100),
numberOfEntriesInListOfGeographicIdentifiers  nvarchar(100),
numberOfExistingStructuresOnLot  nvarchar(100),
numberOfStreetFrontagesOfLot  nvarchar(100),
physicalId  nvarchar(100),
policePatrolBoroughCommand  nvarchar(100),
policePrecinct  nvarchar(100),
returnCode1a  nvarchar(100),
returnCode1e  nvarchar(100),
roadwayType  nvarchar(100),
rpadBuildingClassificationCode  nvarchar(100),
rpadSelfCheckCodeForBbl  nvarchar(100),
sanbornBoroughCode  nvarchar(100),
sanbornPageNumber  nvarchar(100),
sanbornVolumeNumber  nvarchar(100),
--sanbornVolumeNumberSuffix  nvarchar(100),
sanitationCollectionSchedulingSectionAndSubsection  nvarchar(100),
sanitationDistrict  nvarchar(100),
sanitationOrganicsCollectionSchedule  nvarchar(100),
sanitationRecyclingCollectionSchedule  nvarchar(100),
sanitationRegularCollectionSchedule  nvarchar(100),
sanitationSnowPriorityCode  nvarchar(100),
segmentAzimuth  nvarchar(100),
segmentIdentifier  nvarchar(100),
segmentLengthInFeet  nvarchar(100),
segmentOrientation  nvarchar(100),
segmentTypeCode  nvarchar(100),
sideOfStreetIndicator  nvarchar(100),
sideOfStreetOfVanityAddress  nvarchar(100),
splitLowHouseNumber  nvarchar(100),
stateSenatorialDistrict  nvarchar(100),
streetName1In  nvarchar(100),
streetStatus  nvarchar(100),
streetWidth  nvarchar(100),
taxMapNumberSectionAndVolume  nvarchar(100),
toLionNodeId  nvarchar(100),
--toPreferredLgcsFirstSetOf5  nvarchar(100),
trafficDirection  nvarchar(100),
underlyingStreetCode  nvarchar(100),
uspsPreferredCityName  nvarchar(100),
workAreaFormatIndicatorIn  nvarchar(100),
xCoordinate  nvarchar(100),
xCoordinateHighAddressEnd  nvarchar(100),
xCoordinateLowAddressEnd  nvarchar(100),
xCoordinateOfCenterofCurvature  nvarchar(100),
yCoordinate  nvarchar(100),
yCoordinateHighAddressEnd  nvarchar(100),
yCoordinateLowAddressEnd  nvarchar(100),
yCoordinateOfCenterofCurvature  nvarchar(100),
zipCode  nvarchar(100),
)
GO


DROP PROCEDURE [dbo].[InsertGeoClientDestination]
GO
DROP TYPE [dbo].[TB_DST_GEOCLIENT]
GO
CREATE TYPE [dbo].[TB_DST_GEOCLIENT] AS TABLE(
	[alleyCrossStreetsFlag] [nvarchar](100) NULL,
	[assemblyDistrict] [nvarchar](100) NULL,
	[bbl] [nvarchar](100) NULL,
	[bblBoroughCode] [nvarchar](100) NULL,
	[bblTaxBlock] [nvarchar](100) NULL,
	[bblTaxLot] [nvarchar](100) NULL,
	[boardOfElectionsPreferredLgc] [nvarchar](100) NULL,
	[boePreferredStreetName] [nvarchar](100) NULL,
	[boePreferredstreetCode] [nvarchar](100) NULL,
	[boroughCode1In] [nvarchar](100) NULL,
	[buildingIdentificationNumber] [nvarchar](100) NULL,
	[censusBlock2000] [nvarchar](100) NULL,
	[censusBlock2010] [nvarchar](100) NULL,
	[censusTract1990] [nvarchar](100) NULL,
	[censusTract2000] [nvarchar](100) NULL,
	[censusTract2010] [nvarchar](100) NULL,
	[cityCouncilDistrict] [nvarchar](100) NULL,
	[civilCourtDistrict] [nvarchar](100) NULL,
	[coincidentSegmentCount] [nvarchar](100) NULL,
	[communityDistrict] [nvarchar](100) NULL,
	[communityDistrictBoroughCode] [nvarchar](100) NULL,
	[communityDistrictNumber] [nvarchar](100) NULL,
	[communitySchoolDistrict] [nvarchar](100) NULL,
	[condominiumBillingBbl] [nvarchar](100) NULL,
	[congressionalDistrict] [nvarchar](100) NULL,
	[cooperativeIdNumber] [nvarchar](100) NULL,
	[crossStreetNamesFlagIn] [nvarchar](100) NULL,
	[dcpCommercialStudyArea] [nvarchar](100) NULL,
	[dcpPreferredLgc] [nvarchar](100) NULL,
	[dotStreetLightContractorArea] [nvarchar](100) NULL,
	[dynamicBlock] [nvarchar](100) NULL,
	[electionDistrict] [nvarchar](100) NULL,
	[fireBattalion] [nvarchar](100) NULL,
	[fireCompanyNumber] [nvarchar](100) NULL,
	[fireCompanyType] [nvarchar](100) NULL,
	[fireDivision] [nvarchar](100) NULL,
	[firstBoroughName] [nvarchar](100) NULL,
	[firstStreetCode] [nvarchar](100) NULL,
	[firstStreetNameNormalized] [nvarchar](100) NULL,
	[fromLionNodeId] [nvarchar](100) NULL,
	[fromPreferredLgcsFirstSetOf5] [nvarchar](100) NULL,
	[genericId] [nvarchar](100) NULL,
	[geosupportFunctionCode] [nvarchar](100) NULL,
	[geosupportReturnCode] [nvarchar](100) NULL,
	[geosupportReturnCode2] [nvarchar](100) NULL,
	[gi5DigitStreetCode1] [nvarchar](100) NULL,
	[gi5DigitStreetCode2] [nvarchar](100) NULL,
	[gi5DigitStreetCode3] [nvarchar](100) NULL,
	[gi5DigitStreetCode4] [nvarchar](100) NULL,
	[giBoroughCode1] [nvarchar](100) NULL,
	[giBoroughCode2] [nvarchar](100) NULL,
	[giBoroughCode3] [nvarchar](100) NULL,
	[giBoroughCode4] [nvarchar](100) NULL,
	[giBuildingIdentificationNumber1] [nvarchar](100) NULL,
	[giBuildingIdentificationNumber2] [nvarchar](100) NULL,
	[giBuildingIdentificationNumber3] [nvarchar](100) NULL,
	[giBuildingIdentificationNumber4] [nvarchar](100) NULL,
	[giDcpPreferredLgc1] [nvarchar](100) NULL,
	[giDcpPreferredLgc2] [nvarchar](100) NULL,
	[giDcpPreferredLgc3] [nvarchar](100) NULL,
	[giDcpPreferredLgc4] [nvarchar](100) NULL,
	[giHighHouseNumber1] [nvarchar](100) NULL,
	[giHighHouseNumber2] [nvarchar](100) NULL,
	[giHighHouseNumber3] [nvarchar](100) NULL,
	[giHighHouseNumber4] [nvarchar](100) NULL,
	[giLowHouseNumber1] [nvarchar](100) NULL,
	[giLowHouseNumber2] [nvarchar](100) NULL,
	[giLowHouseNumber3] [nvarchar](100) NULL,
	[giLowHouseNumber4] [nvarchar](100) NULL,
	[giSideOfStreetIndicator1] [nvarchar](100) NULL,
	[giSideOfStreetIndicator2] [nvarchar](100) NULL,
	[giSideOfStreetIndicator3] [nvarchar](100) NULL,
	[giSideOfStreetIndicator4] [nvarchar](100) NULL,
	[giStreetCode1] [nvarchar](100) NULL,
	[giStreetCode2] [nvarchar](100) NULL,
	[giStreetCode3] [nvarchar](100) NULL,
	[giStreetCode4] [nvarchar](100) NULL,
	[giStreetName1] [nvarchar](100) NULL,
	[giStreetName2] [nvarchar](100) NULL,
	[giStreetName3] [nvarchar](100) NULL,
	[giStreetName4] [nvarchar](100) NULL,
	[healthArea] [nvarchar](100) NULL,
	[healthCenterDistrict] [nvarchar](100) NULL,
	[highBblOfThisBuildingsCondominiumUnits] [nvarchar](100) NULL,
	[highCrossStreetB5SC1] [nvarchar](100) NULL,
	[highCrossStreetCode1] [nvarchar](100) NULL,
	[highCrossStreetName1] [nvarchar](100) NULL,
	[highHouseNumberOfBlockfaceSortFormat] [nvarchar](100) NULL,
	[houseNumber] [nvarchar](100) NULL,
	[houseNumberIn] [nvarchar](100) NULL,
	[houseNumberSortFormat] [nvarchar](100) NULL,
	[hurricaneEvacuationZone] [nvarchar](100) NULL,
	[individualSegmentLength] [nvarchar](100) NULL,
	[instructionalRegion] [nvarchar](100) NULL,
	[interimAssistanceEligibilityIndicator] [nvarchar](100) NULL,
	[internalLabelXCoordinate] [nvarchar](100) NULL,
	[internalLabelYCoordinate] [nvarchar](100) NULL,
	[latitude] [int] NULL,
	[latitudeInternalLabel] [int] NULL,
	[legacySegmentId] [nvarchar](100) NULL,
	[lionBoroughCode] [nvarchar](100) NULL,
	[lionBoroughCodeForVanityAddress] [nvarchar](100) NULL,
	[lionFaceCode] [nvarchar](100) NULL,
	[lionFaceCodeForVanityAddress] [nvarchar](100) NULL,
	[lionKey] [nvarchar](100) NULL,
	[lionKeyForVanityAddress] [nvarchar](100) NULL,
	[lionSequenceNumber] [nvarchar](100) NULL,
	[lionSequenceNumberForVanityAddress] [nvarchar](100) NULL,
	[listOf4Lgcs] [nvarchar](100) NULL,
	[longitude] [int] NULL,
	[longitudeInternalLabel] [int] NULL,
	[lowBblOfThisBuildingsCondominiumUnits] [nvarchar](100) NULL,
	[lowCrossStreetB5SC1] [nvarchar](100) NULL,
	[lowCrossStreetCode1] [nvarchar](100) NULL,
	[lowCrossStreetName1] [nvarchar](100) NULL,
	[lowHouseNumberOfBlockfaceSortFormat] [nvarchar](100) NULL,
	[lowHouseNumberOfDefiningAddressRange] [nvarchar](100) NULL,
	[noCrossStreetCalculationFlag] [nvarchar](100) NULL,
	[nta] [nvarchar](100) NULL,
	[ntaName] [nvarchar](100) NULL,
	[numberOfCrossStreetB5SCsHighAddressEnd] [nvarchar](100) NULL,
	[numberOfCrossStreetB5SCsLowAddressEnd] [nvarchar](100) NULL,
	[numberOfCrossStreetsHighAddressEnd] [nvarchar](100) NULL,
	[numberOfCrossStreetsLowAddressEnd] [nvarchar](100) NULL,
	[numberOfEntriesInListOfGeographicIdentifiers] [nvarchar](100) NULL,
	[numberOfExistingStructuresOnLot] [nvarchar](100) NULL,
	[numberOfStreetFrontagesOfLot] [nvarchar](100) NULL,
	[physicalId] [nvarchar](100) NULL,
	[policePatrolBoroughCommand] [nvarchar](100) NULL,
	[policePrecinct] [nvarchar](100) NULL,
	[returnCode1a] [nvarchar](100) NULL,
	[returnCode1e] [nvarchar](100) NULL,
	[roadwayType] [nvarchar](100) NULL,
	[rpadBuildingClassificationCode] [nvarchar](100) NULL,
	[rpadSelfCheckCodeForBbl] [nvarchar](100) NULL,
	[sanbornBoroughCode] [nvarchar](100) NULL,
	[sanbornPageNumber] [nvarchar](100) NULL,
	[sanbornVolumeNumber] [nvarchar](100) NULL,
	[sanitationCollectionSchedulingSectionAndSubsection] [nvarchar](100) NULL,
	[sanitationDistrict] [nvarchar](100) NULL,
	[sanitationOrganicsCollectionSchedule] [nvarchar](100) NULL,
	[sanitationRecyclingCollectionSchedule] [nvarchar](100) NULL,
	[sanitationRegularCollectionSchedule] [nvarchar](100) NULL,
	[sanitationSnowPriorityCode] [nvarchar](100) NULL,
	[segmentAzimuth] [nvarchar](100) NULL,
	[segmentIdentifier] [nvarchar](100) NULL,
	[segmentLengthInFeet] [nvarchar](100) NULL,
	[segmentOrientation] [nvarchar](100) NULL,
	[segmentTypeCode] [nvarchar](100) NULL,
	[sideOfStreetIndicator] [nvarchar](100) NULL,
	[sideOfStreetOfVanityAddress] [nvarchar](100) NULL,
	[splitLowHouseNumber] [nvarchar](100) NULL,
	[stateSenatorialDistrict] [nvarchar](100) NULL,
	[streetName1In] [nvarchar](100) NULL,
	[streetStatus] [nvarchar](100) NULL,
	[streetWidth] [nvarchar](100) NULL,
	[taxMapNumberSectionAndVolume] [nvarchar](100) NULL,
	[toLionNodeId] [nvarchar](100) NULL,
	[trafficDirection] [nvarchar](100) NULL,
	[underlyingStreetCode] [nvarchar](100) NULL,
	[uspsPreferredCityName] [nvarchar](100) NULL,
	[workAreaFormatIndicatorIn] [nvarchar](100) NULL,
	[xCoordinate] [nvarchar](100) NULL,
	[xCoordinateHighAddressEnd] [nvarchar](100) NULL,
	[xCoordinateLowAddressEnd] [nvarchar](100) NULL,
	[xCoordinateOfCenterofCurvature] [nvarchar](100) NULL,
	[yCoordinate] [nvarchar](100) NULL,
	[yCoordinateHighAddressEnd] [nvarchar](100) NULL,
	[yCoordinateLowAddressEnd] [nvarchar](100) NULL,
	[yCoordinateOfCenterofCurvature] [nvarchar](100) NULL,
	[zipCode] [nvarchar](100) NULL
)
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertGeoClientDestination]
@dtGeoClient dbo.TB_DST_GEOCLIENT READONLY
AS
BEGIN
INSERT INTO [dbo].[DST_GEOCLIENT]
           ([alleyCrossStreetsFlag],
			[assemblyDistrict]
           ,[bbl]
           ,[bblBoroughCode]
           ,[bblTaxBlock]
           ,[bblTaxLot]
           ,[boardOfElectionsPreferredLgc]
           ,[boePreferredStreetName]
           ,[boePreferredstreetCode]
           ,[boroughCode1In]
           ,[buildingIdentificationNumber]
           --,[businessImprovementDistrict]
           ,[censusBlock2000]
           ,[censusBlock2010]
           ,[censusTract1990]
           ,[censusTract2000]
           ,[censusTract2010]
           ,[cityCouncilDistrict]
           ,[civilCourtDistrict]
           ,[coincidentSegmentCount]
           ,[communityDistrict]
           ,[communityDistrictBoroughCode]
           ,[communityDistrictNumber]
           ,[communitySchoolDistrict]
           ,[condominiumBillingBbl]
           ,[congressionalDistrict]
           ,[cooperativeIdNumber]
           --,[cornerCode]
           ,[crossStreetNamesFlagIn]
           ,[dcpCommercialStudyArea]
           ,[dcpPreferredLgc]
           ,[dotStreetLightContractorArea]
           ,[dynamicBlock]
           ,[electionDistrict]
           ,[fireBattalion]
           ,[fireCompanyNumber]
           ,[fireCompanyType]
           ,[fireDivision]
           ,[firstBoroughName]
           ,[firstStreetCode]
           ,[firstStreetNameNormalized]
           ,[fromLionNodeId]
           ,[fromPreferredLgcsFirstSetOf5]
           ,[genericId]
           ,[geosupportFunctionCode]
           ,[geosupportReturnCode]
           ,[geosupportReturnCode2]
           ,[gi5DigitStreetCode1]
           ,[gi5DigitStreetCode2]
           ,[gi5DigitStreetCode3]
           ,[gi5DigitStreetCode4]
           ,[giBoroughCode1]
           ,[giBoroughCode2]
           ,[giBoroughCode3]
           ,[giBoroughCode4]
           ,[giBuildingIdentificationNumber1]
           ,[giBuildingIdentificationNumber2]
           ,[giBuildingIdentificationNumber3]
           ,[giBuildingIdentificationNumber4]
           ,[giDcpPreferredLgc1]
           ,[giDcpPreferredLgc2]
           ,[giDcpPreferredLgc3]
           ,[giDcpPreferredLgc4]
           ,[giHighHouseNumber1]
           ,[giHighHouseNumber2]
           ,[giHighHouseNumber3]
           ,[giHighHouseNumber4]
           ,[giLowHouseNumber1]
           ,[giLowHouseNumber2]
           ,[giLowHouseNumber3]
           ,[giLowHouseNumber4]
           ,[giSideOfStreetIndicator1]
           ,[giSideOfStreetIndicator2]
           ,[giSideOfStreetIndicator3]
           ,[giSideOfStreetIndicator4]
           ,[giStreetCode1]
           ,[giStreetCode2]
           ,[giStreetCode3]
           ,[giStreetCode4]
           ,[giStreetName1]
           ,[giStreetName2]
           ,[giStreetName3]
           ,[giStreetName4]
           ,[healthArea]
           ,[healthCenterDistrict]
           ,[highBblOfThisBuildingsCondominiumUnits]
           ,[highCrossStreetB5SC1]
           --,[highCrossStreetB5SC2]
           --,[highCrossStreetB5SC3]
           ,[highCrossStreetCode1]
           --,[highCrossStreetCode2]
           --,[highCrossStreetCode3]
           ,[highCrossStreetName1]
           --,[highCrossStreetName2]
           --,[highCrossStreetName3]
           ,[highHouseNumberOfBlockfaceSortFormat]
           ,[houseNumber]
           ,[houseNumberIn]
           ,[houseNumberSortFormat]
           ,[hurricaneEvacuationZone]
		   ,[individualSegmentLength]
           ,[instructionalRegion]
           ,[interimAssistanceEligibilityIndicator]
           ,[internalLabelXCoordinate]
           ,[internalLabelYCoordinate]
           ,[latitude]
           ,[latitudeInternalLabel]
           ,[legacySegmentId]
           ,[lionBoroughCode]
           ,[lionBoroughCodeForVanityAddress]
           ,[lionFaceCode]
           ,[lionFaceCodeForVanityAddress]
           ,[lionKey]
           ,[lionKeyForVanityAddress]
           ,[lionSequenceNumber]
           ,[lionSequenceNumberForVanityAddress]
           ,[listOf4Lgcs]
           ,[longitude]
           ,[longitudeInternalLabel]
           ,[lowBblOfThisBuildingsCondominiumUnits]
           ,[lowCrossStreetB5SC1]
           ,[lowCrossStreetCode1]
           ,[lowCrossStreetName1]
           ,[lowHouseNumberOfBlockfaceSortFormat]
           ,[lowHouseNumberOfDefiningAddressRange]
		   ,[noCrossStreetCalculationFlag]
           ,[nta]
           ,[ntaName]
           ,[numberOfCrossStreetB5SCsHighAddressEnd]
           ,[numberOfCrossStreetB5SCsLowAddressEnd]
           ,[numberOfCrossStreetsHighAddressEnd]
           ,[numberOfCrossStreetsLowAddressEnd]
           ,[numberOfEntriesInListOfGeographicIdentifiers]
           ,[numberOfExistingStructuresOnLot]
           ,[numberOfStreetFrontagesOfLot]
           ,[physicalId]
           ,[policePatrolBoroughCommand]
           ,[policePrecinct]
           ,[returnCode1a]
           ,[returnCode1e]
           ,[roadwayType]
           ,[rpadBuildingClassificationCode]
           ,[rpadSelfCheckCodeForBbl]
           ,[sanbornBoroughCode]
           ,[sanbornPageNumber]
           ,[sanbornVolumeNumber]
           --,[sanbornVolumeNumberSuffix]
           ,[sanitationCollectionSchedulingSectionAndSubsection]
           ,[sanitationDistrict]
		   ,[sanitationOrganicsCollectionSchedule]
           ,[sanitationRecyclingCollectionSchedule]
           ,[sanitationRegularCollectionSchedule]
           ,[sanitationSnowPriorityCode]
           ,[segmentAzimuth]
           ,[segmentIdentifier]
           ,[segmentLengthInFeet]
           ,[segmentOrientation]
           ,[segmentTypeCode]
           ,[sideOfStreetIndicator]
           ,[sideOfStreetOfVanityAddress]
           ,[splitLowHouseNumber]
           ,[stateSenatorialDistrict]
           ,[streetName1In]
           ,[streetStatus]
           ,[streetWidth]
           ,[taxMapNumberSectionAndVolume]
           ,[toLionNodeId]
           --,[toPreferredLgcsFirstSetOf5]
           ,[trafficDirection]
           ,[underlyingStreetCode]
           ,[uspsPreferredCityName]
           ,[workAreaFormatIndicatorIn]
           ,[xCoordinate]
           ,[xCoordinateHighAddressEnd]
           ,[xCoordinateLowAddressEnd]
           ,[xCoordinateOfCenterofCurvature]
           ,[yCoordinate]
           ,[yCoordinateHighAddressEnd]
           ,[yCoordinateLowAddressEnd]
           ,[yCoordinateOfCenterofCurvature]
           ,[zipCode]) 
		SELECT [alleyCrossStreetsFlag],
			[assemblyDistrict]
           ,[bbl]
           ,[bblBoroughCode]
           ,[bblTaxBlock]
           ,[bblTaxLot]
           ,[boardOfElectionsPreferredLgc]
           ,[boePreferredStreetName]
           ,[boePreferredstreetCode]
           ,[boroughCode1In]
           ,[buildingIdentificationNumber]
           --,[businessImprovementDistrict]
           ,[censusBlock2000]
           ,[censusBlock2010]
           ,[censusTract1990]
           ,[censusTract2000]
           ,[censusTract2010]
           ,[cityCouncilDistrict]
           ,[civilCourtDistrict]
           ,[coincidentSegmentCount]
           ,[communityDistrict]
           ,[communityDistrictBoroughCode]
           ,[communityDistrictNumber]
           ,[communitySchoolDistrict]
           ,[condominiumBillingBbl]
           ,[congressionalDistrict]
           ,[cooperativeIdNumber]
           --,[cornerCode]
           ,[crossStreetNamesFlagIn]
           ,[dcpCommercialStudyArea]
           ,[dcpPreferredLgc]
           ,[dotStreetLightContractorArea]
           ,[dynamicBlock]
           ,[electionDistrict]
           ,[fireBattalion]
           ,[fireCompanyNumber]
           ,[fireCompanyType]
           ,[fireDivision]
           ,[firstBoroughName]
           ,[firstStreetCode]
           ,[firstStreetNameNormalized]
           ,[fromLionNodeId]
           ,[fromPreferredLgcsFirstSetOf5]
           ,[genericId]
           ,[geosupportFunctionCode]
           ,[geosupportReturnCode]
           ,[geosupportReturnCode2]
           ,[gi5DigitStreetCode1]
           ,[gi5DigitStreetCode2]
           ,[gi5DigitStreetCode3]
           ,[gi5DigitStreetCode4]
           ,[giBoroughCode1]
           ,[giBoroughCode2]
           ,[giBoroughCode3]
           ,[giBoroughCode4]
           ,[giBuildingIdentificationNumber1]
           ,[giBuildingIdentificationNumber2]
           ,[giBuildingIdentificationNumber3]
           ,[giBuildingIdentificationNumber4]
           ,[giDcpPreferredLgc1]
           ,[giDcpPreferredLgc2]
           ,[giDcpPreferredLgc3]
           ,[giDcpPreferredLgc4]
           ,[giHighHouseNumber1]
           ,[giHighHouseNumber2]
           ,[giHighHouseNumber3]
           ,[giHighHouseNumber4]
           ,[giLowHouseNumber1]
           ,[giLowHouseNumber2]
           ,[giLowHouseNumber3]
           ,[giLowHouseNumber4]
           ,[giSideOfStreetIndicator1]
           ,[giSideOfStreetIndicator2]
           ,[giSideOfStreetIndicator3]
           ,[giSideOfStreetIndicator4]
           ,[giStreetCode1]
           ,[giStreetCode2]
           ,[giStreetCode3]
           ,[giStreetCode4]
           ,[giStreetName1]
           ,[giStreetName2]
           ,[giStreetName3]
           ,[giStreetName4]
           ,[healthArea]
           ,[healthCenterDistrict]
           ,[highBblOfThisBuildingsCondominiumUnits]
           ,[highCrossStreetB5SC1]
           --,[highCrossStreetB5SC2]
           --,[highCrossStreetB5SC3]
           ,[highCrossStreetCode1]
           --,[highCrossStreetCode2]
           --,[highCrossStreetCode3]
           ,[highCrossStreetName1]
           --,[highCrossStreetName2]
           --,[highCrossStreetName3]
           ,[highHouseNumberOfBlockfaceSortFormat]
           ,[houseNumber]
           ,[houseNumberIn]
           ,[houseNumberSortFormat]
           ,[hurricaneEvacuationZone]
		   ,[individualSegmentLength]
           ,[instructionalRegion]
           ,[interimAssistanceEligibilityIndicator]
           ,[internalLabelXCoordinate]
           ,[internalLabelYCoordinate]
           ,[latitude]
           ,[latitudeInternalLabel]
           ,[legacySegmentId]
           ,[lionBoroughCode]
           ,[lionBoroughCodeForVanityAddress]
           ,[lionFaceCode]
           ,[lionFaceCodeForVanityAddress]
           ,[lionKey]
           ,[lionKeyForVanityAddress]
           ,[lionSequenceNumber]
           ,[lionSequenceNumberForVanityAddress]
           ,[listOf4Lgcs]
           ,[longitude]
           ,[longitudeInternalLabel]
           ,[lowBblOfThisBuildingsCondominiumUnits]
           ,[lowCrossStreetB5SC1]
           ,[lowCrossStreetCode1]
           ,[lowCrossStreetName1]
           ,[lowHouseNumberOfBlockfaceSortFormat]
           ,[lowHouseNumberOfDefiningAddressRange]
		   ,[noCrossStreetCalculationFlag]
           ,[nta]
           ,[ntaName]
           ,[numberOfCrossStreetB5SCsHighAddressEnd]
           ,[numberOfCrossStreetB5SCsLowAddressEnd]
           ,[numberOfCrossStreetsHighAddressEnd]
           ,[numberOfCrossStreetsLowAddressEnd]
           ,[numberOfEntriesInListOfGeographicIdentifiers]
           ,[numberOfExistingStructuresOnLot]
           ,[numberOfStreetFrontagesOfLot]
           ,[physicalId]
           ,[policePatrolBoroughCommand]
           ,[policePrecinct]
           ,[returnCode1a]
           ,[returnCode1e]
           ,[roadwayType]
           ,[rpadBuildingClassificationCode]
           ,[rpadSelfCheckCodeForBbl]
           ,[sanbornBoroughCode]
           ,[sanbornPageNumber]
           ,[sanbornVolumeNumber]
           --,[sanbornVolumeNumberSuffix]
           ,[sanitationCollectionSchedulingSectionAndSubsection]
           ,[sanitationDistrict]
		   ,[sanitationOrganicsCollectionSchedule]
           ,[sanitationRecyclingCollectionSchedule]
           ,[sanitationRegularCollectionSchedule]
           ,[sanitationSnowPriorityCode]
           ,[segmentAzimuth]
           ,[segmentIdentifier]
           ,[segmentLengthInFeet]
           ,[segmentOrientation]
           ,[segmentTypeCode]
           ,[sideOfStreetIndicator]
           ,[sideOfStreetOfVanityAddress]
           ,[splitLowHouseNumber]
           ,[stateSenatorialDistrict]
           ,[streetName1In]
           ,[streetStatus]
           ,[streetWidth]
           ,[taxMapNumberSectionAndVolume]
           ,[toLionNodeId]
           --,[toPreferredLgcsFirstSetOf5]
           ,[trafficDirection]
           ,[underlyingStreetCode]
           ,[uspsPreferredCityName]
           ,[workAreaFormatIndicatorIn]
           ,[xCoordinate]
           ,[xCoordinateHighAddressEnd]
           ,[xCoordinateLowAddressEnd]
           ,[xCoordinateOfCenterofCurvature]
           ,[yCoordinate]
           ,[yCoordinateHighAddressEnd]
           ,[yCoordinateLowAddressEnd]
           ,[yCoordinateOfCenterofCurvature]
           ,[zipCode]
  FROM @dtGeoClient
END
