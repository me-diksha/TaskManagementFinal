-- FUNCTION: public.getrole_fun(integer)

-- DROP FUNCTION IF EXISTS public.getrole_fun(integer);

CREATE OR REPLACE FUNCTION public.getrole_fun(
	p_userid integer)
    RETURNS character varying
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
DECLARE 
   role VARCHAR;
BEGIN
   SELECT u.role INTO role FROM userdata u WHERE u.id=p_userid;

   RETURN role;
END;
$BODY$;

ALTER FUNCTION public.getrole_fun(integer)
    OWNER TO postgres;

