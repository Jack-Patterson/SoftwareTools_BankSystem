# Software Tools - Bank System

### Made by Jack Patterson, Hyden Johnson, Joe Diggins and Corey Dennison.
Basic bank system app for our Software Tools module. 

 - Project Manager/Developer - Jack Patterson
 - DevOps - Corey Dennision
 - Developer - Hyden Johnson
 - Tester - Joseph Diggins

## Code Locations
- [Main Program](https://github.com/Jack-Patterson/SoftwareTools_BankSystem/tree/main/SimpleBankApp)
- [REST API](https://github.com/Jack-Patterson/SWT_API)
- [Database Creation Script](https://github.com/Jack-Patterson/SoftwareTools_BankSystem/blob/main/DB_CreateScript.sql)

## REST API Strings
You connect the strings to the main url of the Account and Transaction classes.
Where there is something like "*/{id}*" you replace it with something like "*/2*".
And example of a full string is "*https://swtapi.azurewebsites.net/banksys/account/GetAllUsers*"
 
**Account**

https://swtapi.azurewebsites.net/banksys/account/

 - /GetAllUsers/
 - /GetUserById/{Id}
 - /GetUserByName/{Name}
 - /GetNameById/{Id}
 - /GetPacById/{Id}
 - /GetBalanceById/{Id}
 - /GetNextID/

 **Transaction**

 https://swtapi.azurewebsites.net/banksys/transaction/
 
- /GetAllTransactionsForID/{Id}
 - /CreateTransaction/ (with added body)
 - /GetNextID/
