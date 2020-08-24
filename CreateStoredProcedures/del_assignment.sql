CREATE DEFINER=`root`@`localhost` PROCEDURE `del_assignment`(IN Id INT)
BEGIN
DELETE FROM generalassignment WHERE GeneralAssignmentId = Id;
END