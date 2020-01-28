SELECT h.hacker_id
     , h.name
     , SUM(score) as total_score
FROM   Hackers h
INNER JOIN (
            SELECT   hacker_id
                   , MAX(score) as score
            FROM     Submissions
            GROUP BY challenge_id
                   , hacker_id
           ) s
      ON h.hacker_id = s.hacker_id
GROUP BY h.hacker_id
       , h.name
  HAVING SUM(score) > 0
ORDER BY total_score DESC
       , h.hacker_id;
