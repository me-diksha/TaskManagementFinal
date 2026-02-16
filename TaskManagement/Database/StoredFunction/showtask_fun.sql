CREATE OR REPLACE FUNCTION showtask_fun(
    p_userid INT
    
)
RETURNS TABLE(

taskid INT,
description VARCHAR,
status BOOLEAN
)
LANGUAGE plpgsql
AS $$

BEGIN
    RETURN QUERY
    SELECT 
	
	t.taskid AS taskid,
	t.description AS description,
	t.status AS status
    FROM tasklist t
    WHERE t.userid = p_userid;

   
END;
$$;
