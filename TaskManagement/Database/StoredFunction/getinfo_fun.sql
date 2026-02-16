-- FUNCTION: public.getinfo_fun(integer)

-- DROP FUNCTION IF EXISTS public.getinfo_fun(integer);

CREATE OR REPLACE FUNCTION public.getinfo_fun(
	p_userid integer)
    RETURNS character varying
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
DECLARE 
   username VARCHAR;
BEGIN
   SELECT u.username INTO username FROM userdata u WHERE u.id=p_userid;

   RETURN username;
END;
$BODY$;

ALTER FUNCTION public.getinfo_fun(integer)
    OWNER TO postgres;

