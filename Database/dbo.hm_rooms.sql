CREATE TABLE [dbo].[hm_rooms] (
    [room_id]      INT          IDENTITY (1, 1) NOT NULL,
    [room_no]      INT          NOT NULL,
    [room_type]    VARCHAR (50) NOT NULL,
    [no_of_beds]   VARCHAR (50) NOT NULL,
    [total_beds]   VARCHAR (50) NULL,
    [price]        VARCHAR (50) NOT NULL,
    [description]  VARCHAR (50) NOT NULL,
    [availability] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([room_id] ASC)
);

