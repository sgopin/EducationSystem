CREATE PROCEDURE `create_semester`(
IN institute_id BIGINT,
IN semester_name VARCHAR(100),
IN semester_desc LONGTEXT,
IN url VARCHAR(100),
IN template_id BIGINT,
OUT semsterId bigint)
BEGIN
 DECLARE entity_id BIGINT;
 declare semester_id bigint;
 
	insert into Entities Values(1);
    set entity_id = LAST_INSERT_ID();
	
    insert into Semesters (Name, Description, EntityId, InstituteId, TemplateId) Values (semester_name, semester_desc, entity_id, institute_id, template_id);
    set semester_id = LAST_INSERT_ID();
    
    insert into Hosts (URL, IsPrimary, IsDefault, SemesterId) VALUES (url, 1, 1, semester_id);
	set semsterId = semester_id;
END