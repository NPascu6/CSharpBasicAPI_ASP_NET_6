INSERT INTO UserRoles(Id, RoleId, RoleName)
VALUES ('b850ddf5-e9ad-47ff-9d2a-57259014fae6', 1, 'Pro');
INSERT INTO UserRoles(Id, RoleId, RoleName)
VALUES ('b840d3f5-e9ad-47ff-9d2a-57259014fae6', 2, 'User');
INSERT INTO UserRoles(Id, RoleId, RoleName)
VALUES ('b750ddf5-e9ad-47ff-9d2a-57259014fae6', 3, 'Trial');

INSERT INTO Users (Id, LastName, FirstName, Email) 
VALUES ('b950ddf5-e9ad-47ff-9d2a-57259014fae6', 'Test', 'Pro', 'testPro@test.com');
INSERT INTO Users (Id, LastName, FirstName, Email) 
VALUES ('907f54ba-2142-4719-aef9-6230c23bd7de', 'Test', 'User', 'testUser@test.com');
INSERT INTO Users (Id, LastName, FirstName, Email) 
VALUES ('79e9872d-5a2f-413e-ac36-511036ccd3d4', 'Test', 'Trial', 'testTrial@test.com');

INSERT INTO UserDetails(Id, UserId, PhoneNumber, Address, BirthDate)
VALUES ('c950ddf5-e9ad-47ff-9d2a-57259014fae6', 'b950ddf5-e9ad-47ff-9d2a-57259014fae6', 765952211 , 'Test Address Pro', '12.12.1994');
INSERT INTO UserDetails(Id, UserId, PhoneNumber, Address, BirthDate)
VALUES ('807f54ba-2142-4719-aef9-6230c23bd7de', '907f54ba-2142-4719-aef9-6230c23bd7de', 764952313 , 'Test Address User', '02.11.1996');
INSERT INTO UserDetails(Id, UserId, PhoneNumber, Address, BirthDate)
VALUES ('69e9872d-5a2f-413e-ac36-511036ccd3d4', '79e9872d-5a2f-413e-ac36-511036ccd3d4', 742952323 , 'Test Address Trial', '04.06.1998');

INSERT INTO Wallets(Id, UserDetailsId, WalletName)
VALUES ('59e9872d-5a2f-413e-ac36-511036ccd3d4', 'c950ddf5-e9ad-47ff-9d2a-57259014fae6', 'Test Wallet Pro');
INSERT INTO Wallets(Id, UserDetailsId, WalletName)
VALUES ('49e9872d-5a2f-413e-ac36-511036ccd3d4', '807f54ba-2142-4719-aef9-6230c23bd7de', 'Test Wallet User');
INSERT INTO Wallets(Id, UserDetailsId, WalletName)
VALUES ('39e9872d-5a2f-413e-ac36-511036ccd3d4', '69e9872d-5a2f-413e-ac36-511036ccd3d4', 'Test Wallet Trial' );

INSERT INTO Assets(Id, WalletId, AssetName, AssetQuantity)
VALUES ('29e9872d-5a2f-413e-ac36-511036ccd3d4', '59e9872d-5a2f-413e-ac36-511036ccd3d4', 'Test Asset Pro 1', 11.5);
INSERT INTO Assets(Id, WalletId, AssetName, AssetQuantity)
VALUES ('19e9872d-5a2f-413e-ac36-511036ccd3d4', '49e9872d-5a2f-413e-ac36-511036ccd3d4', 'Test Asset User 1', 202.32);
INSERT INTO Assets(Id, WalletId, AssetName, AssetQuantity)
VALUES ('09e9872d-5a2f-413e-ac36-511036ccd3d4', '39e9872d-5a2f-413e-ac36-511036ccd3d4', 'Test Asset Trial 1', 42.1112);