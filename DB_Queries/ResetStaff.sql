DELETE FROM [table_Staff];

DBCC CHECKIDENT(table_Staff,RESEED,100);

INSERT INTO [table_Staff]
(
       [password],
       [PermLevel],
       [Forename],
       [Surname],
       [Title],
       [Gender],
       [DOB],
       [Role],
       [EmploymentBasis],
       [Address1],
       [City],
       [Postcode]
)
VALUES
(
       'password1',
       '3',
       'Admin',
       'Admin',
       'Mr',
       'M',
       '1900-01-01',
       'Admin',
       'Full',
       '',
       '',
       ''
);