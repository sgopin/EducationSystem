CREATE PROCEDURE `create_institute`(
IN institute_name VARCHAR(100),
OUT InstituteId BIGINT)
BEGIN
 DECLARE entity_id BIGINT;
 
	insert into Entities Values(1);
    set entity_id = LAST_INSERT_ID();
	
    insert into Institutes (Name, EntityId) Values (institute_name, entity_id);
    set InstituteId = LAST_INSERT_ID();

END