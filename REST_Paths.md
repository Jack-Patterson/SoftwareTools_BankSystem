# REST API Strings
You connect the strings to the main url of the Account and Transaction classes.
Where there is something like "*/{id}*" you replace it with something like "*/2*".
## Account
https://swtapi.azurewebsites.net/banksys/account/
### GetAllUsers
/GetAllUsers/
### GetUserByID
GetUserById/{Id}
### GetUserByName
GetUserByName/{Name}
### GetNameById
GetNameById/{Id}
### GetPacById
GetPacById/{Id}
### GetBalanceById
GetBalanceById/{Id}
### GetNextID
GetNextID

## Transaction
### GetAllTransactionsForID
GetAllTransactionsForID/{Id}
### CreateTransaction
CreateTransaction
(with added body)
