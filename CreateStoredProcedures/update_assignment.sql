CREATE DEFINER=`root`@`localhost` PROCEDURE `update_assignment`(
IN Id INT, 
Comment_ VARCHAR(600),
IsDone_ BOOLEAN,
DateFirst DATETIME,
DateFinish DATETIME)
BEGIN
	UPDATE generalassignment
    SET
		Comment = Comment_,
        IsDone = IsDone_,
        DateAdded = DateFirst,
        DateToFinish = DateFinish
	WHERE GeneralAssignmentId = Id;		
END