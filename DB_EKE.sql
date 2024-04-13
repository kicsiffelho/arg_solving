select *
from dual;

select 2+3
from dual;

select to_char(sysdate, 'yy. MONTH. Day. hh:mi:ss') as "Todays date"
from dual;

select TO_DATE('2001. 05. 20.','yyyy. mm. dd.')
from dual;

select round(MONTHs_BETWEEN(sysdate, TO_DATE('2001. 05. 20.','yyyy. mm. dd.'))/12)
from dual;

create table szemely(
    azon char(3) not null, --minden 3 karaktert kell haszn�lni
    vnev varchar2(40), --varchar2 b�rmilyen karaktert felvehet, lehet 1 �s 40 k�z�tti karakter
    keresztnev varchar2(40),
    neme char(1),
    munka varchar2(40),
    constraint szemely_pk primary key(azon)
    );
    
drop table szemely; --t�bla t�rl�se

alter table szemely
rename column vnev to vezeteknev;

select *
from szemely;

insert into szemely values('001','Er�s','Pista','F','b�dogos');
insert into szemely values('002','Stark','Tony','F','vasember');
insert into szemely values('003','Kiss','Ibolya','N','vir�gk�t�');
insert into szemely values('004','Nagy','�va','N','szab�');
insert into szemely values('005','Kov�cs','B�la','F','aut�szerel�');
insert into szemely values('006','Kov�cs','Zolt�n','F','aut�szerel�');
insert into szemely values('007','Horv�th','G�za','F','informatikus');
insert into szemely values('008','Kov�cs','�va','N','informatikus');

select vezeteknev||' '||keresztnev as N�v
from szemely
where neme = 'N'
and munka = 'szab�';

select vezeteknev||' '||keresztnev as teljes_nev
from szemely
where vezeteknev = 'Kov�cs'
and munka = 'aut�szerel�';

create table kedvenc(
    kedvenc_id number(3) not null,
    nev varchar2(20),
    faj varchar2(20),
    kor number(3),
    constraint kedvenc_pk primary key(kedvenc_id)
);

drop table kedvenc;

select *
from kedvenc;

create table kedvenc(
    kedvenc_id number(3) not null,
    nev varchar2(20),
    faj varchar2(20),
    kor number(3),
    gazdi_id char(3) references szemely(azon),
    constraint kedvenc_pk primary key(kedvenc_id)
);

insert into kedvenc values('101','Marcip�n','cica',2,'001');
insert into kedvenc values('102','Fifi','kutya',6,'001');
insert into kedvenc values('103','Kifli','cica',3,'002');
insert into kedvenc values('104','','hal','','002');
insert into kedvenc values('105','','hal','','002');
insert into kedvenc values('106','','hal','','002');
insert into kedvenc values('107','Bicikli','teh�n',3,'005');
insert into kedvenc values('108','','ty�k','','005');
insert into kedvenc values('109','Kormi','cica',8,'006');
insert into kedvenc values('110','Bodri','kutya',8,'006');
insert into kedvenc values('111','Cs�ri','mad�r','','007');
insert into kedvenc values('112','Cuki','mad�r','1','007');

select nev, kor
from kedvenc
where faj='cica';

select nev
from kedvenc
where faj='kutya'
and kor>6; --6 �vesn�l id�sebb

select nev
from kedvenc
where faj='kutya'
and kor >= 6; --legal�bb 6 �ves

select nev
from kedvenc
where kor is null;

select nev
from kedvenc
where kor is not null;

select nev, faj
from kedvenc
where kor between 2 and 6;

-- 2n�l fiatalabb, 6n�l id�sebb, cica
select nev, kor
from kedvenc
where (kor < 2 or kor > 6)
and faj = 'cica';

select nev, kor
from kedvenc
where kor not between 2 and 6
and faj = 'cica';

select nev, faj
from kedvenc
where faj in ('cica', 'kutya');

select nev, faj
from kedvenc
where faj not in ('cica', 'kutya');

select nvl(nev,'nem ismert'), faj, nvl(kor, 0)
from kedvenc;

select nev
from kedvenc
where nev LIKE 'K%'; --% b�rmennyi karakteer, _ 1 karakter

select nev
from kedvenc
where nev LIKE '_o%';

select nev
from kedvenc
where nev LIKE '%i';

select nev
from kedvenc
where nev LIKE '%i%';

select nev
from kedvenc
where nev LIKE '%i%i%';

select nev
from kedvenc
where nev not LIKE '%i%i%i%' and nev LIKE '%i%i%';

select nev
from kedvenc
where faj = 'kutya'
and nev like '%i%';

select *
from kedvenc k inner join szemely sz
on k.gazdi_id = sz.azon;

select faj
from kedvenc k inner join szemely sz
on k.gazdi_id = sz.azon
where sz.munka = 'aut�szerel�';

select *
from kedvenc k right join szemely sz
on k.gazdi_id = sz.azon;

select *
from kedvenc k left join szemely sz
on k.gazdi_id = sz.azon;

select vezeteknev||' '||keresztnev
from szemely sz left join kedvenc k
on sz.azon = k.gazdi_id
where k.gazdi_id is null;

select *
from kedvenc;

select count(distinct faj)
from kedvenc;

select nev
from kedvenc
order by nev desc;

select nev
from kedvenc
where faj in ('cica', 'kutya', 'mad�r')
and kor >= 3
order by nev;

select *
from szemely
where neme = 'F'
and munka in ('aut�szerel�', 'informatikus')
order by vezeteknev desc;

insert into szemely values('009','Kov�cs','L�szl�','F','tan�r');

select *
from szemely;

select *
from szemely
where vezeteknev = 'Kov�cs'
order by vezeteknev asc, munka desc;

select munka, count(*)
from szemely
group by munka
having count(*) > 1;

select faj, count(*)
from kedvenc
group by faj
having count(*) > 2;

select *
from hr.employees;

select *
from hr.employees
where phone_number like '%423%' and job_id = 'IT_PROG';

select max(salary)
from hr.employees;

select min(salary)
from hr.employees;

select avg(salary)
from hr.employees;

select min(salary)
from hr.employees;

select first_name, last_name
from hr.employees
where salary = (select min(salary) from hr.employees);

select first_name, last_name, salary
from hr.employees
where salary > (select avg(salary) from hr.employees);

select *
from hr.employees e inner join hr.jobs j
on e.job_id = j.job_id;

select first_name, last_name
from hr.employees e inner join hr.jobs j
on e.job_id = j.job_id
where j.job_title = 'Programmer'
order by first_name;

select *
from hr.employees e inner join hr.jobs j
on e.job_id = j.job_id
where job_title like 'Sales Representative' and (months_between(sysdate, hire_date)/12)>20;

select *
from hr.locations;
select *
from hr.jobs;
select *
from hr.employees;
select *
from hr.departments;
select *
from hr.countries;

select first_name, last_name
from hr.employees e inner join hr.departments d
on e.department_id = d.department_id inner join hr.locations l
on d.location_id = l.location_id inner join hr.countries c
on l.country_id = c.country_id
where c.country_name = 'Canada';

select *
from kedvenc;

alter table kedvenc
add (szin varchar(10));

update kedvenc
set szin = 'fekete'
where faj = 'cica';

commit; --v�gleges�t�s

delete from kedvenc
where kor is null;

commit;
savepoint sp;

update kedvenc
set szin = 'feher'
where faj = 'kutya';

rollback sp;
