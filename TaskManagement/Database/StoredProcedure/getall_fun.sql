CREATE OR REPLACE FUNCTION getall_fun(
    p_role VARCHAR
    
)
RETURNS TABLE(
id INT,
username VARCHAR,
role VARCHAR
)
LANGUAGE plpgsql
AS $$

BEGIN
    RETURN QUERY
    SELECT 
	u.id AS id,
	u.username AS username,
	u.role AS role
    FROM userdata u
    WHERE u.role = p_role;

   
END;
$$;
