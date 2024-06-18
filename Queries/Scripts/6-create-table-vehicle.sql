CREATE TABLE [Vehicle] ( 

  [ID] int not null primary key, 

  [Name] varchar(255), 

  [Km] float, 

  [Regnr] varchar(7), 

  [Year] int, 

  [TowingHook] BIT, 

  [DriverLicenseType] varchar(255), 

  [EngineSize] varchar(255), 

  [KmPerLiter] float, 

  [FuelType] varchar(255), 

  [EnergyClass] varchar(7), 

); 