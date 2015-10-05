create database Movies;

create table Registro(PeliculaId int identity, titulo varchar(20), Descripcion varchar(50), Ano int, 
calificacion int, IMDB int, CategoriaId int);

select * from Registro where 1=1

Select PeliculaId, titulo, descripcion, Ano, calificacion, IMDB, CategoriaId from Registro 

