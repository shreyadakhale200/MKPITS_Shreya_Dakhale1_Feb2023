select s.StateName from TableState s inner join TableNation n on s.NationID = n.NationID where NationName = 'India'
select c.CityName from TableCity c inner join TableState s on c.StateID = s.StateId where StateName = 'Punjab'

select * from TableState


