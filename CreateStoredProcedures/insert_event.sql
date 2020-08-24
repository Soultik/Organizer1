CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_event`(
Comment_ VARCHAR(600),
StartTime_ DATETIME,
EndTime_ DATETIME,
EventTypeId_ INT,
OUT ID INT)
BEGIN
INSERT INTO organizerdb.event (Comment, StartTime, EndTime, EventTypeId)
VALUES (Comment_, StartTime_, EndTime_, EventTypeId_);

SELECT LAST_INSERT_ID() INTO ID;
END