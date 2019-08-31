CREATE VIEW [cinema] AS
SELECT film_name, film_actors
FROM film as fm
INNER JOIN actors as ac ON 
fm.film_actors=ac.id;

CREATE PROCEDURE SelectAllFilm
AS
SELECT * FROM film
GO;

EXEC SelectAllFilm;