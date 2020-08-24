CREATE DEFINER=`root`@`localhost` PROCEDURE `update_eventtype`(
IN Id INT,
Name_ varchar(100)
)
BEGIN
UPDATE eventtype
    SET
		EventTypeName = Name_
	WHERE EventTypeId = Id;		
END