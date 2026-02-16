CREATE OR REPLACE FUNCTION userNameExist_fun(
    p_username VARCHAR
    
)
RETURNS BOOLEAN
LANGUAGE plpgsql
AS $$
DECLARE
    user_count INT;
BEGIN
    SELECT COUNT(*) INTO user_count
    FROM userdata u
    WHERE u.username = p_username;

    RETURN user_count > 0;
END;
$$;
