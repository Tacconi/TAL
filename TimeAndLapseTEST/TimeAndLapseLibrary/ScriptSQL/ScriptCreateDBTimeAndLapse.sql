use Master
go

Create Database TimeAndLapse
go

use TimeAndLapse
go

Create Table Partecipants
(
  PartecipantID uniqueidentifier,
  FirstName nvarchar(50) not null ,
  LastName nvarchar(50) not null,
  Gender integer not null,
  BloodGroup integer not null,
  PhoneNumber nvarchar(20) not null,
  BirthDate datetime not null,
  Address nvarchar(100) not null,
  License nvarchar(25) not null,
  Insurance nvarchar(30) not null,
  Photo image not null,
  Country nvarchar(30) not null,
  Email nvarchar(50),
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_PartecipantID primary key (PartecipantID) 
) --Fatto 21/12/15
go

Create Table Teams
(
  TeamID uniqueidentifier,
  Code nvarchar(50) not null,
  Place nvarchar(50) not null,
  Description nvarchar(150),
  President nvarchar(50) not null,
  Address nvarchar(50) not null,
  Logo image,
  Email nvarchar(50),
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_TeamID primary key (TeamID)
)  --Fatto 21/12/15
go

create table Manches
(
  MancheID uniqueidentifier,
  Shift integer not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_MancheID primary key (MancheID)
  )  --Fatto 21/12/15
go

create table Races
(
  RaceID uniqueidentifier,
  Code nvarchar(150) not null,
  Lenght real not null,
  Slope real not null,
  WidthRoad real not null,
  StartAddress nvarchar(100) not null,
  EndAddress nvarchar(100) not null,
  RaceDate datetime not null,
  Place nvarchar(100) not null,
  Pavement nvarchar(50) not null,
  SubscriptionPrice float not null,
  PaymentDate datetime not null,
  PaymentPlace nvarchar(150) not null,
  OrganizedBy nvarchar(100) not null,
  Description nvarchar(150),
  Photo image not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_RaceID primary key (RaceID)
)  --Fatto 21/12/15
go

create table Timings
(
  TimingID uniqueidentifier,
  Time datetime not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_TimingID primary key (TimingID)
)  --Fatto 21/12/15
go

create table Rounds
(
  RoundID uniqueidentifier,
  Code nvarchar(50) not null,
  Description nvarchar(150) not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_RoundID primary key (RoundID)
)  --Fatto 21/12/15
go

create table Points
(
  PointID uniqueidentifier,
  Value integer not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_PointID primary key (PointID)
)  --Fatto 21/12/15
go

create table Championships
(
  ChampionshipID uniqueidentifier,
  Code nvarchar(50) not null,
  Description nvarchar(150),
  Prize nvarchar(100) not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_ChampionshipID primary key (ChampionshipID)
)  --Fatto 21/12/15
go

create table Categories
(
  CategoryID uniqueidentifier,
  Code nvarchar(50) not null,
  Description nvarchar(150) not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_CategoryID primary key (CategoryID)
)  --Fatto 21/12/15
go

create table Seasons
(
  SeasonID uniqueidentifier,
  Code nvarchar(50) not null,
  Description nvarchar(150) not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_SeasonID primary key (SeasonID)
)  --Fatto 21/12/15 
go

create table Registrations
(
  RegistrationID uniqueidentifier,
  Payd tinyint not null,
  RaceNumber integer not null,
  Note nvarchar(250),
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_RegistrationID primary key (RegistrationID)
)  --Fatto 21/12/15
go

create table Players
(
  PlayerID uniqueidentifier,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_PlayerID primary key (PlayerID)
) --Fatto 21/12/15
go

create table TimingTypes
(
  TimingTypeID uniqueidentifier,
  Code nvarchar(50) not null,
  Description nvarchar(150) not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_TimingTypeID primary key (TimingTypeID)
)  --Fatto 21/12/15
go

create table Events
(
  EventID uniqueidentifier,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_EventID primary key (EventID)
)  --Fatto
go

create table Scores
(
  ScoreID uniqueidentifier,
  Ranking integer not null,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_ScoreID primary key (ScoreID)
)  --Fatto
go

create table Runs
(
  RunID uniqueidentifier,
  RowGuid uniqueidentifier rowguidcol not null,
  RowVersion timestamp not null,
  constraint PK_RunID primary key (RunID)
)  --Fatto
go



---------------------

ALTER TABLE Registrations
ADD PartecipantID uniqueidentifier REFERENCES Partecipants(PartecipantID) not null --Fatto 21/12/15
go

ALTER TABLE Registrations
ADD RaceID uniqueidentifier REFERENCES Races(RaceID) not null --Fatto 21/12/15
go


---------------------

ALTER TABLE Players
ADD RegistrationID uniqueidentifier REFERENCES Registrations(RegistrationID) not null --Fatto 21/12/15
go

ALTER TABLE Players
ADD TeamID uniqueidentifier REFERENCES Teams(TeamID) not null --Fatto 21/12/15
go

ALTER TABLE Players
ADD CrewID uniqueidentifier REFERENCES Players(PlayerID) not null --Fatto 21/12/15
go

ALTER TABLE Players
ADD EventID uniqueidentifier REFERENCES Events(EventID) not null --Fatto 21/12/15
go 

---------------------

ALTER TABLE Events
ADD RaceID uniqueidentifier REFERENCES Races(RaceID) not null --Fatto 21/12/15
go

ALTER TABLE Events
ADD CategoryID uniqueidentifier REFERENCES Categories(CategoryID) not null --Fatto 21/12/15
go

ALTER TABLE Events
ADD ChampionshipID uniqueidentifier REFERENCES Championships(ChampionshipID) not null --Fatto 21/12/15
go

---------------------

ALTER TABLE Timings
ADD RunID uniqueidentifier REFERENCES Runs(RunID) not null --Fatto 21/12/15
go

ALTER TABLE Timings
ADD TimingTypeID uniqueidentifier REFERENCES TimingTypes(TimingTypeID) not null --Fatto 21/12/15
go

---------------------

ALTER TABLE Scores
ADD PointID uniqueidentifier REFERENCES Points(PointID) not null --Fatto 21/12/15
go

ALTER TABLE Scores
ADD SeasonID uniqueidentifier REFERENCES Seasons(SeasonID) not null --Fatto 21/12/15
go

ALTER TABLE Scores
ADD ChampionshipID uniqueidentifier REFERENCES Championships(ChampionshipID) not null --Fatto 21/12/15
go

---------------------

ALTER TABLE Manches
ADD PlayerID uniqueidentifier REFERENCES Players(PlayerID) not null --Fatto 21/12/15
go

ALTER TABLE Manches
ADD RoundID uniqueidentifier REFERENCES Rounds(RoundID) not null --Fatto 21/12/15
go

ALTER TABLE Manches
ADD TournamentID uniqueidentifier REFERENCES Manches(MancheID) not null --Fatto 21/12/15
go

---------------------

ALTER TABLE Runs
ADD MancheID uniqueidentifier REFERENCES Manches(MancheID) not null --Fatto 21/12/15
go


