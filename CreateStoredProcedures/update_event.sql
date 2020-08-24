CREATE DEFINER=`root`@`localhost` PROCEDURE `update_event`(
IN Id_ INT, 
Comment_ VARCHAR(600),
StartTime_ DATETIME,
EndTime_ DATETIME,
EventTypeId_ INT)
BEGIN
	UPDATE organizerdb.event
    SET
		Comment = Comment_,
        StartTime = StartTime_,
        EndTime = EndTime_,
        EventTypeId = EventTypeId_
	WHERE EventId = Id_;		
END