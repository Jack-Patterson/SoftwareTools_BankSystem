DROP TABLE Transactions;
DROP TABLE Accounts;

-- Create Accounts

CREATE TABLE Accounts (
  AccountID NUMERIC(4) NOT NULL UNIQUE,
  Name VARCHAR(30) NOT NULL,
  Iban VARCHAR(22) NOT NULL UNIQUE,
  Pac VARCHAR(20) NOT NULL,
  Balance Numeric(12,2),
  CONSTRAINT pk_accountID PRIMARY KEY(AccountID));

-- Create Transactions

CREATE TABLE Transactions (
  TransID NUMERIC(4) NOT NULL UNIQUE,
  TransDate Date NOT NULL,
  Amount NUMERIC(12,2) NOT NULL,
  SenderAccountID NUMERIC(4),
  ReceiverAccountID NUMERIC(4),
  CONSTRAINT pk_transID PRIMARY KEY(TransID),
  CONSTRAINT fk_senderAccountID FOREIGN KEY(SenderAccountID) REFERENCES Accounts(AccountID),
  CONSTRAINT fk_receiverAccountID FOREIGN KEY(ReceiverAccountID) REFERENCES Accounts(AccountID));
  
  -- Dummy Data
  
  DELETE FROM Accounts;
  INSERT INTO Accounts VALUES(0, 'Jack Patterson', 'IE47BOFI900017675363', '123456789', 1234.56);
  INSERT INTO Accounts VALUES(1, 'Hyden Johnson', 'IE66BOFI900017534177', '987654321', 6543.21);
  INSERT INTO Accounts VALUES(2, 'Joseph Diggins', 'IE09BOFI900017962585', 'abcdefghij', 567890.43);
  INSERT INTO Accounts VALUES(3, 'Corey Dennison', 'IE44BOFI900017295468', 'jihgfedcba', 9775403.65);
  
  DELETE FROM Transactions;
  INSERT INTO Transactions VALUES(0, '2022-10-02', 45.64, 1, 2);
  INSERT INTO Transactions VALUES(1, '2022-10-18', 3453.6, 2, 3);
  INSERT INTO Transactions VALUES(2, '2022-10-19', 3445.56, 3, 0);
  INSERT INTO Transactions VALUES(3, '2022-10-20', 974636.12, 0, 1);