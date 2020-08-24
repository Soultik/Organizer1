CREATE DEFINER=`root`@`localhost` PROCEDURE `create_days`()
BEGIN
   DECLARE count INT DEFAULT 0;
   WHILE count < 365 DO
      INSERT INTO organizerdb.actualday (Date, IsWeekday)
	  VALUES (
      DATE_ADD(CURDATE() - 4, INTERVAL count DAY), 
      (MOD(count, 7) <  5) );      
      SET count = count + 1;
   END WHILE;
END