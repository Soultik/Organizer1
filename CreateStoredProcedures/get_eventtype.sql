CREATE DEFINER=`root`@`localhost` PROCEDURE `get_eventtype`()
BEGIN
SELECT* FROM eventtype;
END