CREATE OR REPLACE PROCEDURE addNewUser_proc(
p_username VARCHAR,
p_password VARCHAR,
p_role VARCHAR
)
LANGUAGE plpgsql
AS
$$
BEGIN
   INSERT INTO userdata(username,password,role)
   VALUES (p_username,p_pasword,p_role);
END;
$$;