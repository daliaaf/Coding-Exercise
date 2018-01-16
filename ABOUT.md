-This application was built in a ASP.NET C# MVC 5.2 language. I have chosen ASP.NET C# MVC because I have previous work experience in ASP.NET

-This is a simple website with a single page.

- Project Structure:
CodingExercise.Business: actual Api calls to Expedia service.
CodingExercise.Model: All models (business and view...)
CodingExercise.Mapping: Have Automapping configuration and profiles
CodingExercise.Web: Have Controller and views

known issues with example. 
1- Validation to select one of the three fields (destinationName, destinationCity, & regionIds) as these are alternatives.
I think this should be done as client side - javascript, I did not implement this part. 
2- Validation to check that Min Trip Start Date is less than or equal Max Trip Start Date in case two filters are selected. 
Also "Min Trip Start Date" is greater than sysdate. I did not implement this part, and I think this should be done as client.
3- Same validation for "Min Star Rating" and "Max Star Rating" in case both are selected. 
4-I Could not find any value in the JSON output represent "min/maxTotalRate", So that i did not implement this filter -
I need the expected value for this in order create valid input text (data type, min and max value…).


