DECLARE @MinCityLen int;
DECLARE @MaxCityLen int;
SET @MinCityLen = (SELECT MIN(LEN(City)) FROM Station);
SET @MaxCityLen = (SELECT MAX(LEN(City)) FROM Station);

SELECT City, LEN(City)
FROM STATION
WHERE City = (
        SELECT TOP (1) City
        FROM STATION
        WHERE LEN(City) = @MinCityLen
        ORDER BY City ASC
)
OR City = (
        SELECT TOP (1) City
        FROM STATION
        WHERE LEN(City) = @MaxCityLen
        ORDER BY City ASC
);
