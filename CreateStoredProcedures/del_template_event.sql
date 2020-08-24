CREATE DEFINER=`root`@`localhost` PROCEDURE `del_template_event`(IN Id_ INT)
BEGIN
DELETE FROM organizerdb.event WHERE EventId = Id_;
END