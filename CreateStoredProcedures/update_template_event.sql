CREATE DEFINER=`root`@`localhost` PROCEDURE `update_template_event`(
IN Id_ INT, 
StartTime_ DATETIME,
EndTime_ DATETIME,
EventTypeId_ INT)
BEGIN
UPDATE organizerdb.event
    SET
        StartTime = StartTime_,
        EndTime = EndTime_,
        EventTypeId = EventTypeId_
	WHERE EventId = Id_;	
END