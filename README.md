# RegistrationForm
# Create Database using Migration Script then Run the following script:
create table Registration    
(    
 UserId int not null primary key identity(1,1),    
 Username nvarchar(150),    
 Age int,
 PhoneNumber nvarchar(50),
 EmailId nvarchar(150)
);    
