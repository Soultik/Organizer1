CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_template_event`(
IN TDayId_ INT,
StartTime_ DATETIME,
EndTime_ DATETIME,
EventTypeId_ INT,
OUT ID INT)
BEGIN
INSERT INTO organizerdb.event (TDayId, StartTime, EndTime, EventTypeId)
VALUES (TDayId_, StartTime_, EndTime_, EventTypeId_);

SELECT LAST_INSERT_ID() INTO ID;
END