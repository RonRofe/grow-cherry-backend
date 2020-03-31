# Backend Services Design

<img src="https://i.imgur.com/0yh63Zqr.png" width="50%" height="50%">

## Grow-Cherry Service (GCS) - 
Main Coordinator of the app (communicate with courier mobile application + Consumer web application).
Gets ALL frontend requests and delivers them to the right service.
Manages:
Authentication procedure
Shopping procedure
Configuration procedure (courier - desired location; shopper - delivery location details) 
Asks for courier desired location.
Communicates with Courier-Job-Director.
DOES NOT HANDLES DB ISSUES!!!!
Delivers Client and courier physical location

## Authentication Service - 
Gets authentication requests from GCS and handles authentication with DB-Service.
Returns a token to GCS.

## Shopping Service - 
Gets requests for shopping inventory from GCS.
Delivers shopping inventory (with barcodes) to GCS.
Responsible of the billing process with Billing Service.
Asks GCS for shopper delivery data.
Sends completed Orders to DB-Service.
Create Tasks for Courier-Job-director.
Sends Tasks to DB-Service

## Courier Job Director (CJD)- 
From GCS, gets a request gets/delivers desirable courier location 
Gets courier jobs and create a list of tasks
Responsible of managing these task - which task are taken? Which tasks were not completed? etc...
Deliver tasks to GCS.
Responsible of “cashier procedure” with Supermarket Service.
Update task state via DB Service.

## Billing Service - 
Gets Billing information from Shopping service
Handles billing authentication
Sends authorized deal to DB Service  

## DB Service - 
Gets and returns all of our data:
Authentication - Couriers and Shoppers
Shopping items (with barcodes)
Completed authenticated orders including shopper’s details
Configuration for couriers
Courier Tasks - Completed, Pending, Failed

## Supermarket Service - 
	Will be implemented in a later stage
   
