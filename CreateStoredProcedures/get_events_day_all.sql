CREATE DEFINER=`root`@`localhost` PROCEDURE `get_events_day_all`(IN day_ DATETIME)
BEGIN
SELECT DISTINCT * FROM event
JOIN eventtype USING(EventTypeId)
WHERE DATE(StartTime) = DATE(day_);
END