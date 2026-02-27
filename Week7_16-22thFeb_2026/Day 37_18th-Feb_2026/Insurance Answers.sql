use insurance;
-- 1.
SELECT 
    pst.policy_type_id,
    rpt.policy_type_name,
    pst.description
FROM policy_sub_types pst
JOIN ref_policy_types rpt
    ON pst.policy_type_code = rpt.policy_type_code
WHERE rpt.policy_type_name = 'car';

-- 2.
SELECT 
    policy_type_code,
    COUNT(*) AS NO_OF_POLICIES
FROM policy_sub_types
GROUP BY policy_type_code;

-- 3.
SELECT 
    u.user_id,
    u.firstname,
    u.lastname,
    u.email,
    u.mobileno
FROM user_details u
JOIN address_details a
    ON u.address_id = a.address_id
WHERE LOWER(a.city) = 'chennai';

-- 4
SELECT DISTINCT
    u.user_id,
    (u.firstname + ' ' + u.lastname) AS USER_NAME,
    u.email,
    u.mobileno
FROM user_details u
JOIN user_policies up
    ON u.user_id = up.user_id
JOIN policy_sub_types pst
    ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt
    ON pst.policy_type_code = rpt.policy_type_code
WHERE rpt.policy_type_name = 'car';

-- 5. 
SELECT DISTINCT
    u.user_id,
    u.firstname,
    u.lastname
FROM user_details u
WHERE u.user_id IN (
        SELECT up.user_id
        FROM user_policies up
        JOIN policy_sub_types pst
            ON up.policy_type_id = pst.policy_type_id
        JOIN ref_policy_types rpt
            ON pst.policy_type_code = rpt.policy_type_code
        WHERE rpt.policy_type_name = 'car'
)
AND u.user_id NOT IN (
        SELECT up.user_id
        FROM user_policies up
        JOIN policy_sub_types pst
            ON up.policy_type_id = pst.policy_type_id
        JOIN ref_policy_types rpt
            ON pst.policy_type_code = rpt.policy_type_code
        WHERE rpt.policy_type_name = 'home'
);

-- 6. 
SELECT TOP 1
    rpt.policy_type_code,
    rpt.policy_type_name,
    COUNT(*) AS NO_OF_POLICIES
FROM policy_sub_types pst
JOIN ref_policy_types rpt
    ON pst.policy_type_code = rpt.policy_type_code
GROUP BY rpt.policy_type_code, rpt.policy_type_name
ORDER BY COUNT(*) DESC;


-- 7. 
SELECT 
    u.user_id,
    u.firstname,
    u.lastname,
    a.city,
    a.state
FROM user_details u
JOIN address_details a
    ON u.address_id = a.address_id
WHERE LOWER(a.city) LIKE '%bad';

-- 8. 
SELECT
    u.user_id,
    u.firstname,
    u.lastname,
    up.policy_no,
    up.date_registered
FROM user_details u
JOIN user_policies up
    ON u.user_id = up.user_id
WHERE up.date_registered < '2012-05-01';

-- 9. 
SELECT
    u.user_id,
    u.firstname,
    u.lastname
FROM user_details u
JOIN user_policies up
    ON u.user_id = up.user_id
GROUP BY u.user_id, u.firstname, u.lastname
HAVING COUNT(up.policy_no) > 1;

-- 10. 
SELECT
    rpt.policy_type_code,
    rpt.policy_type_name,
    pst.policy_type_id,
    up.user_id,
    up.policy_no
FROM user_policies up
JOIN policy_sub_types pst
    ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt
    ON pst.policy_type_code = rpt.policy_type_code
WHERE DATEADD(YEAR, pst.maturityperiod, up.date_registered)
      BETWEEN '2013-08-01' AND '2013-08-31';

-- 11
SELECT DISTINCT
    rpt.policy_type_code,
    rpt.policy_type_name,
    pst.policy_type_id
FROM policy_sub_types pst
JOIN ref_policy_types rpt
    ON pst.policy_type_code = rpt.policy_type_code
JOIN user_policies up
    ON pst.policy_type_id = up.policy_type_id
JOIN policy_payments pp
    ON up.policy_no = pp.policy_no
GROUP BY
    rpt.policy_type_code,
    rpt.policy_type_name,
    pst.policy_type_id,
    pst.maturityamount
HAVING pst.maturityamount = 2 * SUM(pp.amount);

-- 12. 
SELECT
    user_id,
    SUM(amount) AS total_amount
FROM policy_payments
GROUP BY user_id;

-- 13. 
SELECT
    user_id,
    policy_no,
    SUM(amount) AS total_amount
FROM policy_payments
GROUP BY user_id, policy_no;

-- 14. 
SELECT
    up.user_id,
    up.policy_no,
    pst.amount * pst.yearsofpayements - ISNULL(SUM(pp.amount),0) AS balance_amount
FROM user_policies up
JOIN policy_sub_types pst
    ON up.policy_type_id = pst.policy_type_id
LEFT JOIN policy_payments pp
    ON up.policy_no = pp.policy_no
GROUP BY
    up.user_id,
    up.policy_no,
    pst.amount,
    pst.yearsofpayements;

-- 15. 
SELECT
    up.user_id,
    up.policy_no,
    pst.yearsofpayements - COUNT(pp.receipno) AS BALANCE_YEARS
FROM user_policies up
JOIN policy_sub_types pst
    ON up.policy_type_id = pst.policy_type_id
LEFT JOIN policy_payments pp
    ON up.policy_no = pp.policy_no
GROUP BY
    up.user_id,
    up.policy_no,
    pst.yearsofpayements;

-- 16. Users who have taken car, home AND life
SELECT
    u.user_id,
    u.firstname,
    u.lastname
FROM user_details u
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt ON pst.policy_type_code = rpt.policy_type_code
GROUP BY u.user_id, u.firstname, u.lastname
HAVING COUNT(DISTINCT rpt.policy_type_name) = 3;

-- 17. Total amount paid per policy department
SELECT
    rpt.policy_type_code,
    SUM(pp.amount) AS total_amount
FROM policy_payments pp
JOIN user_policies up ON pp.policy_no = up.policy_no
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt ON pst.policy_type_code = rpt.policy_type_code
GROUP BY rpt.policy_type_code;


-- 18. 
SELECT
    u.user_id,
    (u.firstname + ' ' + u.lastname) AS user_name,
    pst.policy_type_code,
    pst.policy_type_id
FROM user_details u
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
GROUP BY
    u.user_id,
    u.firstname,
    u.lastname,
    pst.policy_type_code,
    pst.policy_type_id
HAVING COUNT(*) > 1;

-- 19. 
SELECT TOP 1
    rpt.policy_type_code,
    rpt.policy_type_name,
    COUNT(*) AS NO_OF_POLICIES
FROM user_policies up
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt ON pst.policy_type_code = rpt.policy_type_code
GROUP BY rpt.policy_type_code, rpt.policy_type_name
ORDER BY COUNT(*) ASC;


-- 20. 

SELECT
    u.user_id,
    (u.firstname + ' ' + u.lastname) AS user_name,
    a.city + ', ' + a.state AS address,
    u.mobileno,
    rpt.policy_type_code,
    pst.policy_type_id,
    rpt.policy_type_name
FROM user_details u
JOIN address_details a ON u.address_id = a.address_id
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt ON pst.policy_type_code = rpt.policy_type_code
LEFT JOIN policy_payments pp ON up.policy_no = pp.policy_no
GROUP BY
    u.user_id, u.firstname, u.lastname,
    a.city, a.state, u.mobileno,
    rpt.policy_type_code, pst.policy_type_id,
    rpt.policy_type_name,
    pst.yearsofpayements
HAVING COUNT(pp.receipno) >= pst.yearsofpayements;


-- 21.
SELECT TOP 2
    u.user_id,
    (u.firstname + ' ' + u.lastname) AS user_name,
    a.city + ', ' + a.state AS address,
    u.mobileno,
    rpt.policy_type_code,
    pst.policy_type_id,
    rpt.policy_type_name,
    up.date_registered
FROM user_details u
JOIN address_details a ON u.address_id = a.address_id
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types pst ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt ON pst.policy_type_code = rpt.policy_type_code
ORDER BY up.date_registered DESC;