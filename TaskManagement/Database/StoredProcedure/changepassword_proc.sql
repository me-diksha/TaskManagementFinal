CREATE OR REPLACE PROCEDURE changepassword_proc(
p_username VARCHAR,
p_password VARCHAR
)
LANGUAGE plpgsql
AS
$$
BEGIN
   UPDATE userdata SET password=p_password WHERE username=p_username;
END;
$$;