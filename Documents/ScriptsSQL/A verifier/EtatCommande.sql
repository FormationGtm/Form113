use form113
go
drop table "StatusCommande";
drop table "Marketing";
go
create table StatusCommande (
	IdStatusCommande int Primary key not null,
	StatusCommande nvarchar(30) not null
)
insert StatusCommande (IdStatusCommande,StatusCommande)
values (1,'Command�')
insert StatusCommande (IdStatusCommande,StatusCommande)
values (2,'Envoy�')
insert StatusCommande (IdStatusCommande,StatusCommande)
values (3,'Re�u')

go 
create table Marketing (
	NbreCommandePourReduc int,
)

go

Alter table Commandes alter column EtatCommande INT;
alter table Commandes
add constraint fk_EtatCommande
foreign key (EtatCommande)
references StatusCommande(IdStatusCommande)