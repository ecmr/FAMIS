Select
	 U.[user_id], U.first_name, U.last_name, U.email
	,E.employee_id, E.first_name, E.last_name, E.code
	,T.starttime, T.endtime, 
	 DateDiff(hour, T.starttime, T.endtime) Hora
	,DateDiff(minute, T.starttime, T.endtime) Minute
	,Case 
		When Convert(int, DateDiff(second, T.starttime, T.endtime)) > 59 Then
			Convert(int, DateDiff(second, T.starttime, T.endtime)) - 60
	End Second
	,A.name
	,Gp.name   as Group_Name
	,Pr.name   as Project_Name
	,Cli.local_name
--  ,L.*
	,Cr.name   as Country_name
	,r.name    as Region_name 
	,Pos.name  as Position_name
	,Dep.name  as Department_name	 
From 
	[User] U 
		left  join Employee E on U.[user_id] = E.[user_id]
			inner join Agency A on A.agency_id = E.agency_id
				inner join [Group] Gp on A.agency_id = Gp.agency_id
				inner join Project Pr on A.agency_id = Pr.agency_id
				inner join Client Cli on Pr.client_id = Cli.client_id
				inner join Timesheet T on Cli.client_id = T.client_id
			inner join Position Pos on E.position_id = E.position_id
			inner join Department Dep on Pos.department_id = Dep.department_id 
		inner join Location L on A.agency_id = L.agency_id
		inner join Country Cr on L.country_id = Cr.country_id
		inner join Region r on Cr.region_id = r.region_id
--Where
--	T.timesheet_id=31
