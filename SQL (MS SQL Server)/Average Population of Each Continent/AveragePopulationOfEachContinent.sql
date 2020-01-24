SELECT co.Continent, FLOOR(AVG(ci.Population)) as 'Avg_City_Population'
FROM City ci
INNER JOIN Country co
ON ci.CountryCode = co.Code
GROUP BY co.Continent;