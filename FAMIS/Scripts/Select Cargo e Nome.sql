Select F4 as Cargo, F5 as name From dbo.um Where F5 not in('Marzo, 2010', 'Junio, 2010', 'Febrero, 2010', 'Employee Name', 'Date', '#REF!', '%', '% or other', '3%', '27%', '28%', '35%')
and F4 is not null and F5 is not null Group by F5, F4

