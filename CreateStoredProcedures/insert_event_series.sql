CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_event_series`(
IN startDate_ DATETIME,
endDate_ DATETIME,
EventTypeId_ INT,
StartTime_ DATETIME,
EndTime_ DATETIME,
DayType_ INT)
BEGIN
DECLARE count INT DEFAULT 0;
	-- looping through dates given by the user
WHILE DATE_ADD(startDate_, INTERVAL count DAY) <= endDate_ DO
		-- making sure that days of the week look like this:
        -- Mon - 1, Tue - 2, ... Sun - 7 instead of sunday starting with 1
	  SET @dayweek = (DAYOFWEEK(DATE_ADD(startDate_, INTERVAL count DAY)) - 1);
      IF @dayweek = 0 THEN
      SET @dayweek = 7;
      END IF;
		-- here is determined if day of week at current iteration corresponds with the type
        -- provided by the user (weekday/weekend)
	  IF ( @dayweek DIV 6 ) = ( DayType_ DIV 6 )
		  THEN INSERT INTO organizerdb.event (EventTypeId, StartTime, EndTime)
		  VALUES (EventTypeId_,
		  ADDTIME(DATE_ADD(startDate_, INTERVAL count DAY), TIME(StartTime_)),
		  ADDTIME(DATE_ADD(startDate_, INTERVAL count DAY), TIME(EndTime_))
		  );
      END IF;
      SET count = count + 1;
END WHILE;
END