-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.

--Answer:Id INT, Name VARCHAR, EmployerID INT

--Part 2: Write a query to list the names of the employers in St. Louis City.

--Answer: SELECT Name
--        FROM Employer
--        WHERE Location = 'St. Louis City':

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

--Answer: SELECT DISTINCT s.name, s.description
--        FROM skills s
--        OIN job_skills js ON js.skill_id = s.id
--        JOIN jobs j ON j.id = js.job_id
--        ORDER BY s.name ASC;

