CREATE TABLE [dbo].[hm_student] (
    [student_id]    INT          IDENTITY (1, 1) NOT NULL,
    [student_name]  VARCHAR (50) NOT NULL,
    [student_usn]   VARCHAR (50) NOT NULL,
    [student_phone] VARCHAR (50) NOT NULL,
    [student_email] VARCHAR (50) NOT NULL,
    [room_id]       INT          NULL,
    [mess]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([student_id] ASC),
    CONSTRAINT [AK_hm_student_Column] UNIQUE NONCLUSTERED ([student_usn] ASC),
    CONSTRAINT [FK_hm_hostel] FOREIGN KEY ([room_id]) REFERENCES [dbo].[hm_rooms] ([room_id]) ON DELETE CASCADE ON UPDATE CASCADE
);

