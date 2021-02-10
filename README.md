# RegistrationForm

# After create database using migration script
# run the following script
create table Registration    
(    
 UserId int not null primary key identity(1,1),    
 Username nvarchar(150),    
 Age int,
 PhoneNumber nvarchar(50),
 EmailId nvarchar(150)
);
