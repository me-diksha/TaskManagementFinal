-- FUNCTION: public.get_next_taskid_fun(integer)

-- DROP FUNCTION IF EXISTS public.get_next_taskid_fun(integer);

CREATE OR REPLACE FUNCTION public.get_next_taskid_fun(
	p_userid integer)
    RETURNS integer
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
DECLARE
    next_id INT;
BEGIN
    SELECT COALESCE(MAX(taskid), 0) + 1
    INTO next_id
    FROM tasklist
    WHERE userid = p_userid;

    RETURN next_id;
END;
$BODY$;

ALTER FUNCTION public.get_next_taskid_fun(integer)
    OWNER TO postgres;

