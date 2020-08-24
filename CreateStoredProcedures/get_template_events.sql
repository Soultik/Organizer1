CREATE DEFINER=`root`@`localhost` PROCEDURE `get_template_events`(IN day_ VARCHAR(45))
BEGIN
SELECT * FROM organizerdb.event
JOIN templateday USING(TDayId)
JOIN eventtype USING(EventTypeId)
WHERE Day = day_;
END