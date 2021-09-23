---------
--Base de donnée
---------

CREATE TABLE DEPT (
DEPTNO INTEGER NOT NULL PRIMARY KEY,
DNAME VARCHAR(255) NOT NULL,
LOC VARCHAR (255) NOT NULL
);

CREATE TABLE EMP (
EMPNO INTEGER NOT NULL PRIMARY KEY,
ENAME VARCHAR (255) NOT NULL,
JOB VARCHAR (255) NOT NULL,
HIREDATE DATE NOT NULL,
SAL INTEGER NOT NULL,
COMM INTEGER,
MGR INTEGER, CONSTRAINT FK_emp_MGR FOREIGN KEY (MGR) REFERENCES EMP (EMPNO),
DEPTNO INTEGER NOT NULL, CONSTRAINT FK_dept_emp FOREIGN KEY (DEPTNO) REFERENCES DEPT (DEPTNO),
);

INSERT INTO DEPT (DEPTNO, DNAME, LOC)
VALUES 
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON')

INSERT INTO EMP (EMPNO, ENAME, JOB, MGR, HIREDATE, SAL, COMM, DEPTNO)
VALUES 
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL , 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL , 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-08-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1982-12-09', 3000, NULL , 20),
(7839, 'KING', 'PRESIDENT', NULL , '1981-11-17',5000, NULL , 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1983-01-12', 1100, NULL , 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-02-23', 1300, NULL, 10)


--PREMIERE PARTIE


-----------
--1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
-----------

SELECT ENAME, JOB, EMPNO, SAL FROM EMP
SELECT ENAME, JOB, EMPNO, SAL FROM EMP WHERE DEPTNO=10 

-----------
--2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
-----------

SELECT ENAME, JOB, SAL FROM EMP WHERE JOB='MANAGER' AND SAL > 2800

-----------
--3. Donner la liste des MANAGER n appartenant pas au département 30
-----------

SELECT * FROM EMP WHERE DEPTNO <> 30

-----------
--4. Liste des employés de salaire compris entre 1200 et 1400
-----------

SELECT * FROM EMP WHERE SAL BETWEEN 1200 AND 1400

-----------
--5. Liste des employés des départements 10 et 30 classés dans l ordre alphabétique
-----------

SELECT * FROM EMP WHERE DEPTNO IN (10, 30) ORDER BY ENAME ASC

-----------
--6. Liste des employés du département 30 classés dans l ordre des salaires croissants
-----------

SELECT * FROM EMP WHERE DEPTNO LIKE 30 ORDER BY SAL ASC

-----------
--7. Liste de tous les employés classés par emploi et salaires décroissants
-----------

SELECT * FROM EMP ORDER BY JOB, SAL DESC

-----------
--8. Liste des différents emplois
-----------

SELECT DISTINCT JOB FROM EMP

SELECT JOB FROM EMP GROUP BY JOB

SELECT JOB, COUNT(*) as EFFECTIF , CONVERT(DECIMAL(9,2),AVG(SAL)) as MOYENNE FROM EMP GROUP BY JOB

-----------
--9. Donner le nom du département où travaille ALLEN
-----------

SELECT DNAME FROM DEPT WHERE DEPTNO = (SELECT DEPTNO FROM EMP WHERE ENAME='ALLEN');

SELECT DNAME, ENAME FROM DEPT INNER JOIN EMP ON EMP.DEPTNO = DEPT.DEPTNO WHERE EMP.ENAME = 'ALLEN'

-----------
--10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et 
--par salaires décroissants.
-----------

SELECT DEPT.DNAME, EMP.ENAME, EMP.JOB, EMP.SAL FROM EMP INNER JOIN DEPT ON  EMP.DEPTNO = DEPT.DEPTNO ORDER BY  DNAME, SAL DESC

-----------
--11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + 
--commissions
-----------

SELECT ENAME, SAL, COMM, SAL+COMM FROM EMP WHERE soundex (JOB) = soundex('SALESMAAN')

-----------
--12. Liste des employés du département 20: nom, job, date d embauche sous forme VEN 28 FEV 1997
-----------

SELECT ENAME, JOB, FORMAT (HIREDATE, 'ddd, dd, MMM, yyyy') as HIREDATE, SAL + (CASE WHEN COMM IS NULL THEN 0 ELSE COMM END) as SAL_TOTAL FROM EMP WHERE DEPTNO = 20 

-----------
--13.Donner le salaire le plus élevé par département
-----------

SELECT ENAME , SAL where ( SELECT MAX(SAL) FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO 
GROUP BY DNAME ) as test HAVING ENAME = ( SELECT ENAME WHERE SAL = MAX(SAL) )

-----------
--14. Donner département par département masse salariale, nombre d employés, salaire moyen par type d emploi.
-----------

SELECT  DNAME, JOB, SUM (SAL) + SUM(CASE WHEN COMM IS NULL THEN 0 ELSE COMM END) as MASS_SAL, COUNT(EMPNO) as NBR_EMP, 
AVG(SAL) as MOYENNE FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO GROUP BY DNAME, JOB ORDER BY DNAME, JOB 

-----------
--15. Même question mais on se limite aux sous-ensembles d au moins 2 employés
-----------

SELECT  DEPTNO, JOB, SUM(SAL) as MASS_SAL, COUNT(EMPNO)  as NBR_EMP, SUM(SAL)/COUNT(EMPNO) as MOYENNE FROM EMP GROUP BY DEPTNO, JOB HAVING COUNT (EMPNO) > 1  ORDER BY DEPTNO, JOB 

-----------
--16. Liste des employés (Nom, département, salaire) de même emploi que JONES
-----------

SELECT ENAME, DNAME, SAL, JOB FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO WHERE JOB = ( SELECT JOB FROM EMP WHERE ENAME='JONES') AND ENAME <> 'JONES';

-----------
--17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
-----------

SELECT ENAME, SAL FROM EMP WHERE SAL > (SELECT AVG(SAL) FROM EMP)

-----------
--18. Création d une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 
--caractères), budget. Entrez les valeurs suivantes:
--101, ALPHA, 96000
--102, BETA, 82000
--103, GAMMA, 15000
-----------

CREATE TABLE PROJET (
PROJNO INT IDENTITY (101,1) NOT NULL PRIMARY KEY,
PROJNAME VARCHAR (5) NOT NULL,
BUDG INTEGER NOT NULL );
INSERT INTO PROJET (PROJNO, PROJNAME, BUDG)
VALUES 
(101, 'ALPHA', 96000),
(102, 'BETA', 82000),
(103, 'GAMMA', 15000)

-----------
--19.  Ajouter l attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30
--au projet 101, et les autres au projet 102
-----------

ALTER TABLE EMP
ADD PROJNO INTEGER, CONSTRAINT FK_PROJNO FOREIGN KEY (PROJNO) REFERENCES PROJET (PROJNO)
UPDATE EMP
SET PROJNO = 101 
WHERE DEPTNO = 30 AND JOB = 'SALESMAN'
UPDATE EMP
SET PROJNO = 102 WHERE EMPNO not in (SELECT empno FROM emp WHERE DEPTNO = 30 AND JOB = 'SALESMAN')

-----------
--20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
-----------

CREATE VIEW TEST AS
SELECT EMP.ENAME, EMP.JOB, DEPT.DNAME, PROJET.PROJNAME , EMP.DEPTNO
FROM PROJET INNER JOIN EMP ON PROJET.PROJNO = EMP.PROJNO INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO
SELECT * FROM TEST

-----------
--21. A l aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département 
--et nom de projet triés sur nom de département et nom de projet
-----------

SELECT * FROM TEST ORDER BY DEPTNO, PROJNAME

-----------
--22. Donner le nom du projet associé à chaque manager
-----------

SELECT JOB, PROJNAME FROM TEST WHERE JOB ='MANAGER'


--DEUXIEME PARTIE


-----------
--1. Afficher la liste des managers des départements 20 et 30
-----------

SELECT ENAME, JOB, DEPTNO FROM TEST WHERE JOB ='MANAGER' AND (DEPTNO = 20 OR DEPTNO = 30)

-----------
--2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81
-----------

SELECT ENAME, HIREDATE FROM EMP WHERE JOB <> 'MANAGER' AND HIREDATE NOT LIKE '%%81-%%-%%'

-----------
--3. Afficher la liste des employés ayant une commission
-----------

SELECT ENAME, COMM FROM EMP WHERE COMM > 0 AND COMM IS NOT NULL

-----------
--4. Afficher la liste des noms, numéros de département, jobs et date d embauche triés par Numero de 
--Département et JOB les derniers embauches d abord.
-----------

SELECT ENAME, DEPTNO, JOB, HIREDATE FROM EMP ORDER BY DEPTNO, HIREDATE DESC

-----------
--5.Afficher la liste des employés travaillant à DALLAS
-----------

SELECT ENAME, LOC FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO  
WHERE LOC = 'DALLAS' 

-----------
--6. Afficher les noms et dates d embauche des employés embauchés avant leur manager, avec le nom et
--date d embauche du manager.
-----------

SELECT EMP.ENAME, EMP.JOB, EMP.HIREDATE, TEST.ENAME as MANAGER_NAME, TEST.HIREDATE AS HIREDATE_MANAGER
FROM EMP INNER JOIN EMP as TEST
ON EMP.MGR = TEST.EMPNO  
WHERE EMP.HIREDATE < TEST.HIREDATE AND EMP.JOB <> 'manager'

-----------
--7.Lister les numéros des employés n ayant pas de subordonné
-----------

SELECT EMPNO, ENAME FROM EMP WHERE EMPNO NOT IN (SELECT DISTINCT ISNULL(MGR,0) FROM EMP)

-----------
--8. Afficher les noms et dates d embauche des employés embauchés avant BLAKE.
-----------

SELECT ENAME, HIREDATE FROM EMP WHERE HIREDATE < ( SELECT HIREDATE FROM EMP WHERE ENAME = 'BLAKE')

-----------
--9. Afficher les employés embauchés le même jour que FORD
-----------

SELECT ENAME, HIREDATE FROM EMP WHERE HIREDATE = ( SELECT HIREDATE FROM EMP WHERE ENAME = 'FORD') AND ENAME <> 'FORD'

-----------
--10. Lister les employés ayant le même manager que CLARK.
-----------

SELECT ENAME, MGR FROM EMP WHERE MGR = ( SELECT MGR FROM EMP WHERE ENAME = 'CLARK')  AND ENAME <> 'CLARK'

-----------
--11. Lister les employés ayant même job et même manager que TURNER.
-----------

SELECT ENAME, JOB, MGR FROM EMP WHERE JOB = ( SELECT JOB FROM EMP WHERE ENAME = 'TURNER') 
AND MGR = ( SELECT MGR FROM EMP WHERE ENAME = 'TURNER') AND ENAME <> 'TURNER'

-----------
--12. Lister les employés du département RESEARCH embauchés le même jour que quelqu un du 
--département SALES.
-----------

SELECT ENAME, DNAME, HIREDATE FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO  
WHERE DNAME = 'RESEARCH' 
AND HIREDATE in ( SELECT HIREDATE FROM EMP INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO WHERE DNAME = 'SALES' )

-----------
--13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date
--dembauche.
-----------

SELECT ENAME, FORMAT (HIREDATE, 'dddd') as HIREDATE_DAY FROM EMP 

-----------
--14. Donner, pour chaque employé, le nombre de mois qui s est écoulé entre leur date d embauche et la
--date actuelle.
-----------

SELECT ENAME, DATEDIFF(MONTH,  HIREDATE, GETDATE() ) as NBR_MONTH FROM EMP 

-----------
--15. Afficher la liste des employés ayant un M et un A dans leur nom.
-----------

SELECT ENAME FROM EMP WHERE ENAME LIKE '%[a]%' ENAME LIKE '%[m]%'

-----------
--16. Afficher la liste des employés ayant deux 'A' dans leur nom.
-----------

SELECT ENAME FROM EMP WHERE ENAME LIKE '%[a]%[a]%'

-----------
--17. Afficher les employés embauchés avant tous les employés du département 10.
-----------

SELECT ENAME, HIREDATE FROM EMP WHERE HIREDATE < (SELECT MIN(HIREDATE) FROM EMP WHERE HIREDATE IN (SELECT HIREDATE FROM EMP WHERE DEPTNO = 10))

-----------
--18. Sélectionner le métier où le salaire moyen est le plus faible
-----------

SELECT JOB, AVG(SAL) as MOYENNE FROM EMP GROUP BY JOB HAVING AVG(SAL) <= ALL (SELECT AVG(SAL) FROM EMP GROUP BY JOB)

-----------
--19. Sélectionner le département ayant le plus d employés.
-----------

SELECT DNAME, COUNT(EMPNO) as NBR_EMP FROM DEPT INNER JOIN EMP ON DEPT.DEPTNO = EMP.DEPTNO GROUP BY DNAME 
HAVING COUNT(EMPNO) >= ALL ( SELECT COUNT(EMPNO) FROM DEPT INNER JOIN EMP ON DEPT.DEPTNO = EMP.DEPTNO GROUP BY DNAME)

-----------
--20.  Donner la répartition en pourcentage du nombre d employés par département selon le modèle ci-dessous

--Département Répartition en % 
--10 21.43 
--20 35.71 
--30 42.86 
-----------

SELECT Dname, ROUND((COUNT(EMPNO)/CONVERT(FLOAT,(select count(EMPNO) from emp))*100),2) as [NBR_EMP %]
FROM dept INNER JOIN EMP ON DEPT.DEPTNO = EMP.DEPTNO GROUP BY DNAME


