# Org.OpenAPITools.Model.Station
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **int** | unique identifier representing a specific railway station | [optional] 
**Name** | **string** | the stations name | [optional] 
**MailingAdress** | [**Address**](Address.md) |  | [optional] 
**Category** | **int** | the stations category (-1...7). Stations with category -1 or 0 are not in production, e.g. planned, saled, without train stops. | [optional] 
**PriceCategory** | **int** | determines in some respect the price for train stops at a specific station (1..7) | [optional] 
**FederalState** | **string** | german federal state | [optional] 
**HasParking** | **bool** | public parking y/n | [optional] 
**HasBicycleParking** | **bool** | public bicycle parking y/n | [optional] 
**HasPublicFacilities** | **bool** | public facilities y/n | [optional] 
**HasLockerSystem** | **bool** | public facilities y/n | [optional] 
**HasLocalPublicTransport** | **bool** | local public transport y/n | [optional] 
**HasTaxiRank** | **bool** | taxi rank in front of the station y/n | [optional] 
**HasTravelNecessities** | **bool** | a shop for travel necessities y/n | [optional] 
**HasSteplessAccess** | **Partial** |  | [optional] 
**HasMobilityService** | **string** | values are &#39;no&#39;, &#39;yes, advance notification is requested...&#39; or &#39;yes, advance notification is required...&#39; | [optional] 
**HasWiFi** | **bool** | public Wi-Fi is available y/n | [optional] 
**HasTravelCenter** | **bool** | local travel center y/n | [optional] 
**HasRailwayMission** | **bool** | railway mission y/n | [optional] 
**HasDBLounge** | **bool** | DB lounge y/n | [optional] 
**HasLostAndFound** | **bool** | lost and found y/n | [optional] 
**HasCarRental** | **bool** | car sharing or car rental y/n | [optional] 
**EvaNumbers** | [**List&lt;EVANumber&gt;**](EVANumber.md) | station related EVA-Numbers | [optional] 
**RiL100Identifiers** | [**List&lt;RiL100Identifier&gt;**](RiL100Identifier.md) | station related Ril100s | [optional] 
**TimetableOffice** | [**TimetableOffice**](TimetableOffice.md) |  | [optional] 
**StationManagement** | [**StationManagementRef**](StationManagementRef.md) |  | [optional] 
**LocalServiceStaff** | [**Schedule**](Schedule.md) |  | [optional] 
**DBinformation** | [**Schedule**](Schedule.md) |  | [optional] 
**Regionalbereich** | [**RegionalBereichRef**](RegionalBereichRef.md) |  | [optional] 
**Szentrale** | [**SZentraleRef**](SZentraleRef.md) |  | [optional] 
**Aufgabentraeger** | [**Aufgabentraeger**](Aufgabentraeger.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

