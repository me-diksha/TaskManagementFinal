-- PROCEDURE: public.delete_task_proc(integer, integer)

-- DROP PROCEDURE IF EXISTS public.delete_task_proc(integer, integer);

CREATE OR REPLACE PROCEDURE public.delete_task_proc(
	IN p_taskid integer,
	IN p_userid integer)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN 
    DELETE FROM tasklist WHERE taskid=p_taskid AND userid=p_userid;
   
END;
$BODY$;
ALTER PROCEDURE public.delete_task_proc(integer, integer)
    OWNER TO postgres;

