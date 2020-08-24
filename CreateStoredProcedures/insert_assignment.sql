CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_assignment`(
IN Comment_ VARCHAR(600),
IsDone BOOLEAN,
DateFirst DATETIME,
DateFinish DATETIME,
OUT ID INT)
BEGIN
INSERT INTO organizerdb.generalassignment (Comment, IsDone, DateAdded, DateToFinish)
VALUES (Comment_, IsDone, DateFirst, DateFinish);

SELECT LAST_INSERT_ID() INTO ID;
END