
CREATE DATABASE [db_my_company];
GO

CREATE TABLE employee_card(
    	[id] [int] IDENTITY(1,1) NOT NULL,
        fullname VARCHAR(100) NOT NULL,
        license_plate VARCHAR(10),
        adresse VARCHAR(100),
        zip_code SMALLINT,
        phone SMALLINT,
        mail VARCHAR(100),
        create_date DATETIME NOT NULL,
        edit_date DATETIME
);
Go

CREATE TABLE [dbo].[employee_data_card](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_name] [varchar(100)] NOT NULL,
	[licen_plate] [varchar(30)] NOT NULL,
	[employee_created] [datetime] NOT NULL,
	[employee_edited] [datetime] NULL,
	CONSTRAINT [employee_pk] PRIMARY KEY CLUSTERED (employee_id)
);

CREATE TABLE [dbo].[driving_record](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NOT NULL,
	[kilometer_traveled] [int] NOT NULL,
	[drived_date] [datetime] NOT NULL,
	[driving_record_created] [datetime] NOT NULL,
	[driving_record_edited] [datetime] NULL
	CONSTRAINT [driving_record_id_pk] PRIMARY KEY CLUSTERED (id),
	CONSTRAINT [employee_employee_reiving_record] FOREIGN KEY REFERENCES employee_data_card(employee_id),
	REFERENCES [dbo].[employee_data_card(employee_id)] ON DELETE CASCADE
);

	-- Clustered indexes sort and store the data rows in the table or view based on their key values
	-- https://docs.microsoft.com/en-us/sql/relational-databases/indexes/clustered-and-nonclustered-indexes-described?view=sql-server-ver15#:~:text=If%20you%20configure%20a%20PRIMARY,key%20using%20a%20nonclustered%20index.

--CREATE TABLE [dbo].[employee_drivering_record_id](
--	[id] [int] IDENTITY(1,1) NOT NULL,
--	[employee_id] [int] NOT NULL
--);




 -- https://www.sqlshack.com/learn-sql-naming-conventions/