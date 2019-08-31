create procedure A
@Par1 int,
@Par2 int
as
declare @toplam int
set @toplam = @Par1 + @Par2
return @toplam


create procedure B
@Par1 int,
@Par2 int 
as
Declare @Par3 int;
Execute @Par3 = dbo.A @Par1, @Par2;
select @Par3 as [Toplam], @Par1 int, @Par2 int;



exec B 10, 5