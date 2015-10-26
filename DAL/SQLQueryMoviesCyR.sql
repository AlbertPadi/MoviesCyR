use MoviesCyR;

create table Registro(PeliculaId int identity, titulo varchar(20), Descripcion varchar(50), Ano int, 
calificacion int, IMDB int, CategoriaId int, Estudio varchar(50));

create table Generos(GeneroId int identity, Descripcion varchar(100));
create table Actores(Actorid int identity, Nombre varchar(50));
create table Estudios(EstudioId int identity, Nombre varchar(50));

select *from Registro

select *from Actores
select *from Estudios;

create table PeliculasGeneros(PeliculaId int, GeneroId int);

create table PeliculasActores(PeliculaId int, ActorId int);

select *from Registro;

select *from PeliculasGeneros;

select *from PeliculasActores;