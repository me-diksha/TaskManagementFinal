CREATE OR REPLACE PROCEDURE add_task_proc(
p_userid INT,
P_taskid INT,
p_description VARCHAR,
p_stATUS BOOLEAN
)
LANGUAGE plpgsql
AS $$
BEGIN 
    INSERT INTO tasklist(userid,taskid,description,status)
    VALUES(p_userid,p_taskid,p_description,p_status);
END;
$$;