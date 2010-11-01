Select * 
From dbo.[User] 
	inner join Employee on [User].[user_id] = Employee.[user_id]
	inner join Agency on Employee.employee_id = Agency.agency_id
--	inner join [Group] on Agency.agency_id = [Group].agency_id
