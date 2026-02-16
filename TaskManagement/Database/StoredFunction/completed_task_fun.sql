-- FUNCTION: public.completedtask_fun(integer, boolean)

-- DROP FUNCTION IF EXISTS public.completedtask_fun(integer, boolean);

CREATE OR REPLACE FUNCTION public.completedtask_fun(
	p_userid integer,
	p_status boolean)
    RETURNS TABLE(taskid integer, description character varying, status boolean) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$

BEGIN
    RETURN QUERY
    SELECT 
	
	t.taskid AS taskid,
	t.description AS description,
	t.status AS status
    FROM tasklist t
    WHERE t.userid = p_userid
	AND t.status=p_status;

   
END;
$BODY$;

ALTER FUNCTION public.completedtask_fun(integer, boolean)
    OWNER TO postgres;

