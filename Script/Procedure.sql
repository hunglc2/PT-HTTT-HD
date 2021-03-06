USE [BANK_MANAGEMENT]
GO
ALTER PROC CREATE_OWNER
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@IDOWNER INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @NAME = [Name], @IDOWNER = [idOWNER] 
	FROM [dbo].[OWNER_TEMP];

	--KIEM TRA CO TON TAI CHUA
	IF NOT EXISTS (SELECT TOP 1 IDOWNER FROM OWNER WHERE NAME = @NAME)
	BEGIN
		INSERT INTO OWNER(NAME, ADDRESS, PHONE, FAX, CREATED_BY, LAST_UPDATE_BY, CREATED_DATE, LAST_UPDATE_DATE)
		SELECT NAME, ADDRESS, PHONE, FAX, CREATED_BY, LAST_UPDATE_BY, CREATED_DATE, LAST_UPDATE_DATE FROM OWNER_TEMP;
	END	

	DELETE FROM OWNER_TEMP;
END;

GO
------------------------------------------------------------------
ALTER PROC CREATE_BRANCH
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@IDBRANCH INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @NAME = [Name], @IDBRANCH = [idBranch]
	FROM [dbo].[BRANCH_TEMP];

	--KIEM TRA CO TON TAI CHUA
	IF NOT EXISTS (SELECT TOP 1 IDBRANCH FROM [dbo].[BRANCH] WHERE NAME = @NAME)
	BEGIN
		INSERT INTO [dbo].[BRANCH](idOWNER, Name, Address, Phone, Fax, created_by, last_update_by, created_date, last_update_date)
		SELECT idOWNER, Name, Address, Phone, Fax, created_by, last_update_by, created_date, last_update_date FROM [dbo].[BRANCH_TEMP];
	END	

	DELETE FROM [dbo].[BRANCH_TEMP];
END;

GO
------------------------------------------------------------------
ALTER PROC CREATE_EMPLOYEE
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@IDEMPLOYEE INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @NAME = [Name], @IDEMPLOYEE = [idEMPLOYEE]
	FROM [dbo].[EMPLOYEE_TEMP];

	--KIEM TRA CO TON TAI CHUA
	IF NOT EXISTS (SELECT TOP 1 IDEMPLOYEE FROM [dbo].[EMPLOYEE] WHERE NAME = @NAME)
	BEGIN
		INSERT INTO [dbo].[EMPLOYEE](idBranch, idPOSITION, Name, Address, Phone, created_by, last_update_by, created_date, last_update_date)
		SELECT idBranch, idPOSITION, Name, Address, Phone, created_by, last_update_by, created_date, last_update_date FROM [dbo].[EMPLOYEE_TEMP];
	END	

	DELETE FROM [dbo].[EMPLOYEE_TEMP];
END;

GO
------------------------------------------------------------------

ALTER PROC CREATE_POSITION_EMP
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idPOSITION INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @NAME = [Name], @idPOSITION = [idPOSITION]
	FROM [dbo].[POSITION_EMP_TEMP];

	--KIEM TRA CO TON TAI CHUA
	IF NOT EXISTS (SELECT TOP 1 [idPOSITION] FROM [dbo].[POSITION_EMP] WHERE NAME = @NAME)
	BEGIN
		INSERT INTO [dbo].[POSITION_EMP](Name, Status, Created_by, Last_update_by, Created_date, Last_update_date)
		SELECT Name, Status, Created_by, Last_update_by, Created_date, Last_update_date FROM [dbo].[POSITION_EMP_TEMP];
	END	

	DELETE FROM [dbo].[POSITION_EMP_TEMP];
END;

GO
------------------------------------------------------------------

ALTER PROC CREATE_TRANSACTION_TYPES
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idTRANSACTION_TYPES INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @NAME = [Name], @idTRANSACTION_TYPES = [idTRANSACTION_TYPES]
	FROM [dbo].[TRANSACTION_TYPES_TEMP];

	--KIEM TRA CO TON TAI CHUA
	IF NOT EXISTS (SELECT TOP 1 [idTRANSACTION_TYPES] FROM [dbo].[TRANSACTION_TYPES] WHERE NAME = @NAME)
	BEGIN
		INSERT INTO [dbo].[TRANSACTION_TYPES](Name, Status, Created_by, Last_update_by, Created_date, Last_update_date)
		SELECT Name, Status, Created_by, Last_update_by, Created_date, Last_update_date FROM [dbo].[TRANSACTION_TYPES_TEMP];
	END	

	DELETE FROM [dbo].[TRANSACTION_TYPES_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_TRANSACTIONS
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idTRANSACTIONS INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idTRANSACTIONS = [idTRANSACTIONS]
	FROM [dbo].[TRANSACTIONS_TEMP];

	INSERT INTO [dbo].[TRANSACTIONS](idBranch, idTRANSACTION_TYPES, idACCOUNT, Entered_amount, Accounted_amount, Fee_amount, Tax_amount, Currentcy_code, Exchange_rate, Created_by, Last_update_by, Created_date, Last_update_date, Approver_by, Approver_date, Status)
	SELECT idBranch, idTRANSACTION_TYPES, idACCOUNT, Entered_amount, Accounted_amount, Fee_amount, Tax_amount, Currentcy_code, Exchange_rate, Created_by, Last_update_by, Created_date, Last_update_date, Approver_by, Approver_date, Status FROM [dbo].[TRANSACTIONS_TEMP];

	DELETE FROM [dbo].[TRANSACTIONS_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_CUSTOMER
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idCUSTOMER INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idCUSTOMER = [idCUSTOMER]
	FROM [dbo].[CUSTOMER_TEMP];

	INSERT INTO [dbo].[CUSTOMER](idBranch, Name, Address, Birthday, Sex, Phone, Fax, Email, ID_NUMBER, ID_DATE, ID_PLACE, Status, Created_by, Last_update_by, Created_date, Last_update_date)
	SELECT idBranch, Name, Address, Birthday, Sex, Phone, Fax, Email, ID_NUMBER, ID_DATE, ID_PLACE, Status, Created_by, Last_update_by, Created_date, Last_update_date FROM [dbo].[CUSTOMER_TEMP];
	DELETE FROM [dbo].[CUSTOMER_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_TYPE_SAVINGS_ACCOUNT
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idTYPE_SAVINGS_ACCOUNT INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idTYPE_SAVINGS_ACCOUNT = [idTYPE_SAVINGS_ACCOUNT]
	FROM [dbo].[TYPE_SAVINGS_ACCOUNT_TEMP];

	--KIEM TRA CO TON TAI CHUA
	INSERT INTO [dbo].[TYPE_SAVINGS_ACCOUNT](Name, Status, Create_by, Last_update_by, Created_date, Last_update_date)
	SELECT Name, Status, Create_by, Last_update_by, Created_date, Last_update_date FROM [dbo].[TYPE_SAVINGS_ACCOUNT_TEMP];
	DELETE FROM [dbo].[TYPE_SAVINGS_ACCOUNT_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_SAVINGS_ACCOUNT
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idSAVINGS_ACCOUNT INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idSAVINGS_ACCOUNT = [idSAVINGS_ACCOUNT]
	FROM [dbo].[SAVINGS_ACCOUNT_TEMP];

	--KIEM TRA CO TON TAI CHUA
	INSERT INTO [dbo].[SAVINGS_ACCOUNT](idTYPE_SAVINGS_ACCOUNT, idBranch, idCUSTOMER, idACCOUNT, Open_Date, Close_Date, Maturial_Date, Created_by, Last_update_by, Created_date, Last_update_date, Status)
	SELECT idTYPE_SAVINGS_ACCOUNT, idBranch, idCUSTOMER, idACCOUNT, Open_Date, Close_Date, Maturial_Date, Created_by, Last_update_by, Created_date, Last_update_date, Status FROM [dbo].[SAVINGS_ACCOUNT_TEMP];
	DELETE FROM [dbo].[SAVINGS_ACCOUNT_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_ACCOUNT_TYPE
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idACCOUNT_TYPE INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idACCOUNT_TYPE = [idACCOUNT_TYPE]
	FROM [dbo].[ACCOUNT_TYPE_TEMP];

	--KIEM TRA CO TON TAI CHUA
	INSERT INTO [dbo].[ACCOUNT_TYPE](Name, MinBal, MaxBal, Status, Created_by, Last_update_by, Create_date, Last_update_date)
	SELECT Name, MinBal, MaxBal, Status, Created_by, Last_update_by, Create_date, Last_update_date FROM [dbo].[ACCOUNT_TYPE_TEMP];
	DELETE FROM [dbo].[ACCOUNT_TYPE_TEMP];
END;

GO
--------------------------------------------------

ALTER PROC CREATE_ACCOUNT
AS 
BEGIN
	DECLARE @LAST_UPDATE_DATE DATE,
			@NAME VARCHAR(150),
			@idACCOUNT INT;

	SELECT TOP 1 @LAST_UPDATE_DATE = [last_update_date], @idACCOUNT = [idACCOUNT]
	FROM [dbo].[ACCOUNT_TEMP];

	--KIEM TRA CO TON TAI CHUA
	INSERT INTO [dbo].[ACCOUNT](idACCOUNT_TYPE, idBranch, idCUSTOMER, Account_number, Open_date, Close_date, Currentcy_code, Min_Balance, Max_Balance, Amount, Status, Created_by, Last_update_by, Created_date, Last_update_date)
	SELECT idACCOUNT_TYPE, idBranch, idCUSTOMER, Account_number, Open_date, Close_date, Currentcy_code, Min_Balance, Max_Balance, Amount, Status, Created_by, Last_update_by, Created_date, Last_update_date FROM [dbo].[ACCOUNT_TEMP];
	DELETE FROM [dbo].[ACCOUNT_TEMP];
END;

GO
--------------------------------------------------

EXEC CREATE_OWNER

SELECT * FROM OWNER;
DELETE FROM OWNER WHERE idOWNER IN (13,14,15);

SELECT * FROM OWNER;

SELECT * FROM BRANCH

SELECT * FROM EMPLOYEE

SELECT * FROM POSITION_EMP

SELECT * FROM TRANSACTIONS

SELECT * FROM TRANSACTION_TYPES

SELECT * FROM CUSTOMER

SELECT * FROM TYPE_SAVINGS_ACCOUNT

SELECT * FROM SAVINGS_ACCOUNT

SELECT * FROM ACCOUNT

SELECT * FROM ACCOUNT_TYPE