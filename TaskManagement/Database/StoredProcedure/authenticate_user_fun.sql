CREATE OR REPLACE FUNCTION authenticate_user_fun(
    p_username VARCHAR,
    p_password VARCHAR
)
RETURNS TABLE(
    id INT,
    username VARCHAR,
    password VARCHAR,
    role VARCHAR
)
LANGUAGE plpgsql
AS $$
BEGIN
    RETURN QUERY
    SELECT
	u.id AS id,
	 u.username AS username, 
	 u.password AS password,
	 u.role AS role
    FROM userdata u
    WHERE u.username = p_username
    AND u.password = p_password;
END;
$$;
