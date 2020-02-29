# Weather API Project

### API testing on OpenWeatherAPI - Console Application, Unit Test & RESTFul API

# Table of Contents:

[Description](#Description)  
<a name="Description"/>

[Prerequisites](#Prerequisites)  
<a name="Prerequisites"/>

[What I learnt](#What_I_Learnt)  
<a name="What_I_Learnt"/>

[Setup](#Setup)  
<a name="Setup"/>

[Test Cases](#Test_Cases)  
<a name="Test_Cases"/>

[Development Changes](#Development_Changes)  
<a name="Development_Changes"/>

[Resources](#Resources)  
<a name="Resources"/>

[Screenshots](#Screenshots)
<a name="Screenshots"/>

[Credits](#Credits)  
<a name="Credits"/>

### Description: 

I mainly created this project to teach myself how to test API's and gain a better understanding of unit testing. This project is meant to test the OpenWeatherAPI. I have to test data that matches with the data gathered from the API using Postman as JSON. Postman allows me to check the data that is sent and delivered using this application and I can check the data using RAW, JSON, and other types.


### Prerequisites:
You will need the following software installed to be able to use the application:
- Postman
- Gitbash
- Visual Studio 2017 or higher

Please note that Visual Studio requires a lot of space on the hardrive and requires a good CPU for better performance

### What I learnt
- Better understanding of JSON
- Better understanding of XML
- Unit Testing
- GET and POST
- Debugging test casses
- Better understanding of deserialize

### Setup:

This is a step by step example that tells you how to get the development enviroment running:

- Step 1: Create account on OpenWeatherAPI to get key 
- Step 2: open Visual Studio
- Step 3: Create new Project, based on Class Libary or Console APP (both have to be .NET Framework) 
- Step 4: Create Two Folder: Tests and Folder Based on API (E.g. OpenWeatherMap_Forecast)
- Step 5: Inside Folder Based on API, Create two folder: Data_Handling and HTTP_Maanger
- Step 6: Inside Data_Handling Folder, Create two C# File: E.g. OpenWeatherMapDTO.cs and OpenWeatherMapModel.cs
- Step 7: Inside HTTP_Folder, Create one C# File: E.g. OpenWeatherMapCallManager.cs
- Step 8: Inside OpenWeatherMap_Forecast Folder, Create one C# File E.g. OpenWeatherMapService.cs
- Step 9: Inside Tests Folder, Create one C# File: E.g. OpenWeatherMapTest.cs
- Step 10: Create two C# File on Package: E.g. App.config and OpenWeatherMapConfig.cs
- Step 11: Right click on Reference then Add Reference then Assembiles option and look for System.Configuration (make sure to tick the box and press ok)
- step 11: Right click on Package then select Manage Nuget Packages then click on browse and install Nunit, Nunit3TestAdapter, Newtonsoft.Json and RestSharp
- Step 12: Use API with API key (check Step 0) on Postman to get the data as JSON

### Test Cases:

### Development Changes:
- Date: 01/02/20
- Title: Completed tests

Summary: All tests were finished and and fixes towards some bugs. Their won't be anymore updates in the development changes log. In the final unit test only four failed while the rest worked. The development went smoothly and the API key did not expire. I did also rename some variables to make it easier for people to see my work.

### Resources:
- https://docs.microsoft.com/en-us/dotnet/csharp/
- https://www.getpostman.com/
- https://visualstudio.microsoft.com/

### Screenshots:
![IMG002](https://user-images.githubusercontent.com/45819118/73599737-a9f64780-453e-11ea-9455-c37c43f7eb57.PNG)
![IMG001](https://user-images.githubusercontent.com/45819118/73599738-a9f64780-453e-11ea-9a9a-9f88b14cfe0f.PNG)


### Credits:
Gulam Qasim
