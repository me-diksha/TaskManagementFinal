-- PROCEDURE: public.update_task_proc(integer, integer, character varying, boolean)

-- DROP PROCEDURE IF EXISTS public.update_task_proc(integer, integer, character varying, boolean);

CREATE OR REPLACE PROCEDURE public.update_task_proc(
	IN p_taskid integer,
	IN p_userid integer,
	IN p_desc character varying,
	IN p_status boolean)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    UPDATE tasklist SET description=p_desc,status=p_status 
	WHERE taskid=p_taskid AND userid=p_userid;
   
END;
$BODY$;
ALTER PROCEDURE public.update_task_proc(integer, integer, character varying, boolean)
    OWNER TO postgres;

