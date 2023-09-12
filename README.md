# SmartWaiver.Net

SmartWaiver.Net is a SDK for the Smart Waiver electronic waiver platform.  
Specifically, this library allows you 
to fetch data on signed waivers and create auto
tagged links for waivers.

[API Documentation](https://apps.chhs.colostate.edu/docs/smartwaiver/api/index.html)

### Basic Usage

Setup the waiver object

```
ISmartWaiver smartWaiver = new SmartWaiver("apikey");
```

#### Get Details About a Signed Waiver

Gets the waiver without the PDF.

```
SignedWaiver waiver = smartWaiver.GetSignedWaiver("waiverid", false);
```

Get the waiver with a PDF
```
SignedWaiver waiver = smartWaiver.GetSignedWaiver("waiverId", true);
```

#### Generate Auto Tag Link

To track a waiver against a specific ID in your App.

```
string url = smartWaiver.GetAutoTaggedWaiverUrl("waiverId", "customerId");
```
