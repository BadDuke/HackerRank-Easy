SELECT CAST(SUM(LAT_N) as Decimal(10, 2))
     , CAST(SUM(LONG_W) as Decimal(10, 2))
FROM Station;