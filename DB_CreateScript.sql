DROP TABLE Transactions;
DROP TABLE Accounts;

-- Create Accounts

CREATE TABLE Accounts (
  AccountID NUMERIC(4) NOT NULL UNIQUE,
  Name VARCHAR(30) NOT NULL,
  Iban VARCHAR(22) NOT NULL UNIQUE,
  Pac Numeric(20) NOT NULL,
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
  INSERT INTO Accounts VALUES(0, 'Jack Patterson', 'IE47BOFI900017675363', '123456', 1234.56);
  INSERT INTO Accounts VALUES(1, 'Hyden Johnson', 'IE66BOFI900017534177', '987654', 6543.21);
  INSERT INTO Accounts VALUES(2, 'Joseph Diggins', 'IE09BOFI900017962585', '454389', 567890.43);
  INSERT INTO Accounts VALUES(3, 'Corey Dennison', 'IE44BOFI900017295468', '654321', 9775403.65);
  
  DELETE FROM Transactions;
  -- Acc 0 Transactions
  INSERT INTO Transactions VALUES(0, '2022-10-02', 45.64, 0, 1);
  INSERT INTO Transactions VALUES(1, '2022-10-02', 53453, 0, 1);
  INSERT INTO Transactions VALUES(2, '2022-10-02', 764.64, 0, 2);
  INSERT INTO Transactions VALUES(3, '2022-10-02', 64364.23, 0, 3);
  INSERT INTO Transactions VALUES(4, '2022-10-02', 43.12, 0, 3);
  
  INSERT INTO Transactions VALUES(5, '2022-10-02', 2424.23, 1, 0);
  INSERT INTO Transactions VALUES(6, '2022-10-02', 242.42, 1, 2);
  INSERT INTO Transactions VALUES(7, '2022-10-02', 5335.53, 1, 2);
  INSERT INTO Transactions VALUES(8, '2022-10-02', 24.86, 1, 3);
  INSERT INTO Transactions VALUES(9, '2022-10-02', 909.41, 1, 2);
  
  INSERT INTO Transactions VALUES(10, '2022-10-02', 535, 2, 0);
  INSERT INTO Transactions VALUES(11, '2022-10-02', 433.53, 2, 1);
  INSERT INTO Transactions VALUES(12, '2022-10-02', 56993, 2, 1);
  INSERT INTO Transactions VALUES(13, '2022-10-02', 2345.65, 2, 3);
  INSERT INTO Transactions VALUES(14, '2022-10-02', 984.09, 2, 0);
  
  INSERT INTO Transactions VALUES(15, '2022-10-02', 53.53, 3, 0);
  INSERT INTO Transactions VALUES(16, '2022-10-02', 52523.50, 3, 1);
  INSERT INTO Transactions VALUES(17, '2022-10-02', 985.23, 3, 0);
  INSERT INTO Transactions VALUES(18, '2022-10-02', 7655, 3, 3);
  INSERT INTO Transactions VALUES(19, '2022-10-02', 984352.59, 3, 2);