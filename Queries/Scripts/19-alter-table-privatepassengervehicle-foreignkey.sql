ALTER TABLE [PrivateVehicle]
ADD FOREIGN KEY ([PassengerVehicleId]) REFERENCES [PassengerVehicle]([ID]); 