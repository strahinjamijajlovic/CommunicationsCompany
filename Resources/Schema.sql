CREATE TABLE Addresses(
	Id int NOT NULL,
	Street nvarchar2(100) NULL,
	ApartmentNumber int NULL,
	City nvarchar2(255) NULL,
  CONSTRAINT address_pk PRIMARY KEY (Id)
)

CREATE SEQUENCE addresses_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER addresses_id_trigger
  BEFORE INSERT ON Addresses
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := addresses_id_sequence.nextval;
  END IF;
END;


CREATE TABLE CommNodes(
	Id int NOT NULL,
	Description nvarchar2(200) NULL,
	DeviceId int NULL,
	AddressId int NULL,
	MainHubId int NULL,
	CONSTRAINT commNode_pk PRIMARY KEY (Id),
    FOREIGN KEY(DeviceId) REFERENCES Devices(Id) ON DELETE CASCADE,
    FOREIGN KEY(AddressId) REFERENCES Addresses(Id) ON DELETE CASCADE,
    FOREIGN KEY(MainHubId) REFERENCES MainHubs(Id)
)

CREATE SEQUENCE addresses_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER addresses_id_trigger
  BEFORE INSERT ON Addresses
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := addresses_id_sequence.nextval;
  END IF;
END;

CREATE TABLE Devices(
	Id int NOT NULL,
	SerialNumber nvarchar2(50) NOT NULL,
	ManufacturerName nvarchar2(100) NOT NULL,
	InstallationDate date(7) NOT NULL,
	LastServiceDate date(7) NULL,
	LastServiceReason nvarchar2(500) NULL,
  CONSTRAINT devices_pk PRIMARY KEY (Id)
) 

CREATE SEQUENCE devices_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER devices_id_trigger
  BEFORE INSERT ON Devices
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := devices_id_sequence.nextval;
  END IF;
END;

CREATE TABLE ExtraProgrammes(
	Id int NOT NULL,
	Name nvarchar2(50) NOT NULL,
	ServiceId int NULL,
	CONSTRAINT extraProgrammes_pk PRIMARY KEY (Id),
    FOREIGN KEY(ServiceId) REFERENCES Services(Id) ON DELETE CASCADE
)

CREATE SEQUENCE extraProgrammes_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER extraProgrammes_id_trigger
  BEFORE INSERT ON ExtraProgrammes
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := extraProgrammes_id_sequence.nextval;
  END IF;
END;

CREATE TABLE InternetServices(
	Id int NOT NULL,
	Prepaid bit NOT NULL,
	LastPaymentDate date(7) NULL,
	AccountBalance real NULL,
	FlatRate bit NOT NULL,
  CONSTRAINT internetServices_pk PRIMARY KEY (Id)
)

CREATE SEQUENCE internetServices_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER internetServices_id_trigger
  BEFORE INSERT ON InternetServices
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := internetServices_id_sequence.nextval;
  END IF;
END;

CREATE TABLE LegalEntities(
	Id int NOT NULL,
	FaxNumber nvarchar2(20) NOT NULL,
	PIB nvarchar2(20) NOT NULL,
	ContactPersonId int NULL,
	ServicesId int NULL,
	CONSTRAINT legalEntities_pk PRIMARY KEY (Id),
    FOREIGN KEY(ContactPersonId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY(ServicesId) REFERENCES Services(Id) ON DELETE CASCADE
)

CREATE SEQUENCE legalEntities_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER addresses_id_trigger
  BEFORE INSERT ON LegalEntities
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := legalEntities_id_sequence.nextval;
  END IF;
END;

CREATE TABLE MainHubs(
	Id int NOT NULL,
	DeviceId int NULL,
	RegionalHubId int NULL,
  CONSTRAINT mainHubs_pk PRIMARY KEY (Id),
    FOREIGN KEY(RegionalHubId) REFERENCES RegionalHubs(Id),
    FOREIGN KEY(DeviceId) REFERENCES Devices(Id) ON DELETE CASCADE
) 

CREATE SEQUENCE mainHubs_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER mainHubs_id_trigger
  BEFORE INSERT ON MainHubs
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := mainHubs_id_sequence.nextval;
  END IF;
END;

CREATE TABLE NaturalPersons(
	Id int NOT NULL,
	JMBG nvarchar2(13) NOT NULL,
	ContactNumber nvarchar2(20) NOT NULL,
	UserId int NULL,
	AddressId int NULL,
	ServicesId int NULL,
	CONSTRAINT naturalPersons_pk PRIMARY KEY (Id),
    FOREIGN KEY(UserId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY(AddressId) REFERENCES Addresses(Id) ON DELETE CASCADE,
    FOREIGN KEY(ServicesId) REFERENCES Services(Id) ON DELETE CASCADE
)

CREATE SEQUENCE naturalPersons_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER naturalPersons_id_trigger
  BEFORE INSERT ON NaturalPersons
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := naturalPersons_id_sequence.nextval;
  END IF;
END;

CREATE TABLE PhoneNumbers(
	Id int NOT NULL,
	Number nvarchar2(20) NOT NULL,
	MinutesCount int NOT NULL,
	ServiceId int NULL,
	CONSTRAINT phoneNumbers_pk PRIMARY KEY (Id),
    FOREIGN KEY(ServicesId) REFERENCES Services(Id) ON DELETE CASCADE
)

CREATE SEQUENCE phoneNumbers_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER phoneNumbers_id_trigger
  BEFORE INSERT ON PhoneNumbers
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := phoneNumbers_id_sequence.nextval;
  END IF;
END;

CREATE TABLE RegionalHubs(
	Id int NOT NULL,
	RegionName nvarchar2(50) NOT NULL,
	DeviceId int NULL,
	CONSTRAINT egionalHubs_pk PRIMARY KEY (Id),
    FOREIGN KEY(DeviceId) REFERENCES Devices(Id) ON DELETE CASCADE
) 

CREATE SEQUENCE regionalHubs_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER regionalHubs_id_trigger
  BEFORE INSERT ON RegionalHubs
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := regionalHubs_id_sequence.nextval;
  END IF;
END;

CREATE TABLE Services(
	Id int NOT NULL,
	InternetServiceId int NULL,
	CONSTRAINT services_pk PRIMARY KEY (Id),
    FOREIGN KEY(InternetServiceId) REFERENCES InternetServices(Id) ON DELETE CASCADE
)

CREATE SEQUENCE services_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER services_id_trigger
  BEFORE INSERT ON Services
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := services_id_sequence.nextval;
  END IF;
END;

CREATE TABLE StaticIps(
	Id int NOT NULL,
	IpAddress nvarchar2(20) NOT NULL,
	InternetServiceId int NULL,
	CONSTRAINT staticIps_pk PRIMARY KEY (Id),
    FOREIGN KEY(InternetServiceId) REFERENCES InternetServices(Id) ON DELETE CASCADE
)

CREATE SEQUENCE staticIps_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER staticIps_id_trigger
  BEFORE INSERT ON StaticIps
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := staticIps_id_sequence.nextval;
  END IF;
END;

CREATE TABLE Users(
	Id int NOT NULL,
	FirstName nvarchar2(50) NULL,
	LastName nvarchar2(50) NULL,
	CommNodeId int NULL,
	  CONSTRAINT users_pk PRIMARY KEY (Id),
    FOREIGN KEY(CommNodeId) REFERENCES CommNodes(Id) ON DELETE CASCADE
)

CREATE SEQUENCE users_id_sequence 
  start with 1 
  increment by 1;

CREATE TRIGGER users_id_trigger
  BEFORE INSERT ON Users
  FOR EACH ROW
DECLARE
BEGIN
  IF( :new.id IS NULL )
  THEN
    :new.id := users_id_sequence.nextval;
  END IF;
END;
