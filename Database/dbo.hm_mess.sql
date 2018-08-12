CREATE TABLE [dbo].[hm_mess] (
    [itemID]        INT          IDENTITY (1, 1) NOT NULL,
    [item_name]     VARCHAR (50) NULL,
    [item_quantity] INT          NULL,
    [total_price]   INT          NULL,
    [month]         VARCHAR (50) NULL,
    [year]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([itemID] ASC)
);

