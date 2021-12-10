INSERT INTO Library (UserId, OpenedId, Link, Description, CategoryId )
VALUES 
(
(Select Id FROM Users WHERE FirstName = 'Jonathon'),
(Select Id FROM LogOpened WHERE UserId = 'D7F2FCD5-B0B5-4D4F-A89C-A74A38AC59D9'),
'https://www.youtube.com/watch?v=Ja9D0kpksxw',
'IOHK | Cardano whiteboard; overview with Charles Hoskinson',
(Select Id FROM LibraryCategories WHERE CategoryName = 'Cardano'))

INSERT INTO Library (UserId, OpenedId, Link, Description, CategoryId )
VALUES 
(
(Select Id FROM Users WHERE FirstName = 'Jonathon'),
(Select Id FROM LogOpened WHERE UserId = 'D7F2FCD5-B0B5-4D4F-A89C-A74A38AC59D9'),
'https://iohk.io/en/research/library/papers/chimeric-ledgerstranslating-and-unifying-utxo-based-and-account-based-cryptocurrencies/',
'Chimeric Ledgers: Translating and Unifying UTXO-based and Account-based Cryptocurrencies ',
(Select Id FROM LibraryCategories WHERE CategoryName = 'Cardano'))