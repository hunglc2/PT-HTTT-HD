CREATE TABLE OWNER_TEMP (
  idOWNER INT NOT NULL,
  Name NVARCHAR(150) NULL,
  Address NVARCHAR(255) NULL,
  Phone VARCHAR(15) NULL,
  Fax VARCHAR(20) NULL,
  created_by INT NULL,
  last_update_by INT NULL,
  created_date DATETIME NULL,
  last_update_date DATETIME NULL
)

DROP TABLE BRANCH_TEMP
-- -----------------------------------------------------
-- Table BRANCH
-- -----------------------------------------------------
CREATE TABLE BRANCH_TEMP (
  idBranch INT NOT NULL,
  idOWNER INT NOT NULL,
  Name NVARCHAR(150) NULL,
  Address NVARCHAR(255) NULL,
  Phone VARCHAR(15) NULL,
  Fax VARCHAR(20) NULL,
  created_by INT NULL,
  last_update_by INT NULL,
  created_date DATETIME NULL,
  last_update_date DATETIME NULL
 )


-- -----------------------------------------------------
-- Table POSITION_EMP
-- -----------------------------------------------------
CREATE TABLE POSITION_EMP_TEMP (
  idPOSITION INT NOT NULL,
  Name NVARCHAR(100) NULL,
  Status VARCHAR(15) NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table EMPLOYEE
-- -----------------------------------------------------
CREATE TABLE EMPLOYEE_TEMP (
  idEMPLOYEE INT NOT NULL,
  idBranch INT NOT NULL,
  idPOSITION INT NOT NULL,
  Name NVARCHAR(50) NULL,
  Address NVARCHAR(255) NULL,
  Phone VARCHAR(15) NULL,
  created_by INT NULL,
  last_update_by INT NULL,
  created_date DATETIME NULL,
  last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table CUSTOMER
-- -----------------------------------------------------
CREATE TABLE CUSTOMER_TEMP (
  idCUSTOMER INT NOT NULL,
  idBranch INT NOT NULL,
  Name NVARCHAR(55) NULL,
  Address NVARCHAR(255) NULL,
  Birthday DATE NULL,
  Sex NVARCHAR(15) NULL,
  Phone VARCHAR(15) NULL,
  Fax VARCHAR(20) NULL,
  Email VARCHAR(45) NULL,
  ID_NUMBER VARCHAR(25) NULL,
  ID_DATE DATE NULL,
  ID_PLACE NVARCHAR(155) NULL,
  Status VARCHAR(15) NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL
)

-- -----------------------------------------------------
-- Table ACCOUNT_TYPE
-- -----------------------------------------------------
CREATE TABLE ACCOUNT_TYPE_TEMP (
  idACCOUNT_TYPE INT NOT NULL,
  Name NVARCHAR(155) NULL,
  MinBal DECIMAL NULL,
  MaxBal DECIMAL NULL,
  Status VARCHAR(15) NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Create_date DATETIME NULL,
  Last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table ACCOUNT
-- -----------------------------------------------------
CREATE TABLE ACCOUNT_TEMP (
  idACCOUNT INT NOT NULL,
  idACCOUNT_TYPE INT NOT NULL,
  idBranch INT NOT NULL,
  idCUSTOMER INT NOT NULL,
  Account_number VARCHAR(35) NOT NULL,
  Open_date DATE NULL,
  Close_date DATE NULL,
  Currentcy_code VARCHAR(15) NULL,
  Min_Balance DECIMAL NULL,
  Max_Balance DECIMAL NULL,
  Amount DECIMAL NULL,
  Status VARCHAR(15) NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table TYPE_SAVINGS_ACCOUNT
-- -----------------------------------------------------
CREATE TABLE TYPE_SAVINGS_ACCOUNT_TEMP (
  idTYPE_SAVINGS_ACCOUNT INT NOT NULL,
  Name NVARCHAR(155) NULL,
  Status VARCHAR(15) NULL,
  Create_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table SAVINGS_ACCOUNT
-- -----------------------------------------------------
CREATE TABLE SAVINGS_ACCOUNT_TEMP (
  idSAVINGS_ACCOUNT INT NOT NULL,
  idTYPE_SAVINGS_ACCOUNT INT NOT NULL,
  idBranch INT NOT NULL,
  idCUSTOMER INT NOT NULL,
  idACCOUNT INT NOT NULL,
  Open_Date DATE NULL,
  Close_Date DATE NULL,
  Maturial_Date DATE NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL,
  Status VARCHAR(15) NULL
)


-- -----------------------------------------------------
-- Table TRANSACTION_TYPES
-- -----------------------------------------------------
CREATE TABLE TRANSACTION_TYPES_TEMP (
  idTRANSACTION_TYPES INT NOT NULL,
  Name NVARCHAR(155) NULL,
  Status VARCHAR(15) NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL
)


-- -----------------------------------------------------
-- Table TRANSACTIONS
-- -----------------------------------------------------
CREATE TABLE TRANSACTIONS_TEMP (
  idTRANSACTIONS INT NOT NULL,
  idBranch INT NOT NULL,
  idTRANSACTION_TYPES INT NOT NULL,
  idACCOUNT INT NOT NULL,
  Entered_amount DECIMAL NULL,
  Accounted_amount DECIMAL NULL,
  Fee_amount DECIMAL NULL,
  Tax_amount DECIMAL NULL,
  Currentcy_code VARCHAR(45) NULL,
  Exchange_rate DECIMAL NULL,
  Created_by INT NULL,
  Last_update_by INT NULL,
  Created_date DATETIME NULL,
  Last_update_date DATETIME NULL,
  Approver_by INT NULL,
  Approver_date DATETIME NULL,
  Status VARCHAR(15) NULL
)