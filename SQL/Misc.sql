INSERT INTO LogOpened (UserId, NameOfLog)
VALUES 
((SELECT Id FROM Users WHERE FirstName = 'Jonathon'), 'Defi')