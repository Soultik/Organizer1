CREATE DEFINER=`root`@`localhost` PROCEDURE `get_assignments`()
BEGIN
SELECT* FROM generalassignment;
END