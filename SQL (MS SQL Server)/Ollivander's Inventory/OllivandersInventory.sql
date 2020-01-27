/*
The problem statement is flawed in that it does not clearly state the requirement of selecting only the minimum-cost wand for each given age and power pairing.
*/

SELECT w.id
     , wp.age
     , w.coins_needed
     , w.power
FROM Wands w
INNER JOIN Wands_Property wp
   ON w.code = wp.code
WHERE wp.is_evil = 0
  AND w.coins_needed = (
          SELECT MIN(w2.coins_needed)
          FROM Wands w2
          WHERE w.code = w2.code
            AND w.power = w2.power)
ORDER BY w.power DESC
       , wp.age  DESC;