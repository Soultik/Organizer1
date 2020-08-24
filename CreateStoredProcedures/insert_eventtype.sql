CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_eventtype`(
IN Name_ VARCHAR(100),
OUT ID INT
)
BEGIN
INSERT INTO organizerdb.eventtype (EventTypeName)
VALUES (Name_);
SELECT LAST_INSERT_ID() INTO ID;
END